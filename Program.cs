namespace BetterCalculator
{
    class Calculator
    {
        public static double MathOperation(double firstNum, double secondNum, string choice)
        {
            // Default value is "not-a-number" if an operation, such as division, could result in an error.
            double result = double.NaN;
            switch (choice)
            {
                case "+" :
                    result = firstNum + secondNum;
                    break;
                case "-" :
                    result = firstNum - secondNum;
                    break;
                case "*" :
                    result = firstNum * secondNum;
                    break;
                case "/" :
                    if(firstNum != 0 && secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    break;
                default: break;
            }
            return result;
        }
    }

    class ConsoleInterface
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("\tWelcome to Calculating in console\n");

            while (!endApp)
            {
                //declaring input numbers and result
                string firstNum = "", secondNum = "";
                double result = 0, firstParse = 0, secondParse = 0;

                //User inputs first number
                Console.WriteLine("\tPlease, enter first number <3");
                firstNum = Console.ReadLine();

                /*What is TryParse? TryParse is .NET C# method that allows you to try and parse a string into a specified type.
                It returns a boolean value indicating whether the conversion was successful or not.
                If conversion succeeded, the method will return true and the converted value will be assigned to the output parameter.*/
                while (!double.TryParse(firstNum, out firstParse))
                {
                    Console.WriteLine("\tWrong input. Please input integer value");
                    firstNum = Console.ReadLine();
                }
                //Second input
                Console.WriteLine("\tNow enter a second value");
                secondNum= Console.ReadLine();

                while(!double.TryParse(secondNum, out secondParse))
                {
                    Console.WriteLine("\tWrong input. Please input integer value");
                    secondNum= Console.ReadLine();
                }
                // User chooses an operation
                Console.WriteLine("\tPlease enter the operation \n\t+ \n\t- \n\t* \n\t\\ \n");
                string choice = Console.ReadLine();

                //The try statement allows you to define a block of code to be tested for errors while it is being executed.
                //The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
                try
                {
                    result = Calculator.MathOperation(firstParse, secondParse, choice);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("\tThis operation will result in math error");
                    }
                    else
                    {
                        Console.WriteLine("Your result is "+ result);
                    }
                }
                catch(Exception e) 
                {
                    Console.WriteLine("\t Oh no Error. Try again");
                }
                //End or Begining 
                Console.WriteLine("\tType 'exit' if you finished all your calculations,if else press enter and do it again.");
                if (Console.ReadLine() == "exit") endApp= true;

                Console.WriteLine("\n");
            }

        }
    }
}

/*namespace ConsoleApp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and then initialize to zero
            float firstNum = 0, secondNum = 0;

            //Title display
            Console.WriteLine("Console Calculator in C#\r\n");

            divideDumDum:
            //User typing number uno
            Console.WriteLine("Type in first number, please");
            firstNum = Convert.ToInt32(Console.ReadLine());

            //User typing number dos
            Console.WriteLine("Type in second number, or else");
            secondNum = Convert.ToInt32(Console.ReadLine());

            //Man chooses, User obeys
            Console.WriteLine("Choose an option from following list");
            Console.WriteLine("\t+ - Add \n\t- - Subtract\n\t* - Multiply\n\t\\ - Divide\n");

            Bruhspot:
            //Man uses switch statement to do the math
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"You typed in + so {firstNum} + {secondNum} = " + (firstNum + secondNum));
                    break;
                case "-":
                    Console.WriteLine($"You monkeyed in - so ugaBuga first number - second number is " + (firstNum - secondNum));
                    break;
                case "*":
                    Console.WriteLine($"oh my Gahhhd you're such a multiplier UwU, multied for you so good " + (firstNum * secondNum));
                    break;
                case "\\":
                    if(firstNum == 0 || secondNum ==0) 
                    {
                        Console.WriteLine("You really just tried to divide a zero, no no no, try using brain");
                        goto divideDumDum;
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations obeyer, I divided this miningfull numbers cause I am better then you JaJaJaJa, look at my dividing " + (firstNum / secondNum));
                    }
                    break;
            }
            goto Bruhspot;
            
        }

    }
}
*/
