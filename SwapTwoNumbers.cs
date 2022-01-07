using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest
{
    public class SwapTwoNumbers
    {
        public int first = 0, second = 0;
        public static int x = 0, y = 0;
        public static void ReadingInputFromUser()
        {

            Console.WriteLine("Please enter first number");
            int first =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Second number");
            int second = Convert.ToInt32(Console.ReadLine());
            SwapTwoNumbers swap = new SwapTwoNumbers();
            swap.SwapNumbers(first, second);
        }
        public void SwapNumbers(int first,int second)
        {
            int temp = 0;
            Console.WriteLine("Before swapping :first={0} second={1}", first, second);
            temp=first;
            first=second;
            second=temp;
            Console.WriteLine("After swapping :first={0} second={1}", first, second);

        }
    }
}
