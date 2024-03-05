using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int> { 4, 1, 3, 2, 9, 8, 7, 5, 6, 3, 1, 5 };

        
        var distinctOdds = numbers.Where(x => x % 2 != 0) // Вибираємо непарні числа
                                   .GroupBy(x => x)        // Групуємо їх по значенню
                                   .Select(g => g.First()) // Беремо перший елемент з кожної групи
                                   .ToList();              // Конвертуємо у список


        Console.WriteLine("Всі непарні числа, з видаленням дублікатів:");
        distinctOdds.ForEach(Console.WriteLine);
    }
}
