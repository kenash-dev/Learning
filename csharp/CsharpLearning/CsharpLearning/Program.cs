// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var value = 153;

var nameList = value.ToString().ToCharArray();
var valueString = value.ToString();
var sumvalue =  valueString.Sum(x => Math.Pow(int.Parse(x.ToString()), valueString.Length));
Console.WriteLine(sumvalue);
var count = nameList.Length;

double sum = 0;

foreach (var num in nameList)
{
    var digit = int.Parse(num.ToString());
    int digitSum = digit;
    for (int i = 0; i < count-1; i++)
    {
        Console.WriteLine("digitSum before {0}",digitSum);
        digitSum *= digit;
        Console.WriteLine("digitSum after {0}", digitSum);
    }

    sum += digitSum;
}

valueString.Select(x => Int64.Parse(x.ToString())).ToList();
var finalSum = (int)sum;
Console.WriteLine(finalSum == value);