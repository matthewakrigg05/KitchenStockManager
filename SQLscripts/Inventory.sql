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