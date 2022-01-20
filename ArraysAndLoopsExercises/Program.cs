using System;
//using System.IEnumerable;


namespace ArraysAndLoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("ARRAYS AND LOOPS EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Sort the Numbers");
                Console.WriteLine("2. Which Day of the Week?");
                Console.WriteLine("3. Find the Smallest Number in an Array");
                Console.WriteLine("4. Shopping List");
                Console.WriteLine("5. What's the Longest Word?");
                Console.WriteLine("6. What's the Second to Last Word?");
                Console.WriteLine("7. Print a Triangle");
                Console.WriteLine("8. Common Values");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        SortTheNumbers();
                        break;
                    case "2":
                        WhichDayOfWeek();
                        break;
                    case "3":
                        SmallestNumberInArray();
                        break;
                    case "4":
                        ShoppingList();
                        break;
                    case "5":
                        LongestWord();
                        break;
                    case "6":
                        SecondToLastWord();
                        break;
                    case "7":
                        PrintTriangle();
                        break;
                    case "8":
                        CommonValues();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void SortTheNumbers()
        {
            // Ask 10 people for their favorite numbers and create an array of those numbers. 
            // Order the numbers using the sort method. Print the first and last numbers.

            Console.Clear();
            Console.WriteLine("SORT THE NUMBERS\n");
            int[] userInput = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("input a number: ");
                userInput[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(userInput);

            Console.WriteLine($"First number is: {userInput[0]}  Last number is: {userInput[9]}");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichDayOfWeek()
        {
            // Declare and initialize a string array with the 7 days of the week. 
            // Print the number corresponding to each day and the day of the week. (1 = Sunday, 2 = Monday, etc.)

            // Ask the user for a number between 1 - 7.
            // Print the day of the week that corresponds to the number
            
            Console.Clear();
            Console.WriteLine("WHICH DAY OF THE WEEK?\n");

            // Enter your solution here
            string[] days = new string[7] {
                "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            Console.WriteLine("Enter a number between 1 and 7: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(days[userInput - 1]);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SmallestNumberInArray()
        {
            // Ask the user for 5 integers and save them in an array. 
            // Find the smallest number in the array and write it to the screen.

            Console.Clear();
            Console.WriteLine("FIND THE SMALLEST NUMBER IN AN ARRAY\n");
            int[] userInput = new int[5];

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input a number: ");
                userInput[i] = Convert.ToInt32(Console.ReadLine());




            }

            int min = Int32.MaxValue;

            

            for (int j = 0; j < userInput.Length; j++)
            {
                if (userInput[j] < min)
                {
                    min = userInput[j];
                }
            }

            Console.WriteLine($"Smallest number is: {min}");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ShoppingList()
        {
            // Initialize an array with 4 food items. Print this shopping list to the console.

            Console.Clear();
            Console.WriteLine("SHOPPING LIST\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void LongestWord()
        {
            // Ask the user for a phrase consisting of 1-4 words (no punctuation).
            // Print the longest word in the phrase. If 2 words have the same length, print both.

            Console.Clear();
            Console.WriteLine("WHAT'S THE LONGEST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SecondToLastWord()
        {
            // Ask the user for a sentence or phrase consisting of at least 4 words.
            // Find the second to last word and print it.

            Console.Clear();
            Console.WriteLine("WHAT'S THE SECOND TO LAST WORD?\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void PrintTriangle()
        {
            // Ask the user for a number between 3 and 6. 
            // Print one asterisk to the screen. 
            // On the next line print 2 asterisks, and continue until the users number is reached.

            Console.Clear();
            Console.WriteLine("PRINT A TRIANGLE\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void CommonValues()
        {
            // You are given 3 arrays of the same size, where 1 is empty and 2 have values. 
            // Use nested loops to find the values that are common between the 2 arrays.

            Console.Clear();
            Console.WriteLine("COMMON VALUES\n");

            // Enter your solution here

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}


