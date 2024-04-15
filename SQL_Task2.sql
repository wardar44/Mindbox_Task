CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY, 
ProductName VARCHAR(255) NOT NULL);

CREATE TABLE Categories(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(255) NOT NULL);

CREATE TABLE ProductsCategories(
ProductId INT NOT NULL,
CategoryId INT NOT NULL,
PRIMARY KEY (ProductId,CategoryId),
FOREIGN KEY(ProductId) REFERENCES Products(Id) ON DELETE CASCADE,
FOREIGN KEY(CategoryId) REFERENCES Categories(Id) ON DELETE CASCADE);



INSERT INTO Products VALUES('Яблоки'), ('Груши'), ('Апельсины'), ('Вишня'), ('Голубика'), ('Морковь'), ('Свекла'), ('Арбуз');
INSERT INTO Categories VALUES('Фрукты'), ('Ягоды'), ('Овощи');
INSERT INTO ProductsCategories VALUES(1, 1), (2, 1), (3, 1), (4, 2), (5, 2), (6, 3), (7, 3);


SELECT p.ProductName, ISNULL(c.CategoryName, 'Без категории') AS CategoryName
FROM Products AS p
LEFT JOIN ProductsCategories AS pc ON p.Id= pc.ProductId
LEFT JOIN Categories AS c ON pc.CategoryId = c.Id;