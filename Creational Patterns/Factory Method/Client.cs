
// Client
class Program
{
    public static void Main()
    {
        FactoryRestaurant restaurant;

        restaurant = new HamburgerRestaurant();
        Burger burger1 = restaurant.MakeBurger();
        Console.WriteLine($"Hamburger price: {burger1.Price}");

        restaurant = new CheeseburgerRestaurant();
        Burger burger2 = restaurant.MakeBurger();
        Console.WriteLine($"Cheeseburger price: {burger2.Price}");
    }
}
