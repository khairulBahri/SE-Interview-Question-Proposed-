using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarGenerator
{
    public class FooBarGeneratorApi
    {
        private readonly Dictionary<int, string> _rules;

        public FooBarGeneratorApi()
        {
            _rules = new Dictionary<int, string>();
        }

        public void AddRule(int input, string output)
        {
            if (input <= 0)
                throw new ArgumentException("Input must be greater than zero.");

            _rules[input] = output;
        }

        public void Generate(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                string result = "";

                foreach (var rule in _rules)
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
