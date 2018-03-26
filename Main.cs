//DYLAN GRANDJEAN
//Assignment 9 - Wayland Boots
//Program designed to evaluate the income and expense of a company.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment9
{
    class Main
    {
        static void Main(string[] args)
        {
            //Variable instantiation
            string inputValue;
            double amount;

            Header();
            Instructions();

            //Create new class
            Calculations calc = new Calculations();

            //Prime reading for loop #1
            Console.Write("Enter Income (Enter value -99 to stop) ");
            inputValue = Console.ReadLine();

            //Prompt user for incomes until user enter -99
            while (inputValue != "-99")
            {
                if (double.TryParse(inputValue, out amount) == false)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    calc.Income = double.Parse(inputValue);
                }
                Console.Write("Enter Income (Enter value -99 to stop) ");
                inputValue = Console.ReadLine();
            }

            //Prime reading for loop #2
            Console.Write("Enter Expense (Enter value -99 to stop) ");
            inputValue = Console.ReadLine();

            //Prompt user for expense until user enter -99
            while (inputValue != "-99")
            {
                if (double.TryParse(inputValue, out amount) == false)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    calc.Expense = double.Parse(inputValue);
                }
                Console.Write("Enter Expense (Enter value -99 to stop) ");
                inputValue = Console.ReadLine();
            }

            //Display result to console
            Console.WriteLine("**************************************************\n" +
                              "Total Income is {0:c}\n" +
                              "Total Expense is {1:c}\n" +
                              "Total Profit is {2:c}\n",
                              calc.Income, calc.Expense, calc.Profit);

            //Evaluate wether amount is greater, lesser, or equal to 0 and display box accordingly
            if (calc.Profit > 0)
                MessageBox.Show("Wayland Boot made a profit", "Wayland Boots");
            else if (calc.Profit < 0)
                MessageBox.Show("Wayland Boot had a loss", "Wayland Boots");
            else
                MessageBox.Show("Wayland Boot made no profit, and had no loss", "Wayland Boots");

            Console.Read();

        }

        //Display header with title, name, and date
        static void Header()
        {
            Console.WriteLine("**************************************************\n" +
                              "\tWayland Boots Profit Loss Statement\n" +
                              "\tCalculate profit or loss\n" +
                              "\tDylan Grandjean\n\t" +
                              DateTime.Today.ToShortDateString());
        }

        //Display instructions for program
        static void Instructions()
        {
            Console.WriteLine("**************************************************\n" +
                              "This program will calculate profit or loss\n\n" +
                              "Enter the company's income\n" +
                              "When finished with income, enter the company's expenses\n\n" +
                              "**************************************************");
        }
    }
}
