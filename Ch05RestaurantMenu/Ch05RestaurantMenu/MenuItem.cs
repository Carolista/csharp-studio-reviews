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
        public override string ToString()
        {
            string newText = IsNew() ? " - NEW!" : "";
            return Name + newText + Environment.NewLine + Description + " | $" + Price;
        }

        public override bool Equals(object? toBeCompared)
        {
            // Reference check
            if (this == toBeCompared)
            {
                return true;
            }

            // Null check
            if (toBeCompared == null)
            {
                return false;
            }

            // Class check
            if (GetType() != toBeCompared.GetType())
            {
                return false;
            }

            // Cast to class
            MenuItem otherItem = (MenuItem)toBeCompared;

            // Compare
            return Name == otherItem.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }

        // INSTANCE METHODS

        public bool IsNew()
        {
            TimeSpan age = DateTime.Now.Subtract(DateAdded);
            int daysOld = age.Days;
            return daysOld < 120;
        }
    }
}
