using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (perfect square): ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        
        int size = (int)Math.Sqrt(n);
        if (size * size != n)
        {
            Console.WriteLine("Invalid input! The number must be a perfect square.");
            return;
        }
        
        int[,] matrix = new int[size, size];
        int total = n;
        
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int k = i * size + j + 1;
                if (i == j || i + j == size - 1)
                {
                    matrix[i, j] = k;
                }
                else
                {
                    matrix[i, j] = total + 1 - k;
                }
            }
        }
        
        Console.WriteLine("Generated Matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
