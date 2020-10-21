using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        public Wallet wallet;
        public Backpack backpack;

        public Customer()
        {
            backpack = new Backpack();
            wallet = new Wallet();
        }

        //    If enough money is not passed in, don’t complete transaction and give the money back.
        //    If exact change is passed in, accept payment and dispense a soda instance that gets saved in my
        //         Backpack.
        //    If too much money is passed in, accept the payment, return change as a list of coins from
        //         internal, limited register, and dispense a soda instance that gets saved to my Backpack.
        //    If too much money is passed in but there isn’t sufficient change in the machine’s internal
        //         register, don’t complete transaction: give the money back.
        //    If exact or too much money is passed in but there isn’t sufficient inventory for that soda, don’t
        //         complete the transaction: give the money back

        public void PurchaseSoda()
        {

            
        }

    }
}
