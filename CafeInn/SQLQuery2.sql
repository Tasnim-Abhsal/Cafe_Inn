CREATE TABLE users 
(
id INT PRIMARY KEY IDENTITY (1,1),
username VARCHAR(MAX) NULL,
password VARCHAR(MAX) NULL,
role VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_reg DATETIME NULL
)
SELECT *FROM users
INSERT INTO users (username,password,role,status,date_reg) VALUES ('admin','12345678','Admin','Active','2024-10-6')

CREATE TABLE products
(
id INT PRIMARY KEY IDENTITY (1,1),
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
prod_type VARCHAR(MAX) NULL,
prod_stock INT NULL,
prod_price FLOAT NULL,
prod_status VARCHAR(MAX) NULL,
date_insert DATE NULL,
date_update DATE NULL,
date_delete DATE NULL
)
SELECT *FROM products

CREATE TABLE orders(

id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
prod_type VARCHAR(MAX) NULL,
prod_price FLOAT NULL,
order_date DATE NULL,
delete_order DATE NULL,
qty INT NULL

)
SELECT *FROM orders




CREATE TABLE customers(
id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
total_price FLOAT NULL,
date DATE NULL

)
SELECT MAX(id) FROM customers
SELECT *FROM customers



