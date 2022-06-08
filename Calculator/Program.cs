using System;
using System.Numerics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             OutputConsole();
           
        }

        static void OutputConsole()
        {
            string [] operations = {"+","-","*","/", "^","!" };
            var inputOperation = "";
            var anser = "";
           
            Console.WriteLine("Please, enter the desired operation from the list:");
            foreach (string operation in operations)
            {
                Console.Write(operation + " ");
            }

            Console.WriteLine("\nOperation: ");
            inputOperation = Console.ReadLine().Trim();

            if (Array.IndexOf(operations, inputOperation) >= 0)
            {
                if (inputOperation != "!")
                {
                    ConsoleInput(inputOperation); 
                }
                else
                { 
                    CalculateFactorial();
                }
            }

            else { Console.WriteLine("Error!"); OutputConsole(); return; }
          
            do
            {
                Console.WriteLine("Do you wanna repeat? Enter Y/N.");
                anser = Console.ReadLine();
                anser = anser.ToUpper();
            }
            while (anser != "Y" && anser != "N");
            if (anser == "Y") OutputConsole();
            else Console.WriteLine("The job is done!");

        }

        static void ConsoleInput(string operation)
        {

            var one = false;
            var two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();
            Console.WriteLine("NumberOne: ");
            one = double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("NumberTwo: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);


            switch (operation)

            {
                case "+":
                    {
                        if (one && two && !double.IsInfinity(result = numberOne + numberTwo))

                            Console.WriteLine($"Rezult:{numberOne}+{numberTwo}={result}");
                        else
                        {
                            Console.WriteLine("Error!");
                            ConsoleInput(operation);
                        }

                        break;
                    }
                case "-":
                    {
                        if (one && two && !double.IsInfinity(result = numberOne - numberTwo))


                            Console.WriteLine($"Rezult:{numberOne}-{numberTwo}={result}");
                        else
                        {
                            Console.WriteLine("Error!");
                            ConsoleInput(operation);
                        }

                        break;
                    }
                case "*":
                    {
                        if (one && two && !double.IsInfinity(result = numberOne * numberTwo))


                            Console.WriteLine($"Rezult:{numberOne}*{numberTwo}={result}");
                        else
                        {
                            Console.WriteLine("Error!");
                            ConsoleInput(operation);
                        }

                        break;
                    }
                case "/":
                    {
                        if (one && two && !double.IsInfinity(result = numberOne / numberTwo))


                            Console.WriteLine($"Rezult:{numberOne}/{numberTwo}={result}");
                        else
                        {
                            Console.WriteLine("Error!");
                            ConsoleInput(operation);
                        }

                        break;
                    }
                case "^":
                    {
                        if (one && two && !double.IsInfinity(result = Math.Pow(numberOne, numberTwo)))


                            Console.WriteLine($"Rezult:{numberOne}^{numberTwo}={result}");
                        else
                        {
                            Console.WriteLine("Error!");
                            ConsoleInput(operation);
                        }

                        break;
                    }
           
            }

        }
        static void CalculateFactorial()
        {
            var numberOnlyOne=new int();      
            Console.WriteLine("Number from 1 to 1000: ");
            if (int.TryParse(Console.ReadLine(), out numberOnlyOne) && numberOnlyOne > 0 && numberOnlyOne <= 1000)

                Console.WriteLine($"Rezult: {numberOnlyOne}!={Factorial(numberOnlyOne)}");
            else
            {
                Console.WriteLine("Error!");
                CalculateFactorial();
            }
        }
        static BigInteger Factorial(int numberOne)
        {              
            
                if (numberOne == 1) return 1;
                return numberOne * Factorial(numberOne - 1);                           

        }
    }
}
