CREATE TABLE RawIngredients (
    rawIngredientId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    quantity INT NOT NULL,
    unit VARCHAR(50) NOT NULL,
    cost FLOAT,
    supplierId INT,
    foodGroup VARCHAR(100),
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);
