﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldTest
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome!");

           
            SwapTwoNumbers.ReadingInputFromUser();
            SwapTwoNumbers.x = 70;
            SwapTwoNumbers.y = 80;
            SwapTwoNumbers obj1 = new SwapTwoNumbers();
            obj1.first = 10;
            obj1.second = 20;
            Console.WriteLine("obj1 instance variables:first={0} second={1} static varibels:x={2} y={3}", obj1.first, obj1.second, SwapTwoNumbers.x, SwapTwoNumbers.y);
            SwapTwoNumbers obj2 = new SwapTwoNumbers();
            obj2.first = 30;
            obj2.second = 50;
            
            Console.Read();
        }
    }
    
}
