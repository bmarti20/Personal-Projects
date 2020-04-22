using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RandomChanceSuite
{
    public class Die
    {
        public Image face;
        public int value;
        public bool held;

        public Die(int value, bool held)
        {
            this.value = value;
            this.held = held;
        }
    }
}
