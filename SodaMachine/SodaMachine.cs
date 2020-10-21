using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class SodaMachine
    {
        public List<Coin> register;
        public List<Can> inventory;

        public SodaMachine()
        {
            //20 quarters, 10 dimes, 20 nickels, 50 pennies at spawn
            register = new List<Coin>();
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Nickel());
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());
            }

            inventory = new List<Can>();
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new RootBeer());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new Cola());
            }
            for (int i = 0; i < 10; i++)
            {
                inventory.Add(new OrangeSoda());
            }

            
        }

        public void SetMachineName(string pancakes)
        {

        }
        public void CompletePurchase(List<Coin> coinsFromHuman)
        {
            
        }
    }

    
}
