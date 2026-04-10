SHOW DATABASES;

CREATE DATABASE stocka_pemvis;

USE stocka_pemvis;

CREATE TABLE user (
	username VARCHAR(50) NOT NULL PRIMARY KEY,
    password VARCHAR(50) NOT NULL
) ENGINE = innodb;

CREATE TABLE pakaian (
	sku VARCHAR(15) NOT NULL PRIMARY KEY,
    nama VARCHAR(255) NOT NULL,
    ukuran VARCHAR(5) NOT NULL,
    harga INT NOT NULL,
    stok INT NOT NULL
) ENGINE = innodb;

TRUNCATE TABLE pakaian;

INSERT INTO user (username, password) 
	VALUES ("eko", "rahasia");

SELECT username, password FROM user 
	WHERE username = "eko" AND password = "rahasia";
    
INSERT INTO pakaian(sku, nama, ukuran, harga, stok)
	VALUES ("UNI-FLB-BLU-LGE", "Kemeja Flanel Pria Lengan Panjang Uniqlo Warna Biru", "L", "200000", "200");
    
SELECT * FROM pakaian;

UPDATE pakaian
	SET nama = "haha", ukuran = "XL", harga = "22", stok = "200"
    WHERE sku = "NK-TSH-BLK-00L";

