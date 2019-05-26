using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RandomChanceSuite
{
    public class Card
    {
        public Image card;
        public string name;

        public Card(Image card, string name)
        {
            this.card = card;
            this.name = name;
        }
    }
}
