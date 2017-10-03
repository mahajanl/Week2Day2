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

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            { Console.WriteLine(month);
            }

        }
    }
}
