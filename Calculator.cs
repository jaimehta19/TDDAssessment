using System;
using System.Collections.Generic;
using System.Linq;

public class Calculator
{
    public static int Add(string numbers)
    {
        // Check if the input string is empty or null
        if (string.IsNullOrEmpty(numbers))
            return 0;

        // Default delimiters
        char[] delimiters = { ',', '\n' };

        if (numbers.StartsWith("//"))
        {
            var delimiterIndex = numbers.IndexOf('\n');
            delimiters = new[] { numbers[2] };
            numbers = numbers.Substring(delimiterIndex + 1);
        }

        // Split the numbers using delimiters
        var numArray = numbers.Split(delimiters);

        var sum = 0;
        var negativeNumbers = new List<int>();
        foreach (var numStr in numArray)
        {
            var num = int.Parse(numStr);
            if (num < 0)
                negativeNumbers.Add(num);
            sum += num;
        }
        // Check for negative numbers
        if (negativeNumbers.Any())
        {
            throw new ArgumentException($"Negative numbers not allowed: {string.Join(", ", negativeNumbers)}");
        }

        return sum;
    }
}
