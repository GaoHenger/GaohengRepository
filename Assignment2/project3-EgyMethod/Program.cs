﻿using System;
class EgMethod
{
    public void fun()
    {
        int[] arr = new int[99];//存放2~100
        for(int i = 0; i < 99; i++)//初始化
        {
            arr[i] = i + 2;
        }
        for(int i = 2; i < 50; i++)//n*n<arr.length
        {
            for(int j=0; j < 99; j++)
            {
                if (arr[j] % i == 0 && arr[j] / i != 1)
                {
                    arr[j] = 0;
                }
            }
        }
        for (int i = 0; i < 99; i++)//初始化
        {
            if (arr[i] != 0)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }
    static void Main()
    {
        EgMethod e = new EgMethod();
        e.fun();
    }
}