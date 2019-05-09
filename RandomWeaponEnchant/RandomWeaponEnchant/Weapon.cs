using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWeaponEnchant
{
    public abstract class Weapon
    {
        public string name = "", enchantment = "";
        public int min = 0, max = 0;
        public string speed = "";

        public string GenerateEnchantment(string name)
        {
            Random rand = new Random();
            switch (rand.Next(0, 7))
            {
                case 0:
                    enchantment = "Broken ";
                    min -= 2;
                    max -= 2;
                    break;
                case 1:
                    enchantment = "Poor ";
                    max -= 1;
                    speed = "Slow ";
                    break;
                case 2:     // No enchantment
                    break;
                case 3:
                    enchantment = "Light ";
                    max -= 1;
                    speed = "Fast ";
                    break;
                case 4:
                    enchantment = "Adept ";
                    min += 1;
                    max += 1;
                    break;
                case 5:
                    enchantment = "Strong ";
                    min += 2;
                    max += 2;
                    break;
                case 6:
                    enchantment = "Legendary ";
                    min += 2;
                    max += 2;
                    speed = "Fast";
                    break;
                default: break;
            }
            return enchantment + name;
        }
    }
}
