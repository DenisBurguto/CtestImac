

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
/*
// sum of negative numbers in array
int CountSumOfNEG(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] <0) sum += array[i];
    return sum;
}
*/
//check if number present in array
/*
bool IfInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == num) return true;
    return false;
}

*/
//count the numbers in range (A , B)

int CountInRange(int[] array, int a, int b)
{
    int temp;
    if (a > b)
    {
        temp = a;
        a = b;
        b = temp;
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= a && array[i] <= b) count++;
    return count;

}

Console.Write("Please input array length ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array minValue ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input array maxValue ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length, minValue, maxValue);
ArrayToConsole(newArray);

/*

int res = CountSumOfNEG(newArray);
Console.WriteLine($"The sum of all negative numbers  in array is {res} ");
*/
/*
Console.Write("Please input number to check ");
int num = Convert.ToInt32(Console.ReadLine());

if (IfInArray(newArray, num)) Console.WriteLine("The entered number presents in array");
else Console.WriteLine("There is no sush number in array");
*/


Console.Write("Please input range start ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input range end ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The quantity of numbers in range[a,b] is {CountInRange(newArray, a, b)}");
