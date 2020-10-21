using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodaMachine = new SodaMachine();
            sodaMachine.SetMachineName("Hello");
            List<Coin> someCoins = new List<Coin>();
            sodaMachine.CompletePurchase(someCoins);
            
        }
    }
}
