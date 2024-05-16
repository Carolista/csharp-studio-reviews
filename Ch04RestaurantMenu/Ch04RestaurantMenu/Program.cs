using Ch04RestaurantMenu;

// Planning for this application:
// https://docs.google.com/spreadsheets/d/1pNsU61LXCcauCPyk9rZFznN4m7CBWASiPwthLRb52Zc/edit#gid=0

// Good reference for the DateTime class in C#:
// https://www.c-sharpcorner.com/article/datetime-in-c-sharp/

// Test creating objects of MenuItem class
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

// Print values of properties from each item
Console.WriteLine(item1.Name);
Console.WriteLine(item2.Description);
Console.WriteLine(item3.Price);
Console.WriteLine(item1.Category);

// Test creating object of Menu class
Menu menu = new(); // default constructor, short form

// Print count of list of menu items in the menu
Console.WriteLine(menu.MenuItems.Count);
