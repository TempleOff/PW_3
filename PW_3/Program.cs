using System;
namespace PW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int[] Array1 = { 1, 2, 3, 4, 5 };
                int Source = 0;
                int First = Array1[0];
                for (int i = 0; i < Array1.Length; i++)
                {
                    if (First > Math.Abs(Array1[i]))
                    {
                        Source++;
                    }
                }
                Console.WriteLine(Source);

               
                int[] Array2 = { 1, 1, 2, 3, 3, 4, 5, 5 };
                for (int i = 0; i < Array2.Length; i++)
                {
                    for (int j = i + 1; j < Array2.Length; j++)
                    {
                        if (Array2[i] == Array2[j])
                        {
                            Array.Clear(Array2, i, 1);
                            Array.Clear(Array2, j, 1);
                        }
                    }
                }
                foreach (int i in Array2)
                {
                    if (i != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();

                
                int[] Array3 = new int[20];
                Random random = new Random();
                for (int i = 0; i < Array3.Length; i++)
                {
                    Array3[i] = random.Next(-50, 50);
                }
                foreach (int i in Array3)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (int i in Array3)
                {
                    if (0 <= i)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
