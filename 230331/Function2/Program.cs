int[] _array0 = new int[10];
int[] _array1 = new int[10];
int[] _array2 = new int[10];

_array0 = FillArray(_array0.Length);
_array1 = FillArray(_array1.Length);
_array2 = FillArray(_array2.Length);
Console.WriteLine(Join("|/|", _array0) + "The end =)");
Console.WriteLine(Join("|/|", _array1) + "The end =)");
Console.WriteLine(Join("|/|", _array2) + "The end =)");
Console.WriteLine("Сумма 1-ого массива " + ArraySum(_array0));
Console.WriteLine("Сумма 2-ого массива " + ArraySum(_array1));
Console.WriteLine("Сумма -3ого массива " + ArraySum(_array2));


Console.ReadLine();
//end program
int ArraySum(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        result += item;
    }
    return result;
}

int[] FillArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}


string Join(string separaor, int[] array)
{
    string result = "";
    foreach (int item in array)
    {
        result += item + separaor;
    }
    return result;
}