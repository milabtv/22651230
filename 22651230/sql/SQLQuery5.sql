CREATE TABLE ProductType
(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	Name_ VARCHAR(30) NOT NULL
)
CREATE TABLE Products
(
	ID INT PRIMARY KEY NOT NULL,
	Name_ VARCHAR(30) NOT NULL,
	Quantity INT,
	ProdType INT FOREIGN KEY 
	REFERENCES ProductType(ID),
	PriceOne DECIMAL
)
CREATE TABLE Clients
(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	FirstName VARCHAR(35),
	LastName VARCHAR(35),
	PhoneNum VARCHAR(13),
	Adres VARCHAR(50)
)
CREATE TABLE Workers
(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	FirstName VARCHAR(35),
	LastName VARCHAR(35),
	PhoneNum VARCHAR(13)
)
CREATE TABLE Couriers
(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	Name_ VARCHAR(35),
	Price DECIMAL
)
CREATE TABLE Shipments
(
	ID INT PRIMARY KEY NOT NULL,
	Worker INT FOREIGN KEY
	REFERENCES Workers(ID),
	Client INT FOREIGN KEY
	REFERENCES Clients(ID),
	Courier INT FOREIGN KEY
	REFERENCES Couriers(ID),
	DateShipment DATETIME2

)
CREATE TABLE ShipmentPackage
(
	Shipment INT FOREIGN KEY
	REFERENCES Shipments(ID),
	Pruduct INT FOREIGN KEY
	REFERENCES Shipments(ID),
	Quantity INT
);
CREATE TRIGGER product_price
ON Products
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Products ( 
        Name_,Quantity,ProdType,PriceOne
    )
    SELECT
        i.Name_,i.Quantity,i.ProdType,i.PriceOne
    FROM
        inserted i
    WHERE
        i.PriceOne >0 AND i.ProdType IN(SELECT ID FROM ProductType)
END;
CREATE TRIGGER courier_price
ON Couriers
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Couriers( 
        Name_,Price
    )
    SELECT
        i.Name_,i.Price
    FROM
        inserted i
    WHERE
        i.Price >0 
END;
CREATE TRIGGER quantity
ON ShipmentPackage
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO ShipmentPackage( 
        Shipment,Pruduct,Quantity
    )
    SELECT
        i.Shipment,i.Pruduct,i.Quantity
    FROM
        inserted i
    WHERE
        i.Pruduct IN(SELECT ID FROM Products) AND
		 i.Shipment IN(SELECT ID FROM Shipments) AND
		 i.Quantity >= (SELECT Quantity FROM Products WHERE ID = i.Pruduct);
	
END;
CREATE TRIGGER quantity_update
ON ShipmentPackage
AFTER INSERT
AS
BEGIN
    UPDATE Products SET Quantity = Quantity - (
	SELECT i.Quantity FROM inserted i
	) 
	WHERE ID = (SELECT ID FROM inserted i)
	
END;

CREATE TRIGGER Shipment_data
ON Shipments
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Shipments( 
        Worker,Client,Courier
    )
    SELECT
        i.Worker,i.Client,i.Courier
    FROM
        inserted i
    WHERE
        i.Courier IN(SELECT ID FROM Couriers) AND
		 i.Client IN(SELECT ID FROM Clients) AND
		i.Worker IN(SELECT ID FROM Workers) 
	
END;