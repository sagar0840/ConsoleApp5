using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;
             
            Console.WriteLine(" To Find a Number is Palindrome or not  ");
            Console.Write("Enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;     
                num = num / 10;  
                sum = sum * 10 + rem;
                
            }
            Console.WriteLine(" The Reversed Number is: {0} ", sum);
            if (temp == sum)    
            {
                Console.WriteLine(" Number is Palindrome ");
            }
            else
            {
                Console.WriteLine(" Number is not a palindrome ");
            }
            Console.ReadLine();
        }
    }
    }

