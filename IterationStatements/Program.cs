namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //LukeWarm Section: Create methods below
             count();
             threes();
             equal();
             or();
             posneg();
             Age();
             userint();
            multi();
        }
        public static void count()
        {
            //Write a method that will print to the console all numbers 1000 through - 1000

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void threes()
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time
            
            for (int i = 0; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }
        public static void equal()
        {
            //Write a method to accept two integers as parameterss and check whether they are equal or not

            int num1 = 3, num2 = 5;

            if (num2 == num1)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }

        }
        public static void or()
        {
            //Write a method to check whether a given number is even or odd

            int x = 37;

            if(x%2 == 0)
            {
                Console.WriteLine($"{x} is even.");
            }
            else
            {
                Console.WriteLine($"{x} is odd.");
            }
        }
        public static void posneg()
        {
            //Write a method to check whether a given number is positive or negative

            int i = -52;

            if(i > 0)
            {
                Console.WriteLine($"{i} is positive");
            }
            else
            {
                Console.WriteLine($"{i} is negative");
            }
        }
        public static bool Age()
        {
            //Write a method to read the age of a candidate and determine whether they can vote.
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()

            Console.WriteLine("Pleae enter your age.");
            var canParse = int.TryParse(Console.ReadLine(), out int num);


            while (canParse == false)
            {
                Console.WriteLine("That was not a vaild age, please try again");
                canParse = int.TryParse(Console.ReadLine(), out num);
            }   
                if (num >= 18)
                {
                    Console.WriteLine($"You are {num}, it's time to go and vote!");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{num} is not old enought to vote, maybe next year!");
                    return false;
                }

            
        }
        public static void userint()
        {
            //Heatin Up Section:
            //Write a method to check if an integer(from the user) is in the range -10 to 10
            int num = 5;

            if(num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the ten range");
            }
            else
            {
                Console.WriteLine($"{num} is not in the ten range");
            }
        }

        public static void multi()
        {
            //Write a method to display the multiplication table(from 1 to 12) of a given integer

            int num = 2;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }




        //Call the methods to test them in the Main method below
    }
}
