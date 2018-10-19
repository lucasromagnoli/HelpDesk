INSERT INTO SETOR (NOME_SETOR) VALUES ('TECNOLOGIA DA INFORMAÇÃO');
INSERT INTO FUNCIONARIO (NOME_FUNCIONARIO, DATANASCIMENTO_FUNCIONARIO, CPF_FUNCIONARIO, RG_FUNCIONARIO, ID_SETOR_FUNCIONARIO) VALUES ('Oliver Matheus Arthur Martins', '1996-03-14', '08224315215', '379009626', 1);
INSERT INTO USUARIO (LOGIN_USUARIO, SENHA_USUARIO, ID_FUNCIONARIO_USUARIO) VALUES ('Admin', '123456', 1);
INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, DATAVENCIMENTO_OCORRENCIA, DATAENCERRAMENTO_OCORRENCIA, STATUS_OCORRENCIA, DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA, ID_USUARIO_OCORRENCIA) VALUES ('123456789012345', '2011-12-18 13:17:17', '2011-12-18 13:17:17','0005-05-05 05:05:05', '0','DESCRIÇÃO DA PORRA TODA!', 1, 1);

INSERT INTO ACOMPANHAMENTO (DESCRICAO_ACOMPANHAMENTO, ID_FUNCIONARIO_ACOMPANHAMENTO, ID_OCORRENCIA_ACOMPANHAMENTO) VALUES ("ACOMPANHAMENTO", 1, 1);

-- INSERT OCORRÊNCIA, ADICIONA UMA NOVA OCORRÊNCIA NO BANCO DE DADOS.
INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, 
DATAVENCIMENTO_OCORRENCIA, STATUS_OCORRENCIA, 
DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA,
ID_USUARIO_OCORRENCIA) VALUES ('000000000000001','2011-12-18 13:17:17',
'2011-12-18 13:17:17', '0', 'DESCRICAO', 1, 1
);

SELECT OC.ID_OCORRENCIA, OC.NUMERO_OCORRENCIA, OC.DATAREGISTRO_OCORRENCIA,
OC.DATAVENCIMENTO_OCORRENCIA, OC.DATAENCERRAMENTO_OCORRENCIA,
OC.STATUS_OCORRENCIA, OC.DESCRICAO_OCORRENCIA,
SE.ID_SETOR, SE.NOME_SETOR,
US.ID_USUARIO, US.LOGIN_USUARIO
FROM OCORRENCIA OC
INNER JOIN SETOR SE
-- SELECT OCORRENCIA, QUEM ABRIU A OCORRENCIA E QUAL O SETOR DA MESMA. CONDIÇÃO: NÚME
ON OC.ID_SETOR_OCORRENCIA = SE.ID_SETOR
INNER JOIN USUARIO US
ON OC.ID_USUARIO_OCORRENCIA = US.ID_USUARIO
WHERE OC.NUMERO_OCORRENCIA = '123456789012345';

-- SELECT ACOMPANHAMENTO
SELECT AC.ID_ACOMPANHAMENTO, AC.DESCRICAO_ACOMPANHAMENTO,
AC.NUMERO_ACOMPANHAMENTO, AC.ID_FUNCIONARIO_ACOMPANHAMENTO,
AC.ID_OCORRENCIA_ACOMPANHAMENTO, OC.NUMERO_OCORRENCIA
FROM ACOMPANHAMENTO AC
INNER JOIN OCORRENCIA OC
ON AC.ID_OCORRENCIA_ACOMPANHAMENTO = OC.ID_OCORRENCIA
WHERE OC.NUMERO_OCORRENCIA = '123456789012345';

-- SELECT OCORRENCIA, QUEM ABRIU A OCORRENCIA E QUAL O SETOR DA MESMA. CONDIÇÃO: ID DO USUÁRIO QUE ABRIU A OCORRÊNCIA.
SELECT OC.ID_OCORRENCIA, OC.NUMERO_OCORRENCIA, OC.DATAREGISTRO_OCORRENCIA,
OC.DATAVENCIMENTO_OCORRENCIA, OC.DATAENCERRAMENTO_OCORRENCIA,
OC.STATUS_OCORRENCIA, OC.DESCRICAO_OCORRENCIA,
SE.ID_SETOR, SE.NOME_SETOR
FROM OCORRENCIA OC
INNER JOIN SETOR SE
ON OC.ID_SETOR_OCORRENCIA = SE.ID_SETOR
WHERE OC.ID_USUARIO_OCORRENCIA = 1;

-- SELECT USUARIO, TODOS AS INFORMAÇÕES DO USUÁRIO E FUNCIONARIO. CONDIÇÃO: ID DO USUÁRIO.
SELECT US.ID_USUARIO, US.LOGIN_USUARIO, US.NIVELATENDIMENTO_USUARIO,
FU.NOME_FUNCIONARIO, FU.DATANASCIMENTO_FUNCIONARIO, FU.CPF_FUNCIONARIO, FU.RG_FUNCIONARIO,
SE.ID_SETOR, SE.NOME_SETOR
FROM USUARIO US
INNER JOIN FUNCIONARIO FU
ON US.ID_FUNCIONARIO_USUARIO = FU.ID_FUNCIONARIO
INNER JOIN SETOR SE
ON FU.ID_SETOR_FUNCIONARIO = SE.ID_SETOR
WHERE US.ID_USUARIO = 1;

-- SELECT USUARIO, TODOS AS INFORMAÇÕES DO USUÁRIO E FUNCIONARIO. CONDIÇÃO: LOGIN DO USUÁRIO.
SELECT US.ID_USUARIO, US.LOGIN_USUARIO, US.NIVELATENDIMENTO_USUARIO,
FU.NOME_FUNCIONARIO, FU.DATANASCIMENTO_FUNCIONARIO, FU.CPF_FUNCIONARIO, FU.RG_FUNCIONARIO,
SE.ID_SETOR, SE.NOME_SETOR
FROM USUARIO US
INNER JOIN FUNCIONARIO FU
ON US.ID_FUNCIONARIO_USUARIO = FU.ID_FUNCIONARIO
INNER JOIN SETOR SE
ON FU.ID_SETOR_FUNCIONARIO = SE.ID_SETOR
WHERE US.LOGIN_USUARIO = "admin";

-- AUTHENTICA O USUÁRIO, CONFIRMANDO SE LOGIN E SENHA CONFEREM.
SELECT COUNT(*) FROM USUARIO
WHERE LOGIN_USUARIO = "admin" 
AND
SENHA_USUARIO = BINARY "123456";





-- SELECT ACOMPANHAMENTO
SELECT AC.ID_ACOMPANHAMENTO, AC.DESCRICAO_ACOMPANHAMENTO, AC.NUMERO_ACOMPANHAMENTO, AC.ID_FUNCIONARIO_ACOMPANHAMENTO, AC.ID_OCORRENCIA_ACOMPANHAMENTO, OC.NUMERO_OCORRENCIA FROM ACOMPANHAMENTO AC INNER JOIN OCORRENCIA OC ON AC.ID_OCORRENCIA_ACOMPANHAMENTO = OC.ID_OCORRENCIA WHERE OC.NUMERO_OCORRENCIA = ?numero;