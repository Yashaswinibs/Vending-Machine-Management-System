CREATE TABLE USERS (
	Username	TEXT	PRIMARY KEY,
	Password	TEXT	NOT NULL,
	FullName	TEXT	NOT NULL,
	Tokens		INTEGER DEFAULT(0)
);



CREATE TABLE VENDING_MACHINES (
	VMID		TEXT(8)	PRIMARY KEY,
	VMLocation	Text	NOT NULL,
	Status		INTEGER	DEFAULT(0)
);



CREATE TABLE PRODUCTS (
	ProductID		TEXT(8)	PRIMARY KEY,
	ProductName		TEXT	NOT NULL,
	ProductPrice	INTEGER	NOT NULL
);


CREATE TABLE PRODUCTS_AVAILABLE (
	VMID		TEXT(8)	REFERENCES	VENDING_MACHINES(VMID),
	ProductID	TEXT	REFERENCES	PRODUCTS(ProductID),
	Quantity	INTEGER	NOT NULL,
	UNIQUE		(VMID, ProductID)
);



CREATE TABLE ADMINS (
	Username	TEXT	PRIMARY KEY,
	Password	TEXT	NOT NULL,
	FullName	TEXT	NOT NULL
);



CREATE TABLE PURCHASES (
	PurchaseID		INTEGER	PRIMARY KEY AUTOINCREMENT,
	VMID			TEXT(8)	REFERENCES	VENDING_MACHINES(VMID),
	ProductID		TEXT(8)	REFERENCES	PRODUCTS(ProductID),
	ProductQty		INTEGER	NOT NULL,
	PaymentMethod	Text	NOT NULL,
	PurchaseTime	Text	DEFAULT(datetime())
);




-- ===========================================================================




-- ADMINS

INSERT INTO ADMINS VALUES ('yash', 'admin', 'Yashaswini BS');
INSERT INTO ADMINS VALUES ('admin', 'admin', 'Administrator');
INSERT INTO ADMINS VALUES ('shakir', 'shakir035', 'Shakir Ali');


-- VENDING MACHINES

INSERT INTO VENDING_MACHINES VALUES('VMID0001', 'Cafeteria', 1);
INSERT INTO VENDING_MACHINES VALUES('VMID0002', 'Admin Block', 1);
INSERT INTO VENDING_MACHINES VALUES('VMID0003', 'Main Block', 0);
INSERT INTO VENDING_MACHINES VALUES('VMID0004', 'College Entrance', 1);
INSERT INTO VENDING_MACHINES VALUES('VMID0005', 'Chavra Square', 0);
INSERT INTO VENDING_MACHINES VALUES('VMID0006', 'Green Park', 1);


-- PRODUCTS

INSERT INTO PRODUCTS VALUES ("PROD0001", "Lays Classic", 10);
INSERT INTO PRODUCTS VALUES ("PROD0002", "Kit-Kat Chocolate", 20);
INSERT INTO PRODUCTS VALUES ("PROD0003", "Coke Zero (330 ml)", 45);
INSERT INTO PRODUCTS VALUES ("PROD0004", "Mirinda (330 ml)", 45);
INSERT INTO PRODUCTS VALUES ("PROD0005", "Fanta Family Pack (PC of 4)", 160);
INSERT INTO PRODUCTS VALUES ("PROD0006", "Pringles", 100);
INSERT INTO PRODUCTS VALUES ("PROD0007", "Toblerone", 150);
INSERT INTO PRODUCTS VALUES ("PROD0008", "Cheetos Flamin Hot", 20);
INSERT INTO PRODUCTS VALUES ("PROD0009", "Red Bull", 120);
INSERT INTO PRODUCTS VALUES ("PROD0010", "Snickers (45g)", 45);
INSERT INTO PRODUCTS VALUES ("PROD0011", "Nescafe Cold Coffee", 60);
INSERT INTO PRODUCTS VALUES ("PROD0012", "Starbucks Espresso", 180);
INSERT INTO PRODUCTS VALUES ("PROD0013", "Milk Carton (500 ml)", 30);





-- Vending Machine 1
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0001', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0002', 30);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0003', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0006', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0007', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0008', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0009', 14);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0012', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0001', 'PROD0013', 10);

-- Vending Machine 2 
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0002', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0005', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0003', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0004', 30);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0007', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0012', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0008', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0011', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0002', 'PROD0006', 10);

-- Vending Machine 3
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0007', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0005', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0010', 23);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0003', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0001', 20);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0011', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0006', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0012', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0003', 'PROD0009', 14);

-- Vending Machine 4
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0003', 11);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0013', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0008', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0012', 13);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0001', 24);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0011', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0006', 16);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0009', 18);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0004', 'PROD0007', 19);


-- Vending Machine 5
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0003', 22);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0013', 15);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0008', 13);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0012', 17);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0009', 17);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0007', 23);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0001', 24);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0010', 23);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0005', 'PROD0006', 14);

-- Vending Machine 6
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0012', 17);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0009', 14);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0007', 25);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0001', 23);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0002', 21);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0005', 14);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0003', 10);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0004', 12);
INSERT INTO PRODUCTS_AVAILABLE VALUES ('VMID0006', 'PROD0010', 22);






-- Retrieve ProductID, ProductName And Price From Database
SELECT PRODUCTS_AVAILABLE.ProductID, PRODUCTS.ProductName, PRODUCTS.ProductPrice FROM PRODUCTS_AVAILABLE INNER JOIN PRODUCTS ON PRODUCTS.ProductID = PRODUCTS_AVAILABLE.ProductID WHERE PRODUCTS_AVAILABLE.VMID = 'VMID0001';
SELECT PRODUCTS.ProductName, PRODUCTS.ProductPrice, PURCHASES.ProductQty, PURCHASES.PaymentMethod, PURCHASES.PurchaseTime FROM PRODUCTS INNER JOIN PURCHASES ON PRODUCTS.ProductID = PURCHASES.ProductID WHERE PURCHASES.VMID = 'VMID0001';


INSERT INTO PURCHASES (ProductID, ProductQty, PaymentMethod) VALUES ('PROD0001', 2, 'Credit Card');