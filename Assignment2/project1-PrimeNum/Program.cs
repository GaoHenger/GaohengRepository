using System;
using System.Collections;
class PrimeNum
{
    static ArrayList al = new ArrayList();
    public void toPrimeNum(int n)
    {
        int lastnum = 0;
        ArrayList al = new ArrayList();
        if (n % 2 == 0)  //除去2因数，结果为奇数，且因数都为偶数
        {
            al.Add(2);
        }
        while (n % 2 == 0)
        {
            n /= 2;
        }
        for (int i = 3; i <= System.Math.Sqrt(n); i += 2)//跳过偶数
        {
            if (n % i == 0)
            {
                al.Add(i);
                n /= i;
            }
            lastnum = i;
        }
        if (n > lastnum)
        {
            al.Add(n);
        }
        foreach (int i in al)
        {
            Console.Write(i + "  ");
        }
    }
    static void Main()
    {
        Console.WriteLine("Plase input the number:");
        int n = Convert.ToInt32(Console.ReadLine());
        PrimeNum pr = new PrimeNum();
        pr.toPrimeNum(n);

    }
}
