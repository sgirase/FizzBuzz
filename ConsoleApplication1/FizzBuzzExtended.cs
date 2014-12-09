using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FizzBuzzExtended
    {

        public static string PrintFizzBuzz(List<Tuple<int, string>> tupleList, int _minRange, int _maxRange)
        {
            string output = string.Empty;
            for (int i = _minRange; i <= _maxRange; i++)
            {
                output += i.ToString();
                foreach (Tuple<int, string> tuple in tupleList)
                {
                    if (i % tuple.Item1 == 0) output += " " + tuple.Item2;
                }
                output+="\n";
            }
            return output;
        }

    }
}
