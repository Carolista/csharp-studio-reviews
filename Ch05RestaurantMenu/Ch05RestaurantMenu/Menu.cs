using System.Text;

namespace Ch05RestaurantMenu
{
    public class Menu
    {
        // FIELDS
        public List<MenuItem> MenuItems { get; set; } = []; // new ArrayList<>() or new()
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Default constructor is fine

        // OVERRIDE SPECIAL METHODS

        public override string ToString()
        {
            string nl = Environment.NewLine;
            StringBuilder appetizers = new(); // or new StringBuilder()
            foreach (MenuItem item in MenuItems)
            {
                if (Equals(item.Category, "Appetizer"))
                {
                    appetizers.Append(nl).Append(item).Append(nl);
                }
            }
            StringBuilder mainCourses = new();
            foreach (MenuItem item in MenuItems)
            {
                if (Equals(item.Category, "Main Course"))
                {
                    mainCourses.Append(nl).Append(item).Append(nl);
                }
            }
            StringBuilder desserts = new();
            foreach (MenuItem item in MenuItems)
            {
                if (Equals(item.Category, "Dessert"))
                {
                    desserts.Append(nl).Append(item).Append(nl);
                }
            }
            return nl
                + "TONY'S PIZZA ON THE HILL"
                + nl
                + nl
                + "APPETIZERS"
                + appetizers // implicit ToString()
                + nl
                + "MAIN COURSES"
                + mainCourses // implicit ToString()
                + nl
                + "DESSERTS"
                + desserts // implicit ToString()
                + nl
                + "Last updated "
                + LastUpdated.ToString("f")
                + nl; // full date and time
        }

        // INSTANCE METHODS
        public void AddItem(MenuItem newItem)
        {
            if (MenuItems.Contains(newItem)) // .Contains() will use custom Equals of newItem
            {
                Console.WriteLine("ERROR: That item has already been added to the menu.");
            }
            else
            {
                MenuItems.Add(newItem);
                LastUpdated = DateTime.Now;
                newItem.DateAdded = DateTime.Now;
            }
        }

        public void RemoveItem(MenuItem item)
        {
            MenuItems.Remove(item);
            LastUpdated = DateTime.Now;
        }
    }
}
