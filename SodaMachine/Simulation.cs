using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{

    class Simulation
    {
        public SodaMachine sodaMachine;
        public Customer customer;
        public Simulation()
        {
            customer = new Customer();
        }
        public void ChooseCoinsToPassIntoMachine()
        {
            List<Coin> coinsInHand = new List<Coin>();
            bool notDone = true;
            while (notDone)
            {
                Console.WriteLine("Please choose a coin to put in your hand.");
                Console.WriteLine($"1) Quarter\n2) Dime");
                Console.WriteLine($"3 Nickel\n4) Penny");
                string choice = Console.ReadLine();
                Coin coinToRemove = null;
                switch (choice)
                {
                    case "1":
                        coinsInHand.Add(new Quarter());
                        coinToRemove = FindCoinThatExistsInWallet("Quarter");
                        customer.wallet.coins.Remove(coinToRemove);
                        break;
                    case "2":
                        coinsInHand.Add(new Dime());
                        coinToRemove = FindCoinThatExistsInWallet("Dime");
                        customer.wallet.coins.Remove(coinToRemove);
                        break;
                    case "3":
                        coinsInHand.Add(new Nickel());
                        coinToRemove = FindCoinThatExistsInWallet("Nickel");
                        customer.wallet.coins.Remove(coinToRemove);
                        break;
                    case "4":
                        coinsInHand.Add(new Penny());
                        coinToRemove = FindCoinThatExistsInWallet("Penny");
                        customer.wallet.coins.Remove(coinToRemove);
                        break;
                    default:
                        break;
                }
            }
        }

        public Coin FindCoinThatExistsInWallet(string coinName)
        {
            foreach(Coin coin in customer.wallet.coins)
            {
                if(coin.name == coinName)
                {
                    return coin;
                }
            }
            return null;
        }
    }


}
