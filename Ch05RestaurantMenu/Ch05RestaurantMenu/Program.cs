using Ch05RestaurantMenu;

// Objects of MenuItem class
MenuItem item1 =
    new("Pepperoni Pizza", "The classic pie, hot and delicious!", 15.99, "Main Course");
MenuItem item2 =
    new(
        "Toasted Ravioli",
        "A St. Louis favorite, served with a side of pizza sauce",
        7.99,
        "Appetizer"
    );
MenuItem item3 =
    new(
        "Gooey Butter Cake",
        "The ooiest, gooiest dessert this side of the Mississippi",
        5.99,
        "Dessert"
    );
MenuItem item4 =
    new(
        "Veggie Pizza",
        "Peppers, onions, mushrooms, olives, and tomatoes make a delicious combo",
        17.99,
        "Main Course"
    );
MenuItem item5 = new("Garlic Breadsticks", "Hot, garlicky carbs FTW", 4.99, "Appetizer");

// Object of Menu class
Menu menu = new(); // default constructor, short form

// TODO: Add items to menu

// TODO: Print size of menu's item list to verify

// TODO: Test IsNew() on one of the items

// TODO: Print a menu item once its ToString() has been overridden

// TODO: Print the entire menu once its ToString() has been overridden

// TODO: Remove an item and print the menu again

// BONUS MISSION
// TODO: Attempt to add a duplicate item, then print menu to verify
MenuItem item6 = new MenuItem("Garlic Breadsticks", "Hot, garlicky carbs FTW", 4.59, "Appetizer");
