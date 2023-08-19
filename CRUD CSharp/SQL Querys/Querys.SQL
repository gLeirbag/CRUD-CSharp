-- Acabei usando letra minúscula para tudo.
-- Cria o banco de dados TOCC8.
CREATE DATABASE tocc8;

-- Cria a tabela de produtos.
CREATE TABLE produtos(
    codigo SERIAL PRIMARY KEY,
    descricao VARCHAR (100),
    dataValidade DATE,
    preco FLOAT,
    taxaLucro FLOAT
);
