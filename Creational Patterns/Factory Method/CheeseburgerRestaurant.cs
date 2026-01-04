class CheeseburgerRestaurant : FactoryRestaurant
{
    public Burger MakeBurger()
    {
        return new Cheeseburger();
    }
}
