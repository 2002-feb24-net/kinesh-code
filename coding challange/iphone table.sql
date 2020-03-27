CREATE TABLE customer (
		ID INT  primary key NOT NULL , 
        FirstName VARCHAR(50) NOT NULL, 
	    LastName  VARCHAR(50) NULL,
		CardNumber varchar(20) not null,
		)  
INSERT INTO customer (ID, FirstName,LastName,CardNumber ) VALUES ('101','tina','smith','1234569870');
INSERT INTO customer (ID, FirstName,LastName,CardNumber ) VALUES ('102','tina','Patel','1245689102');
INSERT INTO customer (ID, FirstName,LastName,CardNumber ) VALUES ('103','kevin','max',' 1568974230');

drop table customer
drop table orders
drop table product

CREATE TABLE Orders(
    ID INT ,
    customer_id INTEGER,
    Product_id integer,
	);

INSERT INTO Orders(Id,customer_id,Product_id ) VALUES ('101','1','2');
INSERT INTO Orders(Id,customer_id,Product_id ) VALUES ('102','2','10');
INSERT INTO Orders(Id,customer_id,Product_id ) VALUES ('103','3','20');

CREATE TABLE Product (
		ID INT primary key NOT NULL , 
        Name VARCHAR(50) NOT NULL, 
	    Price int,
		)
 INSERT INTO Product(Id,Name,Price ) VALUES ('101','Iphone','200');
 INSERT INTO Product(Id,Name,Price ) VALUES ('102','Iphone 5','560');
 INSERT INTO Product(Id,Name,Price ) VALUES ('103','Iphone 8','860');

select * from customer
select * from Orders
select* from Product