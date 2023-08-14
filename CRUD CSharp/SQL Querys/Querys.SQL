-- Cria o banco de dados TOCC8.
CREATE DATABASE TOCC8;

-- Cria a tabela de produtos.
CREATE TABLE Produtos(
    codigo SERIAL PRIMARY KEY,
    descricao VARCHAR (100),
    dataValidade DATE,
    preco FLOAT,
    taxaLucro FLOAT
);
