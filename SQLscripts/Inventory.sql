CREATE TABLE InventoryItems (
    inventoryItemId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    itemType ENUM('Raw', 'Prepared', 'Item') NOT NULL,
    itemId INT NOT NULL,
    quantity INT NOT NULL,
    unitOfMeasure VARCHAR(50) NOT NULL,
    costPerUnit DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (itemId) REFERENCES (
        CASE
            WHEN itemType = 'Raw' THEN RawIngredients(rawIngredientId)
            WHEN itemType = 'Prepared' THEN PreparedIngredients(preparedIngredientId)
            WHEN itemType = 'Item' THEN Items(itemId)
        END
    )
);