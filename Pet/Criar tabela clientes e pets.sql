CREATE table Clientes(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Nome nvarchar (100) not null,
	Telefone varchar (15) not null,
	Endereco nvarchar (250),
	Cidade nvarchar (30),
	Bairro nvarchar (30),
	Observacao nvarchar (250)
)

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

select * from Clientes
select * from Pets

insert into Clientes VALUES ('Jorji', '51 999887766','av. rio grande do sul, 1150, mathias velho, canoas','','','calvo')
insert into Clientes VALUES ('Roberto', '51 999886677','rua santa catarina, 2684, mathias velho, canoas','','','careca')

insert into Pets VALUES ('toby',2,'Vira lata',1,'pelo escuro, subpelo','M',0,Convert(smalldatetime,'2022-06-23'),'Cachorro se assusta com barulho')
insert into Pets VALUES ('rex',1,'poodle',1,'pelo claro','P',0,Convert(smalldatetime,'2021-09-12'),'')
