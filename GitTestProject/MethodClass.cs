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
            

            Console.WriteLine("Enter age: ");
            int userInput = int.Parse(Console.ReadLine());

            CheckAge(userInput);


        }

    }
}
