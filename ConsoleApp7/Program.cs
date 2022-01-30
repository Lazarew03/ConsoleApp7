using System;
using System.Collections.Generic;
using System.Linq;



class program
{

    static void Main(string[] args)
    {
        var arr = new[,]
        {
{1, 0, 0},
{0, 0, 0},
{0, 8, 0}
};

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == 0)
                    arr[i, j] = 1;
            }
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
