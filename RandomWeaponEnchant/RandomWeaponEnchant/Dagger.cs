using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWeaponEnchant
{
    class Dagger : Weapon
    {
        public Dagger()
        {
            name = "Dagger";
            min = 2;
            max = 3;
            speed = "Fast";
            name = GenerateEnchantment(name);
        }
    }
}
