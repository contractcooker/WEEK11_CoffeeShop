using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MenuItems
    {
        private static string[] coffeeBlends = {"Sumatra Purba Tua Red Supreme Badger", "Brazil Serra Perola Negra", "Ethiopia Yirgacheffe Natural: Wogida Mekuri Bensa", "Winter Wake Up Blend", "Peru Cajamarca Limcof Association FTO",
                "St. Amour Blend", "ABC Blend", "Blooming Blend", "Guatemala Antigua Finca Santa Catalina", "Columbia Sugar Cane Decaf" };
        

        public static string[] CoffeeBlends { get => coffeeBlends; }
        
    }
}
