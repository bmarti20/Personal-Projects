using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWeaponEnchant
{
    class Sword : Weapon
    {
        public Sword()
        {
            name = "Sword";
            min = 4;
            max = 6;
            speed = "Average";
            name = GenerateEnchantment(name);
        }
    }
}
