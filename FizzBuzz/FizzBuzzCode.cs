using System;

namespace FizzBuzz
{
    public class FizzBuzzCode
    {
        private double a;

        public FizzBuzzCode(double a)
        {
            this.a = a;
           
        }

        public string getText()
        {
            if (a % 3 == 0 && a % 5 ==0)
            {
                return "fizzbuzz";
            }
            if (a % 3 == 0) {
                return "fizz";
            }
            if (a % 5 == 0)
            {
                return "buzz";
            }
            return "neither";
                }
    }
}