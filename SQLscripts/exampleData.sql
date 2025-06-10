-- Insert Users
INSERT INTO Users (email, pass, firstName, lastName) VALUES
('john.doe@example.com', 'password123', 'John', 'Doe'),
('jane.smith@example.com', 'securePass!', 'Jane', 'Smith'),
('alice.johnson@example.com', 'alicePass123', 'Alice', 'Johnson'),
('bob.brown@example.com', 'bobSecure!', 'Bob', 'Brown'),
('charlie.white@example.com', 'charliePass!', 'Charlie', 'White'),
('david.green@example.com', 'davidSecure123', 'David', 'Green'),
('emily.adams@example.com', 'emilyPassword', 'Emily', 'Adams'),
('frank.harris@example.com', 'frankPass!', 'Frank', 'Harris'),
('george.thomas@example.com', 'george1234', 'George', 'Thomas'),
('hannah.wilson@example.com', 'hannahSafe!', 'Hannah', 'Wilson');

-- Insert Suppliers
INSERT INTO Suppliers (firstName, contactNumber, email) VALUES
('Fresh Farms', '123-456-7890', 'contact@freshfarms.com'),
('Organic Foods', '987-654-3210', 'support@organicfoods.com'),
('Dairy Best', '456-789-0123', 'info@dairybest.com'),
('Seafood Delights', '321-654-9870', 'sales@seafooddelights.com'),
('Grain Harvesters', '654-987-3210', 'info@grainharvesters.com'),
('Meat Masters', '789-123-4560', 'contact@meatmasters.com'),
('Farm Fresh Eggs', '147-258-3690', 'support@farmfresheggs.com'),
('Golden Honey', '369-147-2580', 'sales@goldenhoney.com'),
('Green Vegetables Co.', '852-963-7410', 'info@greenveggies.com'),
('Deli Suppliers', '741-852-9630', 'contact@delisuppliers.com');

-- Insert Restaurants
INSERT INTO Restaurants (name, address, phoneNumber, email) VALUES
('The Gourmet Spot', '123 Food Lane, New York, NY', '111-222-3333', 'info@gourmetspot.com'),
('Tasty Treats', '456 Main St, Los Angeles, CA', '444-555-6666', 'hello@tastytreats.com'),
('Savory Bites', '789 Culinary Ave, Chicago, IL', '777-888-9999', 'contact@savorybites.com'),
('Urban Eats', '159 Dining Blvd, Miami, FL', '999-888-7777', 'info@urbaneats.com'),
('Classic Diner', '753 Bistro St, San Francisco, CA', '555-444-3333', 'support@classicdiner.com'),
('Chef’s Table', '852 Gourmet Rd, Seattle, WA', '666-777-8888', 'chefs@table.com'),
('Fine Dining Hub', '357 Tasting Ln, Boston, MA', '321-654-9876', 'fine@dininghub.com'),
('Quick Bites', '147 Express St, Houston, TX', '258-369-1470', 'order@quickbites.com'),
('Family Feast', '951 Home Cook Ln, Dallas, TX', '753-951-4560', 'family@feast.com'),
('Bistro Delight', '357 Cafe Blvd, Denver, CO', '852-147-9630', 'bistro@delight.com');

-- Insert Inventory
INSERT INTO Inventory (restaurantId) VALUES
(1),(2),(3),(4),(5),(6),(7),(8),(9),(10);

-- Insert Raw Ingredients
INSERT INTO RawIngredients (name, quantity, unit, cost, supplierId, foodGroup) VALUES
('Tomatoes', 100, 'kg', 50.00, 1, 'Vegetables'),
('Milk', 200, 'liters', 120.00, 3, 'Dairy'),
('Chicken', 50, 'kg', 300.00, 2, 'Meat'),
('Salmon', 30, 'kg', 450.00, 4, 'Seafood'),
('Wheat Flour', 500, 'kg', 250.00, 5, 'Grains'),
('Beef', 80, 'kg', 600.00, 6, 'Meat'),
('Eggs', 300, 'pieces', 90.00, 7, 'Dairy'),
('Honey', 100, 'liters', 200.00, 8, 'Sweeteners'),
('Lettuce', 120, 'kg', 70.00, 9, 'Vegetables'),
('Cheese', 150, 'kg', 500.00, 10, 'Dairy');

-- Insert Prepared Ingredients
INSERT INTO PreparedIngredients (name, quantity, unit, cost, supplierId, inventoryId, preparationInstructions) VALUES
('Tomato Sauce', 30, 'liters', 90.00, 1, 1, 'Blend tomatoes and season with herbs.'),
('Grilled Chicken', 20, 'kg', 250.00, 2, 2, 'Marinate and grill to perfection.'),
('Smoked Salmon', 15, 'kg', 500.00, 4, 3, 'Smoke the salmon with oak wood.'),
('Bread Dough', 100, 'kg', 180.00, 5, 4, 'Mix flour, yeast, and water.'),
('Beef Stew', 25, 'kg', 350.00, 6, 5, 'Slow cook beef with vegetables.'),
('Scrambled Eggs', 50, 'kg', 100.00, 7, 6, 'Beat eggs and cook over low heat.'),
('Honey Glaze', 20, 'liters', 220.00, 8, 7, 'Mix honey with vinegar and spices.'),
('Salad Mix', 80, 'kg', 140.00, 9, 8, 'Chop fresh vegetables and mix.'),
('Cheese Sauce', 35, 'liters', 400.00, 10, 9, 'Melt cheese with cream and spices.'),
('Garlic Butter', 40, 'kg', 300.00, 3, 10, 'Blend butter with garlic and herbs.');

-- Insert Items
INSERT INTO Items (name, quantity, unit, cost, supplierId) VALUES
('Cheese Blocks', 40, 'kg', 200.00, 3),
('Bread Loaves', 100, 'pieces', 150.00, 1),
('Pasta', 200, 'kg', 220.00, 5),
('Yogurt Cups', 300, 'pieces', 180.00, 3),
('Frozen Fish Fillets', 60, 'kg', 480.00, 4),
('Rice', 500, 'kg', 450.00, 5),
('Ground Beef', 80, 'kg', 560.00, 6),
('Fresh Berries', 120, 'kg', 320.00, 9),
('Olive Oil', 90, 'liters', 600.00, 10),
('Chocolate Bars', 150, 'pieces', 350.00, 8);
