// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public static class ArrayUtils{
    
    public static double AverageZad5(int[] arr){
        int sum = 0;
        foreach (int number in arr)
        {
            sum += number;
        }
        return (double)sum / arr.Length;
    }

    public static int MaxValue(int[] arr){
        int max = arr[0];
        foreach (int number in arr){
            if (number > max){
                max = number;
            }
        }
        return max;
    }
}
Console.WriteLine("Hello");



Console.WriteLine("Hello2");
Console.WriteLine("Hello23");

Console.WriteLine("Hello23");
Console.WriteLine("Hello23");

Console.WriteLine("Hello23");