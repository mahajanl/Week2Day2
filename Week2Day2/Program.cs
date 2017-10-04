using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] someNames = { "Sally", "Timmy", "Tommy", "Henry", "Susy", "Charles" };
            //Console.WriteLine(Array.IndexOf(someNames, "Henry"));

            //int[] luckyNums = { 2, 4, 5, 4, 7, 9, 7, 2, 5 };
            //Console.WriteLine(Array.LastIndexOf(luckyNums, 2));

            //char[] alpha = { 's', 'd', 'j', 'l', 'x', 'p' };
            //Console.WriteLine(alpha[0]);
            //Console.WriteLine("And once I flip it and reverse it...");
            //Array.Reverse(alpha);
            //Console.WriteLine(alpha[0]);

            //string[] studentNames = { "Sally", "Tim", "Tommy", "Henry", "Sue", "Charles", "Apple" };
            //Array.Sort(studentNames);
            //Console.WriteLine("Alphabetically speaking, the first student's name is " + studentNames[0] + " and the \nlast student's name is " + (studentNames[studentNames.Length - 1]));

            //int[] faveNums = { 13, 7, 14, 21, 17, 5, 15, 3, 23, 12 };
            //Array.Sort(faveNums);
            //Console.WriteLine("The lowest number of the array is " + faveNums[0] + " and the largest is " + (faveNums[faveNums.Length - 1]) + ".");

            //for(int i = 0; i <= 10; i++)
            //{ Console.WriteLine(i); }

            //             as long as i is less than or equal to 10
            //for(int i = 1; i <= 10; i++)
            //{ Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.Write(counter + " ");
            //}

            //string greeting = "My name is Ultron";
            //string[] words = greeting.Split();

            //for (int i = 0; i < words.Length; i++) 
            //{ Console.WriteLine(words[i]);
            //}

            //string greeting = "My name is Yosemite Sam.";
            //string[] words = greeting.Split();

            //for(int i = 0; i < words.Length; i++)
            //{ Console.WriteLine(words[i]);
            //}

            //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //for (int i = 0; i < days.Length; i++)
            //string day = "Monday Tuesday Wednesday Thursday Friday Saturday Sunday";
            //string[] recall = day.Split();
            //for (int i = 0; i < recall.Length; i++)
            //{ Console.WriteLine(recall[i]);
            //}

            //string storyWords = "Once upon a time";
            //string [] wordsStory = storyWords.Split();
            //Array.Reverse(wordsStory);
            //for (int i=0; i < wordsStory.Length; i++)
            //{ Console.WriteLine(wordsStory[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            //foreach (string month in months)
            //{ Console.WriteLine(month);
            //}

            //string[] artists = { "Matchbox 20", "Black Keys", "Florence and the Machine", "Lin Manuel Miranda", "Clint Black" };
            //foreach(string artist in artists)
            //{ Console.WriteLine(artist);
            //}

            //string[] foodsILike = { "Avocado", "Goat cheese", "Butternut squash", "A medium-rare steak", "Roasted salmon" };
            //foreach(string food in foodsILike)
            //{ Console.WriteLine(food);
            //}

            //int[] numsILike = { 4, 8, 16, 64, 7, 11, 13, 17, 31 };
            //Array.Sort(numsILike);
            //foreach (int number in numsILike)
            //{
            //    Console.WriteLine("Your lucky number is " + number + ".");
            //}

            //for(int i = 10; i >= 0; i--)
            //{ Console.WriteLine(i);
            //}

            //string[] colors = { "red", "white", "blue", "green" };
            //foreach (string color in colors) 
            //{ Console.WriteLine(color); }

            //WHILE LOOPS

            //Console.WriteLine("do you want a rematch? Type YES or NO");
            //string playAgain = Console.ReadLine();
            //while (playAgain == "YES") ;
            //{ Console.WriteLine("It's a rematch!");
            //  Console.WriteLine("do you want to play again? YES/NO");
            //        playAgain = Console.ReadLine();
            //}

            Console.WriteLine("Would you like to check in for your appointment? Type YES or NO");
            string ANSWER = Console.ReadLine().ToLower().Trim();
            while (ANSWER != "yes")
            {Console.WriteLine("PATIENT CHECK IN SYSTEM");
             Console.WriteLine("What is your full name (FIRST and LAST)");
                Console.ReadLine();
                Console.WriteLine("What is your 6 digit patient ID number");
                Console.ReadLine();
                Console.WriteLine("What is your appointment time?");
                Console.ReadLine();
                Console.WriteLine("Would you like the check your patient in for their appointment?");
                Console.ReadLine();
                }


        }
    }
}
