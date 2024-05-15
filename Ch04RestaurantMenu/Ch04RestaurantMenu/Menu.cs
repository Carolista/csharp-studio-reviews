namespace Ch04RestaurantMenu
{
    public class Menu
    {
        // FIELDS
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>(); // or new() or []
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Default constructor is fine
    }
}
