using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberTheorySuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckPrimeButton_Click(object sender, EventArgs e)
        {
            long input = 0;
            try
            {
                input = Convert.ToInt32(PrimeTextbox.Text);
                int sqrt = Convert.ToInt32(Math.Sqrt(input));
                bool prime = true;
                List<long> factors = new List<long>();

                for (int i = 2; i <= sqrt; i++)
                {
                    if ((input % i) == 0)
                    {
                        factors.Add(i);
                        if (input / i != i)
                            factors.Add(input / i);
                        prime = false;
                    }
                }

                if (prime)
                    PrimeResult.Text = input + " is prime.";
                else
                {
                    factors.Add(1);
                    factors.Add(input);
                    factors.Sort();
                    PrimeResult.Text = input + " is not prime. Factors: \n";
                    for (int i = 0; i < factors.Count; i++)
                    {
                        PrimeResult.Text += factors[i] + " ";
                        if (i % 8 == 0 && i != 0)
                            PrimeResult.Text += "\n";
                    }
                    //foreach(int n in factors)
                    //{
                    //    PrimeResult.Text += n + " ";
                    //}
                }

            }
            catch
            {   PrimeResult.Text = "Error, invalid input."; }
            
        }

        private void abmodnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                long a = Convert.ToInt32(aTextbox.Text);
                long b = Convert.ToInt32(bTextbox.Text);
                long n = Convert.ToInt32(nTextbox.Text);
                long output = Convert.ToInt64(Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)) % n);
                abmodnResult.Text = a + "^" + b + " mod" + n + " =\n" + output + " mod" + n;
            }
            catch { abmodnResult.Text = "Error, invalid input."; }
        }
    }
}
