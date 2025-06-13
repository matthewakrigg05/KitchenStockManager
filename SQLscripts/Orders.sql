CREATE TABLE Orders (
    orderId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    customerId INT NOT NULL,
    orderDate DATETIME NOT NULL,
    totalCost DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (customerId) REFERENCES Customers(customerId)
);

CREATE TABLE OrderItems (
    orderItemId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    orderId INT NOT NULL,
    inventoryItemId INT NOT NULL,
    quantity INT NOT NULL,
    FOREIGN KEY (orderId) REFERENCES Orders(orderId),
    FOREIGN KEY (inventoryItemId) REFERENCES InventoryItems(inventoryItemId)
);

CREATE TABLE PreparationList (
    prepListId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    prepListDate DATETIME NOT NULL
)

CREATE TABLE PreparationListItems (
    prepItemId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    ingredientId INT NOT NULL,
    itemType ENUM('Raw', 'Prepared') NOT NULL,
    FOREIGN KEY (ingredientId) REFERENCES (
        CASE
            WHEN itemType = 'Raw' THEN RawIngredients(rawIngredientId)
            WHEN itemType = 'Prepared' THEN PreparedIngredients(preparedIngredientId)
        END
    )
)