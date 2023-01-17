int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ArrayToConsole(int[] array)
{
    Console.Write("Your array is [");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}
int CountSumOfNEG(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] <0) sum += array[i];
    return sum;
}
Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length, minValue, maxValue);
ArrayToConsole(newArray);
int res = CountSumOfNEG(newArray);
Console.WriteLine($"The sum of all negative numbers  in array is {res} ");