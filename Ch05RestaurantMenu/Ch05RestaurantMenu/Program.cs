using Ch05RestaurantMenu;

// Planning for this application:
// https://docs.google.com/spreadsheets/d/1pNsU61LXCcauCPyk9rZFznN4m7CBWASiPwthLRb52Zc/edit#gid=1808696522

// Good reference for the DateTime class in C#:
// https://www.c-sharpcorner.com/article/datetime-in-c-sharp/

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

// Add items to menu
menu.AddItem(item1);
menu.AddItem(item2);
menu.AddItem(item3);
menu.AddItem(item4);
menu.AddItem(item5);

// Print size of menu's item list to verify
Console.WriteLine(menu.MenuItems.Count);

// Test IsNew() on one of the items
Console.WriteLine(item3.IsNew());

// Print a menu item once its ToString() has been overridden
Console.WriteLine(item2);

// Print the entire menu once its ToString() has been overridden
Console.WriteLine(menu);

// Remove an item and print the menu again
menu.RemoveItem(item4);
Console.WriteLine(menu);

// BONUS MISSION
// Attempt to add a duplicate item, then print menu to verify
MenuItem item6 = new MenuItem("Garlic Breadsticks", "Hot, garlicky carbs FTW", 4.59, "Appetizer");
menu.AddItem(item6);
Console.WriteLine(menu);
