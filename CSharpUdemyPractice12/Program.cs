using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpUdemyPractice12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to 
            //re -try; otherwise, display the 3 smallest numbers in the list.
            string nums;
            var attempts = 0;

            Console.WriteLine("Please enter a list of comma-separated numbers:  ");
            nums = Console.ReadLine();
            Console.WriteLine("You entered " + nums + ".");
            Console.WriteLine();//blank
            char[] splitChar = { ',' };  //could put in other items like spaces, /, etc to split using this kind of array setup
            var numberSplitArr = nums.Split(splitChar); //creates string array with just the string of numbers

            while (numberSplitArr.Length < 5)//if the user enters fewer than 5 numbers
            {
                Console.WriteLine("Invalid length.");
                Console.WriteLine("Please enter a list of comma-separated numbers:  ");
                nums = Console.ReadLine();
                Console.WriteLine("You entered " + nums + ".");
                numberSplitArr = nums.Split(splitChar); //must give it a way to break out of the loop
            }

            var numbersArr = new int[numberSplitArr.Length];//create a new int array of the same length to hold parsed numbers

            var i = 0;
            foreach (var number in numberSplitArr)
            {
                int.TryParse(number, out numbersArr[i]); //turn strings into integers and add to the int numbersArr
                i++; //increment i (sort of a hybrid for/foreach)
            }

            Array.Sort(numbersArr); //sort in ascending order

            for (var j = 0; j < 3; j++)
            {
                Console.WriteLine(numbersArr[j]);//get the first 3 numbers, which are the 3 lowest values
            }


            


            









        }
    }
}
