using System;
using System.Collections;
class PrimeNum
{
    static ArrayList al = new ArrayList();
    public void toPrimeNum(int n)
    {
        int lastnum = 0;
        ArrayList al = new ArrayList();
       for(int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                al.Add(i);
                n /= i;
            }
        }
        if (n != 1)
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
