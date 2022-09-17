string[] Filter(string[] array, int maxCountOfChars)
{
    string[] resArray = {};
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxCountOfChars)
        {
            Array.Resize(ref resArray, resArray.Length + 1);
            resArray[resArray.Length-1] = array[i];
        }
    }
    return resArray;
}

// Example
string[] array = {"Russia", "n", "OOOOOI", ":-)"};
var result = Filter(array, 3);
foreach (var item in result) Console.Write($"{item} ");

// Output: 
// n :-)