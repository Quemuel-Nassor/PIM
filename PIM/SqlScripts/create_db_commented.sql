----This command bellow remove and recreate database
--DROP DATABASE IF EXISTS Holerite_Pim;
--CREATE DATABASE Holerite_Pim;

use Holerite_Pim;

--Creatig Cargo Table
CREATE TABLE Cargo (
    Id SERIAL NOT NULL,
    Nome VARCHAR(50),
    PRIMARY KEY (Id)
);

--Creatig Permissao Table
CREATE TABLE Permissao (
    Id SERIAL NOT NULL,
    Nome VARCHAR(50),
    PRIMARY KEY (Id)
);

--Creating Funcionario Table
--Added FK Constraints with cascade action on delete dependent registers
CREATE TABLE Funcionario (
    Id SERIAL NOT NULL,
    CreationTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Nome VARCHAR(50),
    Cpf VARCHAR(14),
    Celular VARCHAR(13),
    Email VARCHAR(50),
    Senha VARCHAR(50),
    Ativo BOOLEAN NOT NULL DEFAULT TRUE,
    IdCargo BIGINT UNSIGNED NOT NULL,
    IdPermissao BIGINT UNSIGNED NOT NULL,
    PRIMARY KEY (Id),
    CONSTRAINT FK_CargoFuncionario FOREIGN KEY (IdCargo)
        REFERENCES Cargo (Id)
        ON DELETE CASCADE,
    CONSTRAINT FK_PermissaoFuncionario FOREIGN KEY (IdPermissao)
        REFERENCES Permissao (Id)
        ON DELETE CASCADE
);

--Creating Holerite Table
--Added FK Constraints with cascade action on delete dependent registers
CREATE TABLE Holerite (
    Id SERIAL NOT NULL,
    CreationTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    SalarioLiquido DECIMAL(10,2),
    SalarioBruto DECIMAL(10,2),
    Fgts DECIMAL(10,2),
    Inss DECIMAL(10,2),
    ValeTransporte DECIMAL(10,2),
    IdFuncionario BIGINT UNSIGNED NOT NULL,
    PRIMARY KEY (Id),
    CONSTRAINT FK_FuncionarioHolerite FOREIGN KEY (IdFuncionario)
        REFERENCES Funcionario (Id)
        ON DELETE CASCADE
);