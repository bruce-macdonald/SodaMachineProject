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
            sodaMachine = new SodaMachine();
        }
        public void ChooseCoinsToPassIntoMachine()
        {
            List<Coin> coinsInHand = new List<Coin>();
            bool notDone = true;
            while (notDone)
            {
                string choice = UserInterface.GetInput("Please choose a coin to put in your hand.\n1) Quarter\n2) Dime\n3) Nickel\n4) Penny\n 5) To finish choosing coins");
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
                    case "5":
                        notDone = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public Coin FindCoinThatExistsInWallet(string coinName)
        {
            foreach (Coin coin in customer.wallet.coins)
            {
                if (coin.name == coinName)
                {
                    return coin;
                }
            }
            return null;
        }

        public Can ChooseSoda()
        {
            string sodaChoice = UserInterface.GetInput("Which soda would you like?\n1)RootBeer\n2)Cola\n3)OrangeSoda");
            switch (sodaChoice)
            {
                case "1":
                    return new RootBeer();

                case "2":
                    return new Cola();

                case "3":
                    return new OrangeSoda();

            }
            return new RootBeer();
        }

        //public Can DispenseSoda()
        //{
        //    sodaMachine.inventory.Remove(rootBeer);
        //    sodaMachine.sodabox =rootBeer;
        //    return rootBeer;
        //}

        
    }
}









