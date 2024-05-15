namespace Ch04RestaurantMenu
{
    public class Menu
    {
        // FIELDS
        public List<MenuItem> MenuItems { get; set; } = []; // new ArrayList<>() or new()
        public DateTime LastUpdated { get; set; }

        // Default constructor is fine
    }
}