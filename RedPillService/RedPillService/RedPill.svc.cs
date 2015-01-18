using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services;

namespace knockknock.readify.net
{
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        public Guid WhatIsYourToken()
        {
            //return Guid.Empty;
            return new Guid("6e3f314c-b738-4dbd-945b-a3fe5461cf7a");
        }

        public long FibonacciNumber(long n)
        {
            if (n > 92)
                throw new ArgumentOutOfRangeException("n", "Fib(>92) will cause a 64-bit integer overflow.");
            else if (n < -92)
                throw new ArgumentOutOfRangeException("n", "Fib(<-92) will cause a 64-bit integer overflow.");

            int sign = 1;
            long absoluteN = n;
            if (absoluteN < 0)
            {
                absoluteN *= -1;
                sign = (int)Math.Pow(-1, (absoluteN + 1));
            }

            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < absoluteN; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }

            FileLogger.Log("FibonacciNumber", n.ToString(), (sign * a).ToString());

            return sign * a;
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a >= ((long)b + (long)c) || b >= ((long)a + (long)c) || c >= ((long)a + (long)b) || a < 1 || b < 1 || c < 1)
            {
                FileLogger.Log("WhatShapeIsThis", (a.ToString() + "," + b.ToString() + "," + c.ToString()), TriangleType.Error.ToString());
                return TriangleType.Error;
            }

            if (a == b && b == c)
            {
                FileLogger.Log("WhatShapeIsThis", (a.ToString() + "," + b.ToString() + "," + c.ToString()), TriangleType.Equilateral.ToString());
                return TriangleType.Equilateral;
            }

            if (a == b || b == c || a == c)
            {
                FileLogger.Log("WhatShapeIsThis", (a.ToString() + "," + b.ToString() + "," + c.ToString()), TriangleType.Isosceles.ToString());
                return TriangleType.Isosceles;
            }

            FileLogger.Log("WhatShapeIsThis", (a.ToString() + "," + b.ToString() + "," + c.ToString()), TriangleType.Scalene.ToString());
            return TriangleType.Scalene;
        }

        public string ReverseWords(string s)
        {
            if (s == null) throw new ArgumentNullException("s", "Value cannot be null.");
            if (s == string.Empty) return string.Empty;

            string[] words = s.Split(' ');
            string reversedString = string.Empty;
            foreach (string word in words)
            {
                reversedString += (reversedString.Trim()==string.Empty && word.Length>0) ? string.Empty : " ";
                foreach (char c in word.ToCharArray().Reverse())
                {
                    reversedString += c;
                }
            }
            FileLogger.Log("ReverseWords", s.ToString(), reversedString);
            return reversedString;
        }
    }
}
