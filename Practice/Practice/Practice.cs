namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            //Exercises
            //Program 1 - Rectangle of stars
            //Using two for loops, produce a rectangle of stars, 50 across and 10 down
            //no write statement should have more than a single star in it
            //Console.WriteLine("Rectangle of stars:\n\n");
            //for (int col = 1; col <= 50; col++)
            //{
            //    for (int row = 1; row <= 10; row++)
            //    {
            //        Console.Write("*\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            ////Program 2 - Spreadsheet
            ////Create the labels of an excel sheet for k cols and 20 rows.
            //Console.WriteLine("Spreadsheet:");
            //for (int col = 1; col <= 20; col++)
            //{
            //    for (char letter = 'A'; letter <= 'K'; letter++)
            //    {
            //        Console.Write($"{letter}{col}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            ////Program 3 - Display 1 - 10 incrementing
            ////Produce the following using a nested for loop.
            ////Have one controlling variable called round and the other called count
            //Console.WriteLine("Round incrementing:");
            //for (int round = 1; round <= 10; round++)
            //{
            //    Console.WriteLine($"Round: {round}");
            //    for (int count = 1; count <= round; count++)
            //    {
            //        Console.Write($"{count}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            //Program 4 - Produce a triangle of stars
            //Console.WriteLine("Triangle of stars");
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            ////Program 5 - multiplication table
            //for (int col = 1; col <= 10; col++)
            //{
            //    Console.WriteLine();
            //    for (int row = 1; row <= 10; row++)
            //    {
            //        Console.WriteLine();
            //        Console.Write($"{col} x {row} = {col * row}");
            //    }

            //}
            //Console.ReadLine();

            ////Program 6 - Triangle of letters
            ////write a program that asks for a start and stop letter
            //char startingLetter, endLetter;
            //Console.Write("Enter a starting letter: ");
            //startingLetter = char.Parse(Console.ReadLine());
            //Console.Write("Enter a stopping letter: ");
            //endLetter = char.Parse(Console.ReadLine());
            //for (char round = startingLetter; round <= endLetter; round++)
            //{
            //    for (char control = startingLetter; control <= round; control++)
            //    {
            //        Console.Write($"{control}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            //Program 7 - The Lotto Problem
            //create an array containing 6 lotto numbers. this is not as quite as just
            //generating a random number between 1 and 40 and putting it into your array
            //what say that number has already been picked? generate the random number
            //into a temporary variable and only when you have checked it is not
            //already in the array do you store it in the array, otherwise regenerate
            //the number and check again
            //HINT: i did this with a for loop and a nested while loop
            int randomGenerator;
            Random rand = new Random();
            int[] lottoArray = new int[6];
            for (int i = 0; i < lottoArray.Length; i++)
            {
                randomGenerator = rand.Next(1, 7);
                for(int k = 0; k < i; k++)
                {
                    while (lottoArray[k] == randomGenerator)
                    {
                        Console.WriteLine($"DUPLICATE HAS OCCURED: {lottoArray[k]}");
                        randomGenerator = rand.Next(1, 7);
                        //restart duplicate checking
                        k = 0;
                    }
                    
                }
                lottoArray[i] = randomGenerator;
            }

            Console.WriteLine("Your lotto numbers: ");
            for(int  i = 0;i < lottoArray.Length; i++)
            {
                Console.Write($"{lottoArray[i]}\t");
            }

            Console.ReadLine();
        }
    }
}
