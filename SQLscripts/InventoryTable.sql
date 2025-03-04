CREATE TABLE Inventory (
    inventoryId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    itemId INT,
    preparedIngredientId INT,
    rawIngredientId INT,
    FOREIGN KEY (itemId) REFERENCES Items(itemId),
    FOREIGN KEY (preparedIngredientId) REFERENCES PreparedIngredients(preparedIngredientId),
    FOREIGN KEY (rawIngredientId) REFERENCES RawIngredients(rawIngredientId)
);
