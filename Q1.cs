using System;

namespace ConsoleApp1
{
    class Program
    {
        private static object exit;

        static void Main(string[] args)
        {
            //take input
            string input;
            int n;
            Console.WriteLine("Enter integer for the number pattern of integers to be displayed ");
            input = Console.ReadLine();
            //n = IntegerUtilities.isValidInteger(String input);
            try
            {
                n = int.Parse(input);
                // n = Integer.parseInt(String i);
                //n = Convert.ToInt32(input);
                bool stopProgram = false;

                while (stopProgram == false)
                {
                    if (n > 0)
                    {
                        while (n != 0)
                        {
                            for (int i = n; i > 0; i--)
                            {
                                Console.Write(i);
                            }
                            Console.WriteLine("\n");
                            n--;
                        }
                        stopProgram = true;
                    }
                    else
                    {
                        Console.Write("Kindly enter a valid positive integer value.Exiting the application");
                        stopProgram = true;
                    }

                }
            }
            catch
            {
                Console.WriteLine(
                    $"The entered { input } is not a valid input format.");
               // result = 1;
            }




        }
    }
}
