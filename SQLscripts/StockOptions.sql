CREATE TABLE Suppliers (
    supplierId INT NOT NULL PRIMARY KEY,
    firstName VARCHAR(100) NOT NULL,
    contactNumber VARCHAR(50),
    email VARCHAR(250)
);

CREATE TABLE RawIngredients (
    rawIngredientId INT NOT NULL PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    costPerUnit DECIMAL(10,2) NOT NULL,
    supplierId INT,
    foodGroup VARCHAR(100),
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);

CREATE TABLE PreparedIngredients (
    preparedIngredientId INT NOT NULL PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    costPerUnit DECIMAL(10,2) NOT NULL,
    supplierId INT,
    preparationInstructions TEXT,
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);

CREATE TABLE Items (
    itemId INT NOT NULL PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    costPerUnit DECIMAL(10,2) NOT NULL,
    supplierId INT,
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);
