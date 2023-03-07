using System;

class Calculator
{
    static void Main()
    {
        int firstnum = 0, secondnum = 0, result = 0;
        Console.WriteLine("intput the first num:");
        firstnum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("intput the second num:");
        secondnum = Int32.Parse(Console.ReadLine());
        Console.WriteLine("intput the operator:");
        char ope = (char)Console.Read();
        switch (ope)
        {
            case '+':
                result = firstnum + secondnum;
                break;
            case '-':
                result = firstnum - secondnum;
                break;
            case '*':
                result = firstnum * secondnum;
                break;
            case '/':
                result = firstnum / secondnum;
                break;
            default:
                Console.WriteLine("OUT OF RANGE!");
                break;
        }
        Console.WriteLine("The resault is:" + result);
    }
}
