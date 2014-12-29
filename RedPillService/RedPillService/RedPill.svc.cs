using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services;

namespace WalidAly
{
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            return Guid.Empty;
            //return new Guid("6e3f314c-b738-4dbd-945b-a3fe5461cf7a");
        }

        public long FibonacciNumber(long n)
        {
            if (n > 92)
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            else if (n < -92)
                throw new ArgumentOutOfRangeException("n", "Fib(<-92) will cause a 64-bit integer overflow.");

            int sign = 1;
            if (n < 0)
            {
                n *= -1;
                sign = (int)Math.Pow(-1, (n + 1));
            }

            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return sign * a;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a >= (b + c) || b >= (a + c) || c >= (a + b) || a < 1 || b < 1 || c < 1)
            {
                return TriangleType.Error;
            }

            if (a == b && b == c)
            {
                return TriangleType.Equilateral;
            }

            if (a == b || b == c || a == c)
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            if (s == null) throw new ArgumentNullException("s", "Value cannot be null.");

            string[] words = Regex.Split(s, " ");
            string reversedString = string.Empty;
            foreach (string word in words)
            {
                reversedString += (reversedString == string.Empty) ? string.Empty : " ";
                foreach (char c in word.ToCharArray().Reverse())
                {
                    reversedString += c;
                }
            }
            return reversedString;
        }
    }
}
