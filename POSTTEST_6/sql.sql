SHOW DATABASES;

CREATE DATABASE stocka_pemvis;
DROP DATABASE stocka_pemvis;

USE stocka_pemvis;

CREATE TABLE user (
	username VARCHAR(50) NOT NULL PRIMARY KEY,
    password VARCHAR(50) NOT NULL
) ENGINE = innodb;

CREATE TABLE ukuran (
	id VARCHAR(3) NOT NULL PRIMARY KEY,
    nama VARCHAR(5) NOT NULL
) ENGINE = innodb;

CREATE TABLE pakaian (
	sku VARCHAR(15) NOT NULL PRIMARY KEY,
    nama VARCHAR(255) NOT NULL,
    harga INT NOT NULL,
    stok INT NOT NULL,
    id_ukuran VARCHAR(3) NOT NULL,
    CONSTRAINT fk_pakaian_ukuran
		FOREIGN KEY(id_ukuran)
        REFERENCES ukuran(id)
        ON UPDATE RESTRICT
        ON DELETE RESTRICT
) ENGINE = innodb;

DROP TABLE pakaian;
DROP TABLE ukuran;
TRUNCATE TABLE pakaian;

INSERT INTO user (username, password) 
	VALUES ("eko", "rahasia");

INSERT INTO ukuran(id, nama)
	VALUES("S01", "L");
    
INSERT INTO pakaian(sku, nama, harga, stok, id_ukuran)
	VALUES ("UNI-FLB-BLU-LGE", "Kemeja Flanel Pria Lengan Panjang Uniqlo Warna Biru", 200000, 200, "S01");
    
UPDATE ukuran
	SET nama = "XL"
	WHERE id = "S01";
    
SELECT * FROM user;
SELECT * FROM pakaian;
SELECT * FROM ukuran;

