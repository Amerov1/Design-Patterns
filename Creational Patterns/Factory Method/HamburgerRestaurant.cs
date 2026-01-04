using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public class HamburgerRestaurant:FactoryRestaurant
{
    public Burger MakeBurger()
    {
        return new Hamburger();
    }
}

