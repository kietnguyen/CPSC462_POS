CREATE TABLE ProdSpec (
	specId serial,
	name varchar(255) NOT NULL,
	manufacture varchar(255) DEFAULT '',
	description varchar(255) DEFAULT ''
);

CREATE TABLE Item (
	itemId bigint unsigned NOT NULL,
	specId bigint unsigned NOT NULL,
	price decimal(10,2) NOT NULL,
	
	PRIMARY KEY (itemId),
	FOREIGN KEY (specId)
		REFERENCES ProdSpec(specId)
);

CREATE TABLE SalesLineItem (
	saleId serial,
	qty int unsigned NOT NULL,
	itemId bigint unsigned NOT NULL,
	
	FOREIGN KEY (itemId)
		REFERENCES Item(itemId)
);

CREATE TABLE Store (
	storeId serial,
	name varchar(80) NOT NULL,
	address varchar(255) DEFAULT ''
);

CREATE TABLE Register (
	registerId serial
);

CREATE TABLE Cashier (
	employeeId serial,
	name varchar(255) NOT NULL
);

CREATE TABLE Receipt (
	receiptId serial,
	saleDate DateTime NOT NULL,
	storeId bigint unsigned NOT NULL,
	registerId bigint unsigned NOT NULL,
	employeeId bigint unsigned NOT NULL,
	
	FOREIGN KEY (storeId)
		REFERENCES Store(storeId), 
	FOREIGN KEY (registerId)
		REFERENCES Register(registerId), 
	FOREIGN KEY (employeeId)
		REFERENCES Cashier(employeeId) 
);

CREATE TABLE LineItemReceipt (
	lirId serial,
	saleId bigint unsigned NOT NULL,
	receiptId bigint unsigned NOT NULL,
	
	FOREIGN KEY (saleId)
		REFERENCES SalesLineItem(saleId),
	FOREIGN KEY (receiptId)
		REFERENCES Receipt(receiptId)
);

CREATE TABLE PaymentType (
	paymentTypeId serial,
	name varchar(80) NOT NULL
);

CREATE	TABLE Payment (
	paymentId serial,
	paymentTypeId bigint unsigned NOT NULL,
	amount decimal(10,2) NOT NULL,
	
	FOREIGN KEY (paymentTypeId)
		REFERENCES PaymentType(paymentTypeId)
);

CREATE TABLE PaymentReceipt (
	prId serial,
	receiptId bigint unsigned NOT NULL,
	paymentId bigint unsigned NOT NULL,
	
	FOREIGN KEY (receiptId)
		REFERENCES Receipt(receiptId),
	FOREIGN KEY (paymentId)
		REFERENCES Payment(PaymentId)
);

INSERT INTO PaymentType
		(paymentTypeId, name)
VALUES (1, 'Cash'),
				(2, 'Check'),
				(3, 'Credit Card');

INSERT INTO Store 
		(storeId, name, address)
VALUES (1, 'StoreABC', '123 ABC, ABC, CA 12345');

INSERT INTO Cashier
		(employeeId, name)
VALUES (1, 'CashierA');

INSERT INTO Register
		(registerId)
VALUES (1);

INSERT INTO ProdSpec
		(specId, name, manufacture)
VALUES	(1, 'Socks', 'Hanes'),
				(2, 'Gum', 'Stride'),
				(3, 'Mustard', 'French'),
				(4, 'Ice', 'Crystal'),
				(5, 'Misc', '');
				
INSERT INTO Item
		(itemId, specid, price)
VALUES (1, 1, 11.8),
				(2, 2, 3.5),
				(3, 3, 1.99),
				(4, 4, 1.99),
				(5, 5, 1);
				
				
