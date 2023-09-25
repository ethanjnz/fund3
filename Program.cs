// See https://aka.ms/new-console-template for more information




// ITERATE AND PRINT VALUES
using System.ComponentModel.DataAnnotations;

static void PrintList(List<string> MyList)
{
    foreach (string name in MyList)
    {
        Console.WriteLine($"My name is {name}");
    }
}

List<string> TestStringList = new() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);
Console.WriteLine();


//PRINT SUM
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int num in IntList)
    {
        sum += num;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new() { 2, 7, 12, 9, 3 };
SumOfNumbers(TestIntList);
Console.WriteLine();


// FIND MAX
static int FindMax(List<int> IntList)
{
    int max = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }
    return max;
}
List<int> TestIntList2 = new() { -9, 12, 10, 3, 17, 5 };
Console.WriteLine(FindMax(TestIntList2));
Console.WriteLine();


//SQAURE THE VALUES
static List<int> SqaureValues(List<int> IntList)
{

    for (int i = 0; i < IntList.Count; i++)
    {
        int squared;
        squared = IntList[i] * IntList[i];
        IntList[i] = squared;
    }
    // displays each element in the IntList
    foreach (int num in IntList)
    {
        Console.WriteLine(num);
    }
    return IntList;
}
List<int> TestIntList3 = new() { 1, 2, 3, 4, 5 };
Console.WriteLine(SqaureValues(TestIntList3));
Console.WriteLine();

//REPLACE NEGATIVE NUMBERS WITH 0
static int[] NonNegatives(int[] Intarray)
{
    for (int i = 0; i < Intarray.Length; i++)
    {
        if (Intarray[i] < 0)
        {
            Intarray[i] = 0;
        }
    }
    // displays each element in the IntList
    foreach (int num in Intarray)
    {
        Console.WriteLine(num);
    }
    return Intarray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
Console.WriteLine(NonNegatives(TestIntArray));
Console.WriteLine();


//PRINT DICTIONARY
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"My {entry.Key} is {entry.Value}");
    }
}
Dictionary<string, string> TestDict = new()
{
    { "HeroName", "Iron Man" },
    { "RealName", "Tony Stark" },
    { "Powers", "Money and Intelligence" }
};
PrintDictionary(TestDict);
Console.WriteLine();


//FIND KEY
static bool FindKey(Dictionary<string, string> MyDictionary, string Searchterm)
{
    if (MyDictionary.ContainsKey(Searchterm))
    {
        return true;
    }
    return false;
}
Console.WriteLine(FindKey(TestDict, "RealName"));
Console.WriteLine(FindKey(TestDict, "Name"));
Console.WriteLine();


//GENERATE A DICTIONARY
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> Result = new();
    for (int i = 0; i < Names.Count; i++)
    {
        Result.Add(Names[i], Numbers[i]);
    }
    foreach (KeyValuePair<string, int> entry in Result)
    {
        Console.WriteLine($"{entry.Key}, {entry.Value}");
    }
    return Result;
}
List<string> Names = new() { "Julie", "Harold", "James", "Monica" };
List<int> Numbers = new() { 6, 12, 7, 10 };
GenerateDictionary(Names, Numbers);
