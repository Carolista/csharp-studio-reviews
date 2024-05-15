using Ch04RestaurantMenu;

// Test creating objects of MenuItem class
MenuItem item1 = new MenuItem("Pepperoni Pizza", "The classic slice, hot and delicious!", 7.39, "Main Course");
MenuItem item2 = new MenuItem("Toasted Ravioli", "A St. Louis favorite, served with a side of pizza sauce", 6.89, "Appetizer");
MenuItem item3 = new MenuItem("Gooey Butter Cake", "The ooiest, gooiest dessert this side of the Mississippi", 4.99, "Dessert");

// Print values of properties from each item
Console.WriteLine(item1.Name);
Console.WriteLine(item2.Description);
Console.WriteLine(item3.Price);
Console.WriteLine(item1.Category);

// Test creating object of Menu class
Menu menu = new(); // default constructor, short form

// Print count of list of menu items in the menu
Console.WriteLine(menu.MenuItems.Count);
