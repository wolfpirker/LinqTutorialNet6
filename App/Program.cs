// See https://aka.ms/new-console-template for more information
using static Exercises.PrependAppend;



//var result = AverageSnowFall(snowFallData);

// var numbers = new[] { 2, 2, 2, 5, 6, 6, 6, 7, 7, 7 };
//var numbers = new[] { 2, 5, 6, 6, 6, 7, 7, 7 };
var numbers = new int[] { };

var result = RemoveDuplicatesFromStartAndEnd(numbers);

Console.WriteLine($"Result is: {string.Join(", ", result)}");
