using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M3
{
    public class ParamsExample
    {
        static void Main(string[] args) {


            string fromArray = GetVowels(["apple", "banana", "pear"]);
            Console.WriteLine($"Vowels from collection expression: '{fromArray}'");

            string fromMultipleArguments = GetVowels("apple", "banana", "pear");
            Console.WriteLine($"Vowels from multiple arguments: '{fromMultipleArguments}'");

            string fromNull = GetVowels(null);
            Console.WriteLine($"Vowels from null: '{fromNull}'");

            string fromNoValue = GetVowels();
            Console.WriteLine($"Vowels from no value: '{fromNoValue}'");
        }
        static string GetVowels(params IEnumerable<string>? input)
        {
            if (input == null || !input.Any())
            {
                return string.Empty;
            }

            char[] vowels = ['A', 'E', 'I', 'O', 'U'];
            return string.Concat(
                input.SelectMany(
                    word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }
    }
}
