using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._23_dz
{
    internal class Money
    {
        public int currency { get; set; }
        public int coins
        {
            get
            {
                return currency;
            }
            set
            {
                if (coins>=100) 
                {
                    coins-=100;
                    currency++;
                }
            }
        }
        public Money(int currency, int coins)
        {
            this.currency = currency;
            this.coins = coins;
        }
        public Money() { }
        public void Sum()
        {
            Console.WriteLine($"Sum is: {coins + currency}");
        }
    }
    class Product : Money 
    {
        public void DecreasePrice(int currency, int coins)
        {
            if(currency < 0||coins<0 ) { throw new Exception("invalid value"); }
            this.currency -= currency;
            this.coins -= coins;
        }
    }
}

