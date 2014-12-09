using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FizzBuzz
    {
        private string _fizz ;
        private string _buzz;
        private int _minRange;
        private int _maxRange;
        public FizzBuzz(int minRange, int maxRange, string fizz, string buzz)
        {
            _minRange = minRange;
            _maxRange = maxRange;
            _fizz = fizz;
            _buzz = buzz;
        }

        public string PrintFizzBuzz(int minRange, int maxRange, string fizz, string buzz)
        {
            string output = string.Empty;
            for (int i = minRange; i <= maxRange; i++)
            {
                output = i.ToString();
                if (i % 3 == 0) output += " " + fizz;
                if (i % 5 == 0) output += " " + buzz ;
                output += "\n";
            }
            return output;
        }
        public string PrintFizzBuzz()
        {
            string output = string.Empty;
            for (int i = _minRange; i <= _maxRange; i++)
            {
                output += i.ToString();
                if (i % 3 == 0) output += " " + _fizz;
                if (i % 5 == 0) output += " " + _buzz ; 
                output += "\n";
            }
            return output;
        }
    }

   
}
