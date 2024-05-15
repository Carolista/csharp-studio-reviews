namespace Ch04RestaurantMenu
{
    public class Menu
    {
        // FIELDS
        public List<MenuItem> MenuItems { get; set; } = []; // new ArrayList<>() or new()
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Default constructor is fine
    }
}
