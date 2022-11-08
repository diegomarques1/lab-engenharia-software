Create database iChurras

use iChurras

create table tblClientes(
CodCliente int not null primary key identity(1,1),
Nome varchar(30),
email varchar(30),
senha varchar(30), 
telefone varchar(15)
)

create table tblEndereco(
endereco varchar(75) primary key not null,
CodCliente int not null foreign key references tblClientes(CodCliente)
)

create table tblCartao(
NumCartao char(16) not null primary key,
nome varchar(50),
NumSeguranca char(3),
validade char(5),
CodCliente int not null foreign key references tblClientes(CodCliente)
)

create table tblProdutos(
CodProduto int not null primary key identity(1,1),
NomeProduto varchar(30),
Preco money, 
descricao varchar (80),
Tipo_de_Produto int
)

create table tblPedidos(
CodPedido int not null primary key identity(1,1),
estadoPedido int,
preco float,
dataPedido datetime,
taxaEntrega float,
codRecebimento char(3),
previsaoEntrega datetime,
avaliacao int,
CodCliente int not null foreign key references tblClientes(CodCliente),
endereco varchar(75) not null foreign key references tblEndereco(endereco)
)

create table tblPedidos_Produtos(
CodPedido int not null foreign key references tblPedidos(CodPedido),
CodProduto int not null foreign key references tblProdutos(CodProduto),
Quantidade int
)

create table tblProdutosFavoritos(
CodProduto int not null foreign key references tblProdutos(CodProduto),
CodCliente int not null foreign key references tblClientes(CodCliente),
)


CREATE INDEX XtblClientes ON tblClientes(CodCliente)
CREATE INDEX XtblProdutos ON tblProdutos(CodProduto)
CREATE INDEX XtblPedidos ON tblPedidos(CodPedidos)


insert into tblClientes(Nome, email, senha, telefone)
values ('Santiago Ferrer', 'aisanti@gmail.com', 'abc234', '916512462'),
('Lucas Andrew', 'goianocareca@gmail.com', 'xyz123', '914562113'),
('Lucas Camargo', 'anaodomd@gmail.com', 'fgh456', '934951851')

insert into tblEndereco(endereco,CodCliente)
values ('Rua ajkkgd', 1),
('Rua godigodfgdgo', 2),
('Ruaçajmklkasjfgl', 3)

insert into tblCartao(NumCartao, nome, NumSeguranca, validade, CodCliente)
values (9125165452364895, 'SANTIAGO F BALCAZAR', 123, '01/02/2023', 1),
(1265349576812456, 'LUCAS A LOPES', 245, '01/04/2023', 2),
(9635428631957568, 'LUCAS C GONCALVES', 987, '01/12/2022', 3)

insert into tblProdutos(NomeProduto,Preco,descricao,Tipo_de_Produto)
values ('Prato 1', 15.00,'aaaaaaa',1),
('Prato 2', 13.50,'bbbbbbbbb',1),
('Bebida 1', 5.00,'aaaa',2),
('Prato 3', 17.00,'cccccc',1),
('Bebida 2', 4.50,'bbbb',2)

select * from tblProdutos

select * from tblPedidos

select * from tblClientes

select * from tblCartao

delete from tblCartao where validade = '10/24'

select * from tblProdutosFavoritos

select NomeProduto from tblProdutos

GO
CREATE PROCEDURE usp_aspLogin
	@EmailASP varchar(30),
	@SenhaASP varchar(50)
AS
	DECLARE @getCliente varchar(30), @getSenha varchar(50), @getCodCliente int

	SET @getCliente = (SELECT email FROM tblClientes 
					WHERE email = @EmailASP)
	SET @getSenha = (SELECT senha FROM tblClientes 
					WHERE email = @EmailASP)
	SET @getCodCliente = (SELECT CodCliente FROM tblClientes WHERE email = @EmailASP)

	IF(@SenhaASP = @getSenha)
		BEGIN
			SELECT CodCliente,Nome,email,telefone from tblClientes where CodCliente = @getCodCliente
		END
	ELSE
		BEGIN
			SELECT ('false') 
		END

GO
CREATE PROCEDURE usp_aspCadastro
	@EmailASP varchar(50),
	@SenhaASP varchar(50),
	@NomeASP varchar(30),
	@TelefoneASP varchar(15),
	@EnderecoASP varchar(75)
AS
	DECLARE @getCodCliente int
	
	INSERT INTO tblClientes VALUES (@NomeASP, @EmailASP, @SenhaASP, @TelefoneASP)

	SET @getCodCliente = (SELECT CodCliente FROM tblClientes WHERE email = @EmailASP)

	INSERT INTO tblEndereco VALUES (@EnderecoASP, @getCodCliente)
	
	SELECT (@getCodCliente)


EXEC usp_aspCadastro 'caradomodem@gmail.com', 'abc000', 'Gustavo Coleto', '953364852', 'Ruasjdjasf'

EXEC usp_aspLogin 'aisanti@gmail.com', 'asdkjf'

select * from tblProdutos where CodProduto = '20' or NomeProduto like '%20%' or Preco like $20 or descricao like '%20%'

update tblProdutos set Preco = $50.00 where CodProduto = 5	

update tblProdutos set NomeProduto = 'Macarrão' where CodProduto = 1 

delete from tblClientes where Nome = 'Gustavo Coleto'

delete from tblEndereco where endereco = 'Rua João Moura, 367'

select * from tblPedidos where CodPedidos = 6 or CodMesa = 6 or CodFunc = 6

insert into tblPedidos(estadoPedido,preco,dataPedido,taxaEntrega,codRecebimento,previsaoEntrega,CodCliente,endereco) values (0,13.5,'20221107 18:37 ',41.909,'568','20221107 20:16 ',4,'Rua Almadina, 200')

INSERT INTO tblCartao values ('1548965321479554', 'JULIO M COSTA', '653', '11/25', 4)

delete from tblCartao where CodCliente = 4