namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintThousand()
        {
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            
        }

        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        public static void PrintEveryThirdNumber()
        {
            for (var k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }


        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("They are equal.");
                return true;
               
            }
            else
            {
                Console.WriteLine("They are not equal.");
                return false;
                
            }
        }



        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
                return false;
            }
        }

        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int number)
        {
            if (number >= 0)
            {
                Console.WriteLine($"{number} is positive.");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
                return false;
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote()
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine($"At {age}, you are eligible to vote.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"At {age}, you are not eligible to vote.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return false;
            }
        }


        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is within the range -10 to 10.");
                return true;
            }
            else
            {
                Console.WriteLine($"{number} is outside the range -10 to 10.");
                return false;
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }


        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {   // i have commented out my methods for user beforehand
            
            //PrintThousand();
            //PrintEveryThirdNumber();
            //AreNumbersEqual(1000, 1738);
            //IsEven(4);
            //IsPositive(100);
            //CanVote();
            //IsInRange(10);
            //DisplayMultiplicationTable(100);
        }
    }
}
