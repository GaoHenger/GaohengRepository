﻿using System;

class Judge
{
    public Boolean ifGoal(int[][]arr)
    {
        //try catch的使用
        if (arr.Length <= 1 || arr[0].Length <= 1)
        {
            Console.WriteLine("true");
            return true;
        }
        int[] arrt = arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            for(int j = 1; j < arr[i].Length; j++)
            {
                if (arr[i][j] != arrt[j - 1])
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            arrt = arr[i];
        }
        Console.WriteLine("true");
        return true;
    }

    static void Main()
    {
        Judge ju = new Judge();

        int[][] matrix1 = new int[][]
        { new int[]{ 1, 2 }, 
          new int[]{ 2,2} };

        int[][] matrix2 = new int[][]
        { new int[]{ 2, 1,3 },
          new int[]{ 2, 2,1  } 
        };

        ju.ifGoal(matrix1);
        ju.ifGoal(matrix2);
    }
}