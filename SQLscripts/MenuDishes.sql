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