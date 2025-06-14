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

CREATE TABLE Orders (
    orderId INT NOT NULL PRIMARY KEY,
    customerId INT NOT NULL,
    orderDate DATETIME NOT NULL,
    totalCost DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (customerId) REFERENCES Customers(customerId)
);

CREATE TABLE OrderItems (
    orderItemId INT NOT NULL PRIMARY KEY,
    orderId INT NOT NULL,
    inventoryItemId INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (orderId) REFERENCES Orders(orderId),
    FOREIGN KEY (inventoryItemId) REFERENCES InventoryItems(inventoryItemId)
);

CREATE TABLE PreparationList (
    prepListId INT NOT NULL PRIMARY KEY,
    prepListDate DATETIME NOT NULL
);

CREATE TABLE PreparationListRawItems (
	prepItemId INT NOT NULL PRIMARY KEY,
	rawIngredientId INT NOT NULL,
	FOREIGN KEY (rawIngredientId) REFERENCES RawIngredients(rawIngredientId)
);

CREATE TABLE PreparationListPreparedItems (
	prepItemId INT NOT NULL PRIMARY KEY,
	preparedIngredientId INT NOT NULL,
	FOREIGN KEY (preparedIngredientId) REFERENCES PreparedIngredients(preparedIngredientId)
);

CREATE TABLE Recipes (
    recipeId INT NOT NULL PRIMARY KEY,
    name VARCHAR(250) NOT NULL,
    description TEXT,
    preparationInstructions TEXT,
    cost DECIMAL(10,2) NOT NULL
);

CREATE TABLE RecipeIngredients (
    recipeIngredientId INT NOT NULL PRIMARY KEY,
    recipeId INT NOT NULL,
    inventoryItemId INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (recipeId) REFERENCES Recipes(recipeId),
    FOREIGN KEY (inventoryItemId) REFERENCES InventoryItems(inventoryItemId)
);

CREATE TABLE Dish (
    dishId INT NOT NULL PRIMARY KEY,
    dishName VARCHAR(150) NOT NULL,
    dishDescription TEXT,
    dishCost DECIMAL(10,2) NOT NULL
);

CREATE TABLE Menu (
    menuId INT NOT NULL PRIMARY KEY,
    menuName VARCHAR(150) NOT NULL
);

CREATE TABLE MenuItems (
    dishId INT NOT NULL,
    menuId INT NOT NULL,
    FOREIGN KEY (dishId) REFERENCES Dish(dishId),
    FOREIGN KEY (menuId) REFERENCES Menu(menuId),
    PRIMARY KEY (dishId, menuId)
);

CREATE TABLE InventoryItems (
    inventoryItemId INT NOT NULL PRIMARY KEY,
    itemId INT NOT NULL,
	type VARCHAR(10) NOT NULL,
    quantity INT NOT NULL,
    unitOfMeasure VARCHAR(50) NOT NULL,
	FOREIGN KEY (itemId) REFERENCES Items(itemId)
);

CREATE TABLE InventoryPreparedIngredients (
    inventoryPreparedIngredientId INT NOT NULL PRIMARY KEY,
    preparedIngredientId INT NOT NULL,
	type VARCHAR(10) NOT NULL,
    quantity INT NOT NULL,
    unitOfMeasure VARCHAR(50) NOT NULL,
	FOREIGN KEY (preparedIngredientId) REFERENCES PreparedIngredients(preparedIngredientId)
);

CREATE TABLE InventoryRawIngredients (
    inventoryRawIngredientId INT NOT NULL PRIMARY KEY,
    rawIngredientId INT NOT NULL,
	type VARCHAR(10) NOT NULL,
    quantity INT NOT NULL,
    unitOfMeasure VARCHAR(50) NOT NULL,
	FOREIGN KEY (rawIngredientId) REFERENCES RawIngredients(rawIngredientId)
);