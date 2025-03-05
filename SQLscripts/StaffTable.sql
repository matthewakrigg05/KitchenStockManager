CREATE TABLE Staff (
    staffId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    firstName VARCHAR(100) NOT NULL,
    lastName VARCHAR(100) NOT NULL,
    email VARCHAR(250) NOT NULL,
    contactNumber VARCHAR(50),
    position VARCHAR(100),
    userId INT,
    restaurantId INT,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (restaurantId) REFERENCES Restaurants(restaurantId)
);