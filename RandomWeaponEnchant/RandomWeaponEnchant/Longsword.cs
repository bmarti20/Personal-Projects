using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWeaponEnchant
{
    class Longsword : Weapon
    {
        public Longsword()
        {
            name = "Longsword";
            min = 6;
            max = 8;
            speed = "Slow";
            name = GenerateEnchantment(name);
        }
    }
}
