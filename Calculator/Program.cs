using System;
using System.Numerics;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             outputConsole();
           
        }

        static void outputConsole()
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
            inputOperation = Console.ReadLine().ToString();
            
            if (Array.IndexOf(operations, inputOperation) >= 0)
            {
                switch (inputOperation)
                    
                {
                    case "!" :
                        {
                            CalculateFactorial();
                            break; }
                    case "+": 
                        {
                            CalculateAddition();
                            break;                        
                        }
                    case "-":
                        {
                            CalculateSubtraction();
                            break; 
                        }
                    case "*":
                        {
                            CalculateMultiplication();
                            break;
                        }
                    case "/": 
                        {
                            CalculateDivision();
                            break;
                        }
                    case "^": 
                        {
                            CalculatePow();
                            break;
                        }
                    default: { outputConsole(); break; }
                }
             
            }
            else { Console.WriteLine("Error!"); outputConsole(); return; }
          
            do
            {
                Console.WriteLine("Do you wanna repeat? Enter Y/N.");
                anser = Console.ReadLine();

                anser = anser.ToUpper();
            }
            while (anser != "Y" && anser != "N");
            if (anser == "Y") outputConsole();
            else Console.WriteLine("The job is done!");

        }

        static void CalculateAddition()
        {
            bool one= false;
            bool two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();

            Console.WriteLine("Addition");
            Console.WriteLine("NumberOne: ");
            one= double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("NumberTwo: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);

            if (one && two && !double.IsInfinity(result = numberOne + numberTwo))

                Console.WriteLine($"Rezult:{numberOne}+{numberTwo}={result}");
            else
            {
                Console.WriteLine("Error!");
                CalculateAddition();
            }

        }
        static void CalculateMultiplication()
        {
            bool one = false;
            bool two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();
            Console.WriteLine("Multiplication");
            Console.WriteLine("NumberOne: ");
            one = double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("NumberTwo: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);

            if (one && two && !double.IsInfinity(result = numberOne * numberTwo))

                Console.WriteLine($"Rezult:{numberOne}*{numberTwo}={result}"); 
            else
            {
                Console.WriteLine("Error!");
                CalculateMultiplication();
            }

        }
        static void CalculateSubtraction()
        {
            bool one = false;
            bool two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();
            Console.WriteLine("Subtraction");
            Console.WriteLine("NumberOne: ");
            one = double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("NumberTwo: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);

            if (one && two && !double.IsInfinity(result = numberOne - numberTwo))

                Console.WriteLine($"Rezult:{numberOne}-{numberTwo}={result}");
            else
            {
                Console.WriteLine("Error!");
                CalculateSubtraction();
            }

        }
        static void CalculateDivision()
        {
            bool one = false;
            bool two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();
            Console.WriteLine("Division");
            Console.WriteLine("NumberOne: ");
            one = double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("NumberTwo: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);

            if (one && two && !double.IsInfinity(result = numberOne / numberTwo))

                Console.WriteLine($"Rezult:{numberOne}/{numberTwo}={result}");
            else
            {
                Console.WriteLine("Error!");
                CalculateDivision();
            }

        }
        static void CalculatePow()
        {
            bool one = false;
            bool two = false;
            var numberOne = new double();
            var numberTwo = new double();
            var result = new double();
            Console.WriteLine("Degree of");
            Console.WriteLine("Number: ");
            one = double.TryParse(Console.ReadLine(), out numberOne);
            Console.WriteLine("Degree of number: ");
            two = double.TryParse(Console.ReadLine(), out numberTwo);

            if (one && two && !double.IsInfinity(result = Math.Pow( numberOne, numberTwo)))

                Console.WriteLine($"Rezult:{numberOne}^{numberTwo}={result}");
            else
            {
                Console.WriteLine("Error!");
                CalculatePow();
            }

        }
        static void CalculateFactorial()
        {
            var numberOnlyOne=new int();
            Console.WriteLine("Factorial");
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
