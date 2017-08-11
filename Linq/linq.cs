using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Csharp
{
    public class linqOperators
    {
        static string[] names = { "Tom", "Dick", "Hasrry" };
        IEnumerable<string> filteredNames = names.Where(n => n.Length >= 4);
        IEnumerable<string> filteredNames1 = names.Where(n => n.Contains("a"));

        //Query expression syntax
        IEnumerable<string> filteredNames2 = from n in names
                                             where n.Contains("a")
                                             select n;
        //Chaining Query Operators 
        IEnumerable<string> query = names
                            .Where(n => n.Contains("a"))
                            .OrderBy(n => n.Length)
                            .Select(n => n.ToUpper());

        //Take Operator: outputs the first x elements, discarding the rest:
        static int[] numbers = { 10, 9, 8, 7, 6 };
        IEnumerable<int> firstThree = numbers.Take(3); // {10,9,8}

        //Skip Operator: ignores the first x elements and outputs the rest
        IEnumerable<int> lastTwo = numbers.Skip(3);    // {7,6}

        //Reverse Operator:
        IEnumerable<int> reversed = numbers.Reverse(); // {6, 7, 8, 9, 10}

        //First , Last and other Operators:
        int firstNumber = numbers.First();
        int lastNumber = numbers.Last();
        int secondNumber = numbers.ElementAt(1);
        int secondLowest = numbers.OrderBy(n => n).Skip(1).First();

        //Aggregation operators:
        int count = numbers.Count();
        int min = numbers.Min();

        //Quantifiers:
        bool hasTheNumberNine = numbers.Contains(9);
        bool hasMoreThanZeroElements = numbers.Any();
        bool hasAnOddElement = numbers.Any(n => n % 2 != 0);


        //Query operators accept two input 
        static int[] seq1 = { 1, 2, 3 };
        static int[] seq2 = { 3, 4, 5 };
        IEnumerable<int> contact = seq1.Concat(seq2);    // {1,2,3,3,4,5}
        IEnumerable<int> union = seq1.Union(seq2);      // {1,2,3,4,5}

        //Mixed-Syntax Queries : The only restriction is that each query-syntax component must be complete (i.e., start with a from clause and end with a select or group clause). 
        static string[] friends = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        int matches = (from n in friends
                       where n.Contains("a")
                       select n).Count();

        string first = (from n in friends
                        orderby n
                        select n).First();

    

    }
}