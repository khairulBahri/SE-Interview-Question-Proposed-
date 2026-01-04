using System;

namespace FooBarGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SE Interview Question (Proposed) - FooBar Generator ===");
            Console.WriteLine("1. Soal 1 (Fixed rules: 3,5)");
            Console.WriteLine("2. Soal 2 (Fixed rules: 3,5,7)");
            Console.WriteLine("3. Soal 3 (Table rules)");
            Console.WriteLine("4. Soal 4 (Configurable API)");
            Console.Write("Pilih soal (1 - 4): ");

            string choice = Console.ReadLine();

            Console.Write("Masukkan nilai n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Input harus angka bulat positif.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.Write("Output: ");

            switch (choice)
            {
                case "1":
                case "2":
                case "3":
                    RunFixedGenerator(choice, n);
                    break;

                case "4":
                    RunApiGenerator(n);
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.ReadLine();
        }

        // soal 1 sampai 3
        static void RunFixedGenerator(string choice, int n)
        {
            var generator = new FooBarGenerator();

            switch (choice)
            {
                case "1":
                    generator.GenerateQuestion1(n);
                    break;
                case "2":
                    generator.GenerateQuestion2(n);
                    break;
                case "3":
                    generator.GenerateQuestion3(n);
                    break;
            }
        }

        // soal 4
        static void RunApiGenerator(int n)
        {
            var generator = new FooBarGeneratorApi();

            generator.AddRule(3, "foo");
            generator.AddRule(4, "baz");
            generator.AddRule(5, "bar");
            generator.AddRule(7, "jazz");
            generator.AddRule(9, "huzz");

            generator.Generate(n);
        }
    }
}
