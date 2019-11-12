using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCurrencyConverted
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User dan = new User();
            //todo switch for actions
            Console.WriteLine("Hello! What action would you like to take?\n1)View your digital currencies\n2)Purchase Currency\n3)Sell Currency\n4)Transfer Currency");

            bool go = true;

            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        //TODO Code for viewing currencies
                        break;
                    case ConsoleKey.D2:
                        //TODO code to purchase currency
                        bool goTwo = true;

                        do
                        {
                            Console.WriteLine("Select what type of currecy you would like purchase?\n1) Bitcoin\n2)Etherium\n3)Litecoin");

                            ConsoleKey selection = Console.ReadKey(true).Key;

                            Console.WriteLine("How much would you like to purchase?");
                            string response = Console.ReadLine();

                            int amountToPurchase = Int32.Parse(response);

                            decimal convert;
                            switch (selection)
                            {
                                case ConsoleKey.D1:
                                    convert = 7480m;
                                    break;
                                case ConsoleKey.D2:
                                    convert = 586.15m;
                                    break;
                                case ConsoleKey.D3:
                                    convert = 119.04m;
                                    break;
                                default:
                                    convert = 0;
                                    break;
                            }
                            if (convert * amountToPurchase > dan.Cash)
                            {
                                Console.WriteLine("You're too poor! Enter a lower number");
                                goTwo = false;
                            }
                            else
                            {
                                switch (selection)
                                {
                                    case ConsoleKey.D1:
                                        dan.Bitcoin += amountToPurchase;
                                        dan.Cash -= amountToPurchase * convert;
                                        break;
                                    case ConsoleKey.D2:
                                        dan.Etherium += amountToPurchase;
                                        dan.Cash -= amountToPurchase * convert;
                                        break;
                                    case ConsoleKey.D3:
                                        dan.Litecoin += amountToPurchase;
                                        dan.Cash -= amountToPurchase * convert;
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine($"You bought {amountToPurchase} currency for {convert * amountToPurchase:c} and have {dan.Cash:c} left");
                            }
                            Console.WriteLine((goTwo == false ? "Try a" : "A")+"gain? Press enter to purchase more");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.Enter:
                                    goTwo = true;
                                    Console.Clear();
                                    break;
                                default:
                                    goTwo = false;
                                    break;
                            }

                        } while (goTwo);
                        
                        break;
                    case ConsoleKey.D3:
                        bool goThree = true;

                        do
                        {
                            Console.WriteLine("Select what type of currecy you would like sell?\n1) Bitcoin\n2)Etherium\n3)Litecoin");

                            ConsoleKey selection = Console.ReadKey(true).Key;

                            Console.WriteLine("How much would you like to sell?");
                            string response = Console.ReadLine();

                            int amountToPurchase = Int32.Parse(response);

                            decimal convert;
                            switch (selection)
                            {
                                case ConsoleKey.D1:
                                    convert = 7480m;
                                    if (amountToPurchase > dan.Bitcoin)
                                    {
                                        Console.WriteLine("Not enough to sell, enter less");
                                    }
                                    else
                                    {
                                        dan.Bitcoin -= amountToPurchase;
                                        dan.Cash += amountToPurchase * convert;

                                    }

                                    break;
                                case ConsoleKey.D2:
                                    convert = 586.15m;
                                    if (amountToPurchase > dan.Etherium)
                                    {
                                        Console.WriteLine("Not enough to sell, enter less");
                                    }
                                    else
                                    {
                                        dan.Etherium -= amountToPurchase;
                                        dan.Cash += amountToPurchase * convert;

                                    }

                                    break;
                                case ConsoleKey.D3:
                                    convert = 119.04m;
                                    if (amountToPurchase > dan.Litecoin)
                                    {
                                        Console.WriteLine("Not enough to sell, enter less");
                                    }
                                    else
                                    {
                                        dan.Litecoin -= amountToPurchase;
                                        dan.Cash += amountToPurchase * convert;
                                    }
                                    break;
                                default:
                                    convert = 0;
                                    break;
                            }
                            Console.WriteLine($"You sold {amountToPurchase} currency for {convert * amountToPurchase:c} and have {dan.Cash:c} left");
                            Console.WriteLine("Again? Press enter to sell more");
                            switch (Console.ReadKey(true).Key)
                            {
                                case ConsoleKey.Enter:
                                    goThree = true;
                                    Console.Clear();
                                    break;
                                default:
                                    goThree = false;
                                    break;
                            }

                        } while (goThree);
                        break;
                    case ConsoleKey.D4:
                        //TODO Transfer currency
                        break;
                    default:
                        Console.WriteLine("That is a invalid selection!!! Please try again.");
                        break;
                }

            } while (go);
           
    

        }
    }
}
