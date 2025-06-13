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