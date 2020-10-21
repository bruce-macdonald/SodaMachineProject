using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        public List<Coin> coins;
        public Card card;

        public Wallet()
        {
            coins = new List<Coin>();
            for (int i = 0; i < 15; i++)
            {
                coins.Add(new Quarter());
            }
            for (int i = 0; i < 15; i++)
            {
                coins.Add(new Dime());
            }
            for (int i = 0; i < 15; i++)
            {
                coins.Add(new Nickel());
            }
            for (int i = 0; i < 25; i++)
            {
                coins.Add(new Penny());
            }

            card = new Card();
            
             

        }
    }
}
