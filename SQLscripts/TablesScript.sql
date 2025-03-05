CREATE TABLE Users (
    userId INT NOT NULL AUTO_INCREMENT,
    email VARCHAR(250) NOT NULL,
    pass VARCHAR(250) NOT NULL,
    firstName VARCHAR(45) NOT NULL,
    lastName VARCHAR(45) NOT NULL,
    PRIMARY KEY (userId)
);

CREATE TABLE Suppliers (
    supplierId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    firstName VARCHAR(100) NOT NULL,
    contactNumber VARCHAR(50),
    email VARCHAR(250)
);

CREATE TABLE Restaurants (
    restaurantId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    address VARCHAR(500),
    phoneNumber VARCHAR(50),
    email VARCHAR(250)
);

CREATE TABLE Inventory (
    inventoryId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    restaurantId INT NOT NULL,
    FOREIGN KEY (restaurantId) REFERENCES Restaurants(restaurantId)
);

CREATE TABLE RawIngredients (
    rawIngredientId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    quantity INT NOT NULL,
    unit VARCHAR(50) NOT NULL,
    cost DECIMAL(10,2),
    supplierId INT,
    foodGroup VARCHAR(100),
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);

CREATE TABLE PreparedIngredients (
    preparedIngredientId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    quantity INT NOT NULL,
    unit VARCHAR(50) NOT NULL,
    cost DECIMAL(10,2),
    supplierId INT,
    inventoryId INT NOT NULL,
    preparationInstructions TEXT,
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId),
    FOREIGN KEY (inventoryId) REFERENCES Inventory(inventoryId)
);

CREATE TABLE Items (
    itemId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    quantity INT NOT NULL,
    unit VARCHAR(50) NOT NULL,
    cost DECIMAL(10,2),
    supplierId INT,
    FOREIGN KEY (supplierId) REFERENCES Suppliers(supplierId)
);
