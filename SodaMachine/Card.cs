﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Card
    {
        private double availableFunds;
        public double AvailableFunds
        {
            get
            {
                return availableFunds;
            }
            set
            {
                if(value <= 0)
                {
                    UserInterface.ShowMessage("You cannot overdraw your account");
                    availableFunds = 0;
                }
                else
                {
                    availableFunds = value;
                }
            }
        }
        public Card()
        {
            availableFunds = 5;
        }
    }
}
