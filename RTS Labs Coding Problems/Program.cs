using RTS_Labs_Coding_Problems;

Console.WriteLine("Please enter a list of comma separated numbers surrounded by brackets, and a comparison number separated by a comma.");

var aboveBelowInput = Console.ReadLine();


try
{
    var numberList = aboveBelowInput.Substring(aboveBelowInput.LastIndexOf('[') + 1, aboveBelowInput.LastIndexOf(']') - 1)
        .Replace(" ", "")
        .Split(',')
        .Select(x => int.Parse(x))
        .ToList();

    var comparisonNumber = int.Parse(aboveBelowInput.Split(',').Last());

    var result = Logic.aboveBelow(numberList, comparisonNumber);

    Console.WriteLine("above: " + result.Above.Count + " below: " + result.Below.Count);
}
catch (Exception ex)
{
    Console.WriteLine("Input data is not formatted corretly for above below test");
}

Console.WriteLine("Please input a string, and the amount you wish to shift the string right, separated by a comma.");

var stringRotationInput = Console.ReadLine();

try
{
    var shiftString = stringRotationInput.Split(',').First();
    var shiftNumber = int.Parse(stringRotationInput.Split(',').Last());

    Console.WriteLine(Logic.stringRotation(shiftString, shiftNumber));

}
catch (Exception ex)
{
    Console.WriteLine("Input data is not formatted corretly for string rotation test");
}