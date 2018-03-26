//DYLAN GRANDJEAN
//Assignment 9 - Wayland Boots
//Program designed to evaluate the income and expense of a company.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Calculations
    {
        //Variable instantiation
        double income;
        double expense;
        double profit;

        public Calculations(){}         //Default constructor

        //Set and add value of/to income and expense and returns their value when necessary
        public double Income
        {
            set { income += value; }
            get { return income; }
        }
        public double Expense {
            set { expense += value; }
            get { return expense; }
        }
        //Return value of profit
        public double Profit { get { return profit = income - expense; } }
    }
}
