INSERT INTO SETOR (NOME_SETOR) VALUES ('TECNOLOGIA DA INFORMAÇÃO');
INSERT INTO FUNCIONARIO (NOME_FUNCIONARIO, DATANASCIMENTO_FUNCIONARIO, CPF_FUNCIONARIO, RG_FUNCIONARIO, ID_SETOR_FUNCIONARIO) VALUES ('Oliver Matheus Arthur Martins', '1996-03-14', '08224315215', '379009626', 1);
INSERT INTO USUARIO (LOGIN_USUARIO, SENHA_USUARIO, ID_FUNCIONARIO_USUARIO) VALUES ('Admin', '123456', 1);
INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, DATAVENCIMENTO_OCORRENCIA, DATAENCERRAMENTO_OCORRENCIA, STATUS_OCORRENCIA, DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA, ID_USUARIO_OCORRENCIA) VALUES ('123456789012345', '2011-12-18 13:17:17', '2011-12-18 13:17:17','0005-05-05 05:05:05', '0','DESCRIÇÃO DA PORRA TODA!', 1, 1);



-- INSERT OCORRÊNCIA, ADICIONA UMA NOVA OCORRÊNCIA NO BANCO DE DADOS.
INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, 
DATAVENCIMENTO_OCORRENCIA, STATUS_OCORRENCIA, 
DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA,
ID_USUARIO_OCORRENCIA) VALUES ('000000000000001','2011-12-18 13:17:17',
'2011-12-18 13:17:17', '0', 'DESCRICAO', 1, 1
);

-- SELECT OCORRENCIA, QUEM ABRIU A OCORRENCIA E QUAL O SETOR DA MESMA. CONDIÇÃO: NÚMERO DA OCORRÊNCIA.
SELECT OC.ID_OCORRENCIA, OC.NUMERO_OCORRENCIA, OC.DATAREGISTRO_OCORRENCIA,
OC.DATAVENCIMENTO_OCORRENCIA, OC.DATAENCERRAMENTO_OCORRENCIA,
OC.STATUS_OCORRENCIA, OC.DESCRICAO_OCORRENCIA,
SE.ID_SETOR, SE.NOME_SETOR,
US.ID_USUARIO, US.LOGIN_USUARIO
FROM OCORRENCIA OC
INNER JOIN SETOR SE
ON OC.ID_SETOR_OCORRENCIA = SE.ID_SETOR
INNER JOIN USUARIO US
ON OC.ID_USUARIO_OCORRENCIA = US.ID_USUARIO
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

INSERT INTO OCORRENCIA (NUMERO_OCORRENCIA, DATAREGISTRO_OCORRENCIA, DATAVENCIMENTO_OCORRENCIA, STATUS_OCORRENCIA, DESCRICAO_OCORRENCIA, ID_SETOR_OCORRENCIA, ID_USUARIO_OCORRENCIA) VALUES (?NUMERO_OCORRENCIA, ?DATAREGISTRO_OCORRENCIA,?DATAVENCIMENTO_OCORRENCIA, ?STATUS_OCORRENCIA, ?DESCRICAO_OCORRENCIA, ?ID_SETOR_OCORRENCIA, ?ID_USUARIO_OCORRENCIA);