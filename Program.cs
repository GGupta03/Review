using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Enter the Array Size:");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the array elements:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int CountODD = 0;
        int CountEven = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                CountEven++;
            }
            else
            {
                CountODD++;
            }
        }
        Console.WriteLine("Number of Even elements:" + CountEven);
        Console.WriteLine("Number of Odd elements:" + CountODD);
    }
}

