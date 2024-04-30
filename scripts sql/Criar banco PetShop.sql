-- execute este bloco primeiro para criar o banco

BEGIN
	IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PetShop')
	BEGIN
		CREATE DATABASE PetShop;
	END
END;

-- após criar o branco, execute o resto do script

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

IF Not exists(Select * FROM sys.tables where name = 'OrdemDeServico')
CREATE table OrdemDeServico(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	IdCliente int NOT NULL,
	IdPet int NOT NULL,
	EmAberto int NOT NULL,
	Valor decimal (9,2) NOT NULL,
	Data SmallDatetime NOT NULL,
	Procedimento nvarchar (500),

	CONSTRAINT FK_OrdemDeServico_Cliente FOREIGN KEY (IdCliente)
	REFERENCES Clientes(Id),

	CONSTRAINT FK_OrdemDeServico_Pet FOREIGN KEY (IdPet) REFERENCES Pets(Id)
)

IF Not exists(Select * FROM sys.tables where name = 'Insumos')
CREATE TABLE Insumos(
	Id int Primary KEY IDENTITY (1,1) Not null,
	Nome nvarchar (100) NOT NULL,
	Custo decimal (9,2) NOT NULL,
	Estoque float NOT NULL,
	UnidadeMedida varchar (5),
	Volume float,
)

IF Not exists(Select * FROM sys.tables where name = 'BarrasInsumos')
CREATE TABLE BarrasInsumos(
	Id int Primary KEY IDENTITY (1,1) NOT NULL,
	IdInsumo int NOT NULL,
	CodBarras varchar (15) NOT NULL,
	
	CONSTRAINT FK_BarrasInsumos_Insumos FOREIGN KEY (IdInsumo) REFERENCES Insumos(Id),
)

IF Not exists(Select * FROM sys.tables where name = 'InsumosOrdemDeServico')
CREATE TABLE InsumosOrdemDeServico(
	Id int Primary KEY IDENTITY (1,1) Not null,
	IdOrdem int NOT NULL,
	IdInsumo int NOT NULL,
	Quantidade float,

	CONSTRAINT FK_InsumosOrdemDeServico_OrdemDeServico FOREIGN KEY (IdOrdem) REFERENCES OrdemDeServico(Id),

	CONSTRAINT FK_InsumosOrdemDeServico_Insumo FOREIGN KEY (IdInsumo) REFERENCES Insumos(Id)

)

IF Not exists(Select * FROM sys.tables where name = 'LancamentoInsumos')
CREATE TABLE LancamentoInsumos(
	Id int Primary KEY IDENTITY (1,1) Not null,
	ValorTotal decimal (10,2),
	Tipo int NOT NULL, -- 0 saída , 1 entrada
)

IF Not exists(Select * FROM sys.tables where name = 'LancamentoInsumoCodigo')
CREATE TABLE LancamentoInsumoCodigo(
	Id int Primary KEY IDENTITY (1,1) Not null,
	IdInsumo int NOT NULL,
	IdLancamento int NOT NULL,
	Quantidade float NOT NULL,
	CustoInsumo decimal (10,2),
	

	CONSTRAINT FK_LancamentoInsumoCodigo_Insumo FOREIGN KEY (IdInsumo) REFERENCES Insumos(Id),

	CONSTRAINT FK_LancamentoInsumoCodigo_Lancamento FOREIGN KEY (IdLancamento) REFERENCES LancamentoInsumos(Id)
)


end