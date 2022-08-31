CREATE DATABASE [JarmuvekAB];

USE [JarmuvekAB];

CREATE TABLE [Jarmuvek](
	[Rendszam] VARCHAR(10) PRIMARY KEY,
	[Gyarto] VARCHAR(20) NOT NULL,
	[Tipus] VARCHAR(20) NOT NULL,
	[Hengerurtartalom] FLOAT NOT NULL
);

CREATE TABLE [Autok](
	[Rendszam] VARCHAR(10) PRIMARY KEY,
	[AutoTipus] INT NOT NULL,
	[CsomagterL] FLOAT NOT NULL,

	FOREIGN KEY ([Rendszam]) REFERENCES [Jarmuvek]([Rendszam])
);

CREATE TABLE [Motorok](
	[Rendszam] VARCHAR(10) PRIMARY KEY,
	[MotorTipus] INT NOT NULL,
	[Jogostivany] VARCHAR(5),

	FOREIGN KEY ([Rendszam]) REFERENCES [Jarmuvek]([Rendszam])
);

SELECT * FROM [Jarmuvek];
SELECT * FROM [Motorok];
SELECT * FROM [Autok];