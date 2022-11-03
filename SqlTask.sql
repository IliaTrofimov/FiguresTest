CREATE TABLE Product (
    Id INT NOT NULL,
    ProductName TEXT NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY(Id)
);

CREATE TABLE Category (
    Id INT NOT NULL,
    CategoryName TEXT NOT NULL,
    CONSTRAINT PK_Category PRIMARY KEY(Id)
);

CREATE TABLE CategoryProduct (
    CategoryId INT NOT NULL,
    ProductId INT NOT NULL,
    CONSTRAINT PK_CategoryProduct PRIMARY KEY(CategoryId, ProductId),
    CONSTRAINT FK_CategoryProduct_to_Product FOREIGN KEY(ProductId) REFERENCES Product(Id) 
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_CategoryProduct_to_Category FOREIGN KEY(CategoryId) REFERENCES Category(Id) 
        ON DELETE CASCADE ON UPDATE CASCADE
);


INSERT INTO Category (Id, CategoryName) VALUES 
    (0, "Электроника"),
    (1, "ПК"),
    (2, "Ноутбуки"),
    (3, "Мобильные телефоны"),
    (4, "Автозапчасти"),
    (5, "б/у");

INSERT INTO Product VALUES 
    (0, "Телевизор 1"), 
    (1, "СВЧ-печь 1"),
    (2, "Ноутбук 1"), 
    (3, "Ноутбук 2"),
    (4, "Компьютер 1"), 
    (5, "Моноблок 1"),
    (7, "Смартфон 1"), 
    (8, "Кнопочный телефон 1"),
    (9, "Ветровое стекло"),
    (10, "Строительная рулетка");

INSERT INTO CategoryProduct (CategoryId, ProductId) VALUES 
    (0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (0, 5), (0, 7), (0, 8), -- электроника
    (1, 4), (1, 5),                                                 -- пк
    (2, 2), (2, 3),                                                 -- ноутбуки
    (3, 7), (3, 8),                                                 -- телефоны
    (4, 9),                                                         -- запчасти
    (5, 1), (5, 3), (5, 5);                                         -- б/у

SELECT 
    ProductName AS "Продукт", CategoryName AS "Категория"
FROM Product
FULL OUTER JOIN CategoryProduct ON CategoryProduct.ProductId = Product.Id
FULL OUTER JOIN Category ON CategoryProduct.CategoryId = Category.Id
ORDER BY Product.Id;
