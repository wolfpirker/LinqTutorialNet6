// See https://aka.ms/new-console-template for more information
using static Exercises.Average;


var snowFallData = new SnowFallData()
{
    MonthlySnowFallDataItems = new List<MonthlySnowFallData>
    {

        new MonthlySnowFallData {SnowfallInCentimeters = 11},
        new MonthlySnowFallData {SnowfallInCentimeters = 22},
        new MonthlySnowFallData {SnowfallInCentimeters = 10},
        new MonthlySnowFallData {SnowfallInCentimeters = 9},
        new MonthlySnowFallData {SnowfallInCentimeters = 5},
        new MonthlySnowFallData {SnowfallInCentimeters = 0},
        new MonthlySnowFallData {SnowfallInCentimeters = 0},
        new MonthlySnowFallData {SnowfallInCentimeters = 1},
        new MonthlySnowFallData {SnowfallInCentimeters = 5},
        new MonthlySnowFallData {SnowfallInCentimeters = 18},
        new MonthlySnowFallData {SnowfallInCentimeters = 19},
        new MonthlySnowFallData {SnowfallInCentimeters = 32},
    }
};

var students = new List<Student>
            {
                new Student {Marks = new List<int> {4,5,5}},
                new Student {Marks = new List<int> {5,6,5}},
                new Student {Marks = new List<int> {4,4,5}},
            };

//var result = AverageSnowFall(snowFallData);
var result = MaxAverageOfMarks(students);

Console.WriteLine($"Average Mark of worst student result: {result}");
