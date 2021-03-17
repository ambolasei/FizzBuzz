using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra
{
    class FizzBuzz
    {
        public string Play(int Number)
        {
            if (Number%3==0 && Number%5!=0)
            {
                return "Fizz";
            }
            else if (Number%5==0 && Number%3!=0)
                {
                return "Buzz";
            }
            else if (Number%3==0 && Number%5==0)
            {
                return "FizzBuzz";
            }
            else
            {
                return Convert.ToString(Number);
            }
        }
    }
}
