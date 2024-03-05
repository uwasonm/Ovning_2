namespace Ovning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Make a choice corresponding to what you want to do!");
                Console.WriteLine(" 0. End the program");
                Console.WriteLine(" 1. Cinema App");
                Console.WriteLine(" 2. Run a while loop");
                Console.WriteLine(" 3. Repeat entered text 10 times");
                Console.WriteLine(" 4. Fetch 3rd word of a sentence");
                Console.WriteLine(" ...............................");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        CinemaApp();
                        break;
                    case "2":
                        TheWhileLoop();
                        break;
                    case "3":
                        TheRepetion();
                        break;
                    case "4":
                        WordFetch();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            while (true);
        }

        private static void TheWhileLoop()  // Displays an unending while loop using a boolean 
        {
            bool check = true;
            while (check)
            {
                Console.Write(" This is a while loop. ");
            }
        }

        private static void TheRepetion()//Repeats user provided text ten times
        {
            Console.WriteLine("Enter any text: ");
            string text = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + "." + text + ", ");
            }
            Console.ReadLine();
        }
        private static void WordFetch()  // Dispalys the 3 word of the entered sentence
        {
            Console.Write("Enter a sentence of your choice of at least 3 words:");
            var sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            Console.WriteLine("The third word in your setence is: " + words[2]);
            Console.ReadLine();
        }
        private static void CinemaApp() //accepts an age, checks the age category, displays the cost corrresponding to the age
        {
            int youth = 0;
            int pensioner = 0;
            int standard = 0;
            int bonus = 0;

            Console.Write("How many people do we have on the queue: ");
            string people = Console.ReadLine();
            int number = int.Parse(people);

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter your age: ");
                string enteredAge = Console.ReadLine();
                int age = int.Parse(enteredAge);

                if (age < 20)
                {
                    Console.WriteLine("The cost is SEK 80");
                    youth++;//counter of those whose age is below 20
                }
                else if (age > 64)
                {
                    Console.WriteLine("The cost is SEK 90");
                    pensioner++;//counter of those whose age is above 64
                }

                else if ((age < 5) || (age > 100))
                {
                    Console.WriteLine("The entry is free for you!");
                    bonus++; //counter of those whose age is bellow 5 and those above 100
                 }

                else
                {
                    Console.WriteLine("The cost is SEK 120");
                    standard++;
                }

            }
            int numberOfPeople = bonus + youth + pensioner + standard;
            int totalCost = bonus * 0 + youth * 80 + pensioner * 90 + standard * 120;
            Console.WriteLine($"There are {youth} in the youth category {pensioner} pensioner(s) {standard} standard(s) and {bonus} below age 5 or above 100 yeárs");
            Console.WriteLine("The total cost is " + totalCost);
            Console.ReadLine();
        }

    }
}