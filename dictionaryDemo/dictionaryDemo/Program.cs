using System;
using System.Collections.Generic;

namespace dictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> employeeAges = new Dictionary<string, int>
            {
                { "John", 30 },
                { "Sarah", 25 },
                { "Mike", 35 },
                { "Anna", 28 }
            };

            // 1. Add a new key-value pair
            employeeAges.Add("David", 40);
            PrintDictionary(employeeAges);

            // 2. Try to add an existing key 
            try
            {
                employeeAges.Add("John", 45);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error adding 'John': " + ex.Message);
            }

            // 3. Check if a key exists using ContainsKey
            Console.WriteLine("Contains 'Sarah': " + employeeAges.ContainsKey("Sarah"));

            // 4. Check if a value exists using ContainsValue
            Console.WriteLine("Contains value 35: " + employeeAges.ContainsValue(35));

            // 5. Access a value using an indexer
            Console.WriteLine("Age of Mike: " + employeeAges["Mike"]);

            // 6. Remove a key-value pair by key
            employeeAges.Remove("Anna");
            Console.WriteLine("After Remove('Anna'):");
            PrintDictionary(employeeAges);

            // 7. Clear all elements
            employeeAges.Clear();
            Console.WriteLine("After Clear():");
            PrintDictionary(employeeAges);

            // 8. Re-initialize the dictionary
            employeeAges = new Dictionary<string, int>
            {
                { "John", 30 },
                { "Sarah", 25 },
                { "Mike", 35 },
                { "Anna", 28 }
            };

            // 9. TryGetValue: Safely get a value for a key
            if (employeeAges.TryGetValue("Sarah", out int age))
            {
                Console.WriteLine("Sarah's age: " + age);
            }
            else
            {
                Console.WriteLine("Sarah not found!");
            }

            // 10. Iterate over the dictionary and print key-value pairs
            Console.WriteLine("Iterating over the dictionary:");
            foreach (var kvp in employeeAges)
            {
                Console.WriteLine(kvp.Key + " is " + kvp.Value + " years old.");
            }

            // 11. Get all keys
            Console.WriteLine("Keys in the dictionary:");
            foreach (var key in employeeAges.Keys)
            {
                Console.WriteLine(key);
            }

            // 12. Get all values
            Console.WriteLine("Values in the dictionary:");
            foreach (var value in employeeAges.Values)
            {
                Console.WriteLine(value);
            }

            // 13. Count: Get the number of key-value pairs in the dictionary
            Console.WriteLine("Number of elements in dictionary: " + employeeAges.Count);

            // 14. Check if dictionary is empty
            Console.WriteLine("Is dictionary empty? " + (employeeAges.Count == 0 ? "Yes" : "No"));
        }

        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            if (dictionary.Count == 0)
            {
                Console.WriteLine("Dictionary is empty.");
            }
            else
            {
                foreach (var emp in dictionary)
                {
                    Console.WriteLine(emp.Key + " is " + emp.Value + " years old.");
                }
            }
            Console.WriteLine();
        }
    }
}

