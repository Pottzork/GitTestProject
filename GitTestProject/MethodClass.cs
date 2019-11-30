using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestProject
{
    public class MethodClass
    {

        public void CheckAge(int age)
        {

            //Some cheecky booring strings to tell if a certain behavior occurs
            string tenYear = "Wow you are over ten year old";
            string underten = "Babyface";

            if (age > 10)
            {
                Console.WriteLine(tenYear);
            }
            else
            {
                Console.WriteLine(underten); ;
            }
        }


        public void TellAge()
        {
            
            //Prompts user to enter age
            Console.WriteLine("Enter age: ");
            int userInput = int.Parse(Console.ReadLine());

            CheckAge(userInput);


        }

    }
}
