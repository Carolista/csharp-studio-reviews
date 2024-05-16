namespace Ch05RestaurantMenu
{
    public class MenuItem
    {
        // FIELDS
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }

        // CONSTRUCTOR
        public MenuItem(string name, string description, double price, string category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }


        // OVERRIDE SPECIAL METHODS

        // TODO: Override ToString()

        // TODO: Override Equals() & GetHashCode()


        // INSTANCE METHODS

        // TODO: Define IsNew()
        
    }
}
