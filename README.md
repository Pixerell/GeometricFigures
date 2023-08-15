# GeometricFigures
Полное решение площадей и прочих данных для геометрических фигур с юнит-тестами.

1 - Запускается программа и интерфейс этой программы находятся в файле Program.cs папки GeometryLibrary

2 - Сама логика программы выполнена в виде отдельного модуля в файле GeometryCalculator.cs папки GeometryLibrary

3 - Unit тесты находятся в файле UnitTest1.cs папки GeometryCalcTests

# В случае если pastebin потёрли для SQL 

1 - Ссылка https://pastebin.com/cwJRRNwd

2 - Если и там нет то весь запрос здесь:

-- Логика SQL запроса

SELECT p.ProductName, COALESCE(c.CategoryName, 'No Category') AS CategoryName

FROM products p

LEFT JOIN productcategories pc ON p.ProductID = pc.ProductID

LEFT JOIN categories c ON pc.CategoryID = c.CategoryID;


-- Создание моковых таблиц для проверки

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(50)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100)
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Categories (CategoryID, CategoryName)
VALUES
    (1, 'Electronics'),
    (2, 'Clothing'),
    (3, 'Furniture');

INSERT INTO Products (ProductID, ProductName)
VALUES
    (101, 'Laptop'),
    (102, 'T-Shirt'),
    (103, 'Sofa');

INSERT INTO ProductCategories (ProductID, CategoryID)
VALUES
    (101, 1), 
    (102, 2), 
    (103, 3); 
