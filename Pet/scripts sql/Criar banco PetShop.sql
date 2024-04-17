begin
	IF not exists(Select * from sys.databases where name= 'PetShop')
		create DATABASE PetShop
END

begin
use PetSHOP

IF Not exists(Select * FROM sys.tables where name = 'Clientes')
	CREATE table Clientes(
		Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
		Nome nvarchar (100) not null,
		Telefone varchar (15) not null,
		Endereco nvarchar (250),
		Cidade nvarchar (30),
		Bairro nvarchar (30),
		Observacao nvarchar (250)
	)

IF Not exists(Select * FROM sys.tables where name = 'Pets')
CREATE TABLE Pets(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nome nvarchar (30) NOT NULL,
	IdCliente int NOT NULL,
	Raca nvarchar (40) NOT NULL,
	Vacinado bit NOT NULL,
	TipoPelagem nvarchar (50),
	Porte char(1),
	Alergia bit NOT NULL,
	DataNascimento SmallDatetime,
	Observacao nvarchar (250)

	CONSTRAINT FK_Pet_Cliente FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id)
)
IF Not exists(Select * FROM sys.tables where name = 'Pedidos')
CREATE table Pedidos(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	IdCliente int NOT NULL,
	IdPet int NOT NULL,
	EmAberto int NOT NULL,
	Valor decimal (9) not null,
	Data SmallDatetime NOT NULL,
	Procedimento nvarchar (500),

	CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id),

	CONSTRAINT FK_Pedido_Pet FOREIGN KEY (IdPet) REFERENCES Pets(Id)
)
IF Not exists(Select * FROM sys.tables where name = 'Insumos')
CREATE TABLE Insumos(
	Id int Primary KEY IDENTITY (1,1) Not null,
	Nome nvarchar (100) NOT NULL,
	Custo decimal Not Null
	
)

IF Not exists(Select * FROM sys.tables where name = 'InsumosPedidos')
CREATE TABLE InsumosPedidos(
	Id int Primary KEY IDENTITY (1,1) Not null,
	IdPedido int Not null,
	IdInsumo int not null,

	CONSTRAINT FK_InsumosPedidos_Pedidos FOREIGN KEY (IdPedido) REFERENCES Pedidos(Id),

	CONSTRAINT FK_InsumosPedidos_Insumo FOREIGN KEY (IdInsumo) REFERENCES Insumos(Id)

)

end