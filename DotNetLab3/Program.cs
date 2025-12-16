using System;
using System.Text;

namespace DotNetLab3
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Група ІПЗ-24-3(2), Виконав: Політун Владислав\n");
            string text = "programming";
            Console.WriteLine("Оригінал: " + text);
            Console.WriteLine("Інверсія: " + text.ReverseString());
            Console.WriteLine("Кількість 'm': " + text.CountChar('m'));

            Console.WriteLine();

            int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };
            Console.WriteLine("Кількість 2: " + numbers.CountOccurrences(2));

            int[] uniqueNumbers = numbers.UniqueElements();
            Console.WriteLine("Унікальні елементи:");
            foreach (var n in uniqueNumbers)
                Console.Write(n + " ");

            Console.WriteLine("\n");

            ExtendedDictionary<int, string, double> dict =
                new ExtendedDictionary<int, string, double>();

            dict.Add(1, "Apple", 10.5);
            dict.Add(2, "Banana", 7.3);
            dict.Add(3, "Orange", 12.0);

            Console.WriteLine("Кількість елементів: " + dict.Count);
            Console.WriteLine("Містить ключ 2: " + dict.ContainsKey(2));
            Console.WriteLine("Містить значення (Banana, 7.3): " +
                              dict.ContainsValue("Banana", 7.3));

            Console.WriteLine("\nЕлемент з ключем 1:");
            var elem = dict[1];
            Console.WriteLine($"{elem.Key} - {elem.Value1} - {elem.Value2}");

            Console.WriteLine("\nПеребір foreach:");
            foreach (var e in dict)
            {
                Console.WriteLine($"{e.Key}: {e.Value1}, {e.Value2}");
            }
        }
    }
}
