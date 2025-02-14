using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_IPZ_2_1
{
    internal class FindingBiggestNumbers
    {
        int number1, number2, number3;
        string result;

        public int Number1   // property
        {
            get;    // get method
            set;   // set method
        }

        public int Number2   // property
        {
            get;    // get method
            set;   // set method
        }

        public int Number3   // property
        {
            get;    // get method
            set;   // set method
        }

        public int Result   // property
        {
            get;    // get method
            set;   // set method
        }


        public void DataInput()
        {

            Console.Write("Input the first number :");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number :");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number :");
            Number3 = Convert.ToInt32(Console.ReadLine());
        }
        public void Finding_Biggest_Numbers()
        {
            if (Number1 > Number2 && Number1 > Number3)
            {
                result = "The 1st Number is the greatest among three. \n";
            }
            else if (number2 > number1 && number2 > number3)
            {
                result = "The 2nd Number is the greatest among three \n";
            }
            else
            {
                result = "The 3rd Number is the greatest among three \n";
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }



    }
}
