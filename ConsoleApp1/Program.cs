using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n= 1;
                while (n < 100)
                {
                    Console.WriteLine("请输入月份简写");
                    string m = Console.ReadLine();
                    switch (m)
                    {
                        case "Jan":
                            Console.WriteLine("1");
                            break;
                        case "Feb":
                            Console.WriteLine("2");
                            break;
                        case "Mar":
                            Console.WriteLine("3");
                            break;
                        case "Apr":
                            Console.WriteLine("4");
                            break;
                        case "may":
                            Console.WriteLine("5");
                            break;
                        case "Jun":
                            Console.WriteLine("6");
                            break;
                        case "Jul":
                            Console.WriteLine("7");
                            break;
                        case "Aug":
                            Console.WriteLine("8");
                            break;
                        case "Sep":
                            Console.WriteLine("9");
                            break;
                        case "Oct":
                            Console.WriteLine("10");
                            break;
                        case "Nov":
                            Console.WriteLine("11");
                            break;
                        case "Dec":
                            Console.WriteLine("12");
                            break;
                    }
                }
             
            }
        }
    }

