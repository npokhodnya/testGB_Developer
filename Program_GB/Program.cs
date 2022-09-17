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
string[] array2 = {"Russia", "n", "OOOOOI", ":-)"};
var result2 = Filter(array2, 3);
foreach (var item in result2) Console.Write($"{item} ");

// Output: 
// n :-)