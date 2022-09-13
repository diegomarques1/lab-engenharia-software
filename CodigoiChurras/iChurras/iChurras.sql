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
endereco varchar(75) primary key,
CodCliente int not null foreign key references tblClientes(CodCliente)
)

create table tblCartao(
NumCartao bigint not null primary key,
nome varchar(50),
NumSeguranca int,
validade date,
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
CodPedidos int not null primary key identity(1,1),
estadoPedido int,
preco varchar(30),
dataPedido datetime,
taxaEntrega varchar(30),
codRecebimento varchar(10),
previsaoEntrega datetime,
nomeEntregador varchar(30),
avaliacao int
)

create table tblPedidos_Produtos(
CodPedidos int not null foreign key references tblPedidos(CodPedidos),
CodProduto int not null foreign key references tblProdutos(CodProduto),
Quantidade int
)

CREATE INDEX XtblClientes ON tblClientes(CodCliente)
CREATE INDEX XtblProdutos ON tblProdutos(CodProduto)
CREATE INDEX XtblPedidos ON tblPedidos(CodPedidos)


insert into tblClientes(Nome, email, senha, telefone)
values ('Santiago Ferrer', 'aisanti@gmail.com', 'asdkjf', '916512462'),
('Lucas Andrew', 'goianocareca@gmail.com', 'ajfkplsk', '914562113'),
('Lucas Camargo', 'anaodomd@gmail.com', 'jkfjld', '934951851')

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

select * from tblClientes

GO
CREATE PROCEDURE usp_aspLogin
	@ClienteASP varchar(50),
	@SenhaASP varchar(50)
AS
	DECLARE @getCliente varchar(50), @getSenha varchar(50), @getCodCliente int

	SET @getCliente = (SELECT email FROM tblClientes 
					WHERE email = @ClienteASP)
	SET @getSenha = (SELECT senha FROM tblClientes 
					WHERE email = @ClienteASP)
	SET @getCodCliente = (SELECT CodCliente FROM tblClientes WHERE email = @ClienteASP)

	IF(@SenhaASP = @getSenha)
		BEGIN
			SELECT * from tblClientes where CodCliente = @getCodCliente
		END
	ELSE
		BEGIN
			SELECT ('false') 
		END
GO

EXEC usp_aspLogin 'aisanti@gmail.com', 'asdkjf'

select * from tblProdutos where CodProduto = '20' or NomeProduto like '%20%' or Preco like $20 or descricao like '%20%'

update tblProdutos set Preco = $50.00 where CodProduto = 5	

update tblProdutos set NomeProduto = 'Macarrão' where CodProduto = 1 

select * from tblPedidos where CodPedidos = 6 or CodMesa = 6 or CodFunc = 6