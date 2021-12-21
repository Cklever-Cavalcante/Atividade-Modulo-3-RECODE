CREATE TABLE Clientes 
( 
 nome VARCHAR(50) NOT NULL,  
 telefone CHAR(10) NOT NULL,  
 cidade_reside VARCHAR(50) NOT NULL,  
 id_cliente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,  
 uf_reside CHAR(2) NOT NULL,  
 email VARCHAR(50) NOT NULL,  
 país_reside VARCHAR(50) NOT NULL,  
); 

CREATE TABLE Destinos 
( 
 id_destino INT PRIMARY KEY IDENTITY(1,1) NOT NULL,  
 cidade VARCHAR(50) NOT NULL,  
 estado VARCHAR(50) NOT NULL,  
 país VARCHAR(50) NOT NULL,  
); 

CREATE TABLE Pacotes 
( 
 id_pacote INT PRIMARY KEY IDENTITY(1,1) NOT NULL,  
 num_acompanhantes INT,  
 hospedagem_sim_nao CHAR(3),  
 preco FLOAT NOT NULL,  
 data_ida DATE NOT NULL,  
 data_volta DATE NOT NULL,  
); 

CREATE TABLE Compra 
( 
 id_cliente INT PRIMARY KEY,  
 id_pacote INT,  
); 

CREATE TABLE Usa 
( 
 id_pacote INT PRIMARY KEY,  
 id_destino INT,  
); 

ALTER TABLE Compra ADD FOREIGN KEY(id_cliente) REFERENCES Clientes (id_cliente)
ALTER TABLE Compra ADD FOREIGN KEY(id_pacote) REFERENCES Pacotes (id_pacote)
ALTER TABLE Usa ADD FOREIGN KEY(id_pacote) REFERENCES Pacotes (id_pacote)
ALTER TABLE Usa ADD FOREIGN KEY(id_destino) REFERENCES Destinos (id_destino)