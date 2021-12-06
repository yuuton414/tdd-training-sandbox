using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{
    public class FizzBuzz
    {
        public string convert(int v)
        {
            if (v % 3 == 0) return "Fizz";
            if (v % 5 == 0) return "Buzz";
            return v.ToString();
        }
    }
}
