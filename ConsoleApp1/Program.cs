using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = "0";
                string ctr = "0";
                int i = 0;
                

                while (ctr=="0")
                {
                    Console.WriteLine("This program counts the summ of all elements in array");
                    Console.WriteLine("Enter the number of ellements of array.");
                    try
                    {
                        str = Console.ReadLine();
                        i = Convert.ToInt32(str);
                    }
                    catch (Exception e)
                    {
                        Console.Clear();

                        Console.WriteLine("You must enter only integer. Try again");

                        Thread.Sleep(3000);
                        Console.Clear();

                        continue;
                    }

                    if (i>100 || i<0)
                    {
                        Console.Clear();
                        Console.WriteLine("This program counts the summ of all elements in array");
                        Console.WriteLine("Number of elements of array is incorect.Try again");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("You Entered  " + str + " Correct? ");

                    Console.WriteLine($"Press 0 to change.\nAny key to continue ");

                    ctr = Console.ReadLine();
                    Console.Clear();
                    
                }

                double[] arr = new double[i];
                double  sum = 0;
                Console.WriteLine("This program counts the summ of all elements in array");
                Console.WriteLine("You have array with " + i + "  elements");
                for (int j=0;j<arr.Length;j++)
                {
                    try
                    {
                        Console.WriteLine("Enter the " + (j + 1) + " ellement");
                        arr[j] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("You must enter only numbers. Try again");
                        j--;
                        continue;
                    }
             
                    
                    sum += arr[j];
                    
                }
                Console.Clear();
                Console.WriteLine("This program counts the summ of all elements in array");
                Console.Write("Your array ellements: ");
                for (int j=0; j < arr.Length; j++)
                {
                    Console.Write(arr[j]+" ");
                }
                Console.WriteLine("The Sum of array ellements:" + sum);
                
                Console.WriteLine("Do you want to restart application?");
                Console.WriteLine("(Press 0 to quit.Any key to continue)");
                string ptr = Console.ReadLine();
                if (ptr == "0") break;

            }
            Console.ReadLine();

        }
    }
}
