using System;
using System.Collections.Generic;

namespace FooBarGenerator
{
    public class FooBarGenerator
    {
        public void GenerateQuestion1(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                    Console.Write("foobar");
                else if (x % 3 == 0)
                    Console.Write("foo");
                else if (x % 5 == 0)
                    Console.Write("bar");
                else
                    Console.Write(x);

                if (x < n)
                    Console.Write(", ");
            }
        }

        public void GenerateQuestion2(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                string result = "";

                if (x % 3 == 0)
                    result += "foo";

                if (x % 5 == 0)
                    result += "bar";

                if (x % 7 == 0)
                    result += "jazz";

                if (string.IsNullOrEmpty(result))
                    result = x.ToString();

                Console.Write(result);

                if (x < n)
                    Console.Write(", ");
            }
        }

        public void GenerateQuestion3(int n)
        {
            var rules = new Dictionary<int, string>
            {
                { 3, "foo" },
                { 4, "baz" },
                { 5, "bar" },
                { 7, "jazz" },
                { 9, "huzz" }
            };

            for (int x = 1; x <= n; x++)
            {
                string result = "";

                foreach (var rule in rules)
                {
                    if (x % rule.Key == 0)
                        result += rule.Value;
                }

                if (string.IsNullOrEmpty(result))
                    result = x.ToString();

                Console.Write(result);

                if (x < n)
                    Console.Write(", ");
            }
        }
    }
}