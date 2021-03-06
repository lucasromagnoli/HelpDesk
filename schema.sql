CREATE DATABASE HELPDESK;

USE HELPDESK;

CREATE TABLE IF NOT EXISTS SETOR (
	ID_SETOR INT PRIMARY KEY AUTO_INCREMENT,
	NOME_SETOR VARCHAR(25) NOT NULL
);

CREATE TABLE IF NOT EXISTS FUNCIONARIO (
	ID_FUNCIONARIO INT PRIMARY KEY AUTO_INCREMENT,
	NOME_FUNCIONARIO VARCHAR(55) NOT NULL,
	DATANASCIMENTO_FUNCIONARIO DATE NOT NULL,
	CPF_FUNCIONARIO CHAR(11) NOT NULL,
	RG_FUNCIONARIO VARCHAR(15) NOT NULL,
	ID_SETOR_FUNCIONARIO INT NOT NULL,

	FOREIGN KEY (ID_SETOR_FUNCIONARIO) REFERENCES SETOR(ID_SETOR)
);

CREATE TABLE IF NOT EXISTS USUARIO (
	ID_USUARIO INT PRIMARY KEY AUTO_INCREMENT,
	LOGIN_USUARIO VARCHAR(15) NOT NULL UNIQUE,
	SENHA_USUARIO VARCHAR(30) NOT NULL,
	NIVELATENDIMENTO_USUARIO CHAR(1) NOT NULL DEFAULT '1',
	ID_FUNCIONARIO_USUARIO INT NOT NULL,

	FOREIGN KEY (ID_FUNCIONARIO_USUARIO) REFERENCES FUNCIONARIO(ID_FUNCIONARIO)
);

CREATE TABLE IF NOT EXISTS OCORRENCIA (
	ID_OCORRENCIA INT PRIMARY KEY AUTO_INCREMENT,
	NUMERO_OCORRENCIA CHAR(15) NOT NULL UNIQUE,
	DATAREGISTRO_OCORRENCIA DATETIME NOT NULL,
	DATAVENCIMENTO_OCORRENCIA DATETIME NOT NULL,
	DATAENCERRAMENTO_OCORRENCIA DATETIME DEFAULT '0001-01-01 00:00:00',
	STATUS_OCORRENCIA CHAR(1) NOT NULL DEFAULT '0',
	DESCRICAO_OCORRENCIA VARCHAR(1000) NOT NULL,
	NIVELATENDIMENTO_OCORRENCIA CHAR(1) NOT NULL DEFAULT '1',
	CATEGORIA_OCORRENCIA VARCHAR(100) NOT NULL DEFAULT 'CATEGORIA DEFAULT',
	ID_SETOR_OCORRENCIA INT NOT NULL,
	ID_USUARIO_OCORRENCIA INT NOT NULL,

	FOREIGN KEY (ID_SETOR_OCORRENCIA) REFERENCES SETOR(ID_SETOR),
	FOREIGN KEY (ID_USUARIO_OCORRENCIA) REFERENCES USUARIO(ID_USUARIO)
);

CREATE TABLE IF NOT EXISTS ACOMPANHAMENTO (
	ID_ACOMPANHAMENTO INT PRIMARY KEY AUTO_INCREMENT,
	DESCRICAO_ACOMPANHAMENTO VARCHAR(1000) NOT NULL,
	DATAABERTURA_ACOMPANHAMENTO DATETIME NOT NULL DEFAULT '0001-01-01 00:00:00',
	ID_USUARIO_ACOMPANHAMENTO INT NOT NULL,
	ID_OCORRENCIA_ACOMPANHAMENTO INT NOT NULL,

	FOREIGN KEY (ID_USUARIO_ACOMPANHAMENTO) REFERENCES USUARIO(ID_USUARIO),
	FOREIGN KEY (ID_OCORRENCIA_ACOMPANHAMENTO) REFERENCES OCORRENCIA(ID_OCORRENCIA)
);