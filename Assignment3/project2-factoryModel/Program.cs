using System;

//形状接口定义
interface IShape
{
    Boolean ifLegal();
    double getArea();
}
//长方形
class Rectangle : IShape
{
    private int width;
    private int length;
    public Rectangle(int w, int l)
    {
        width = w;
        length = l;
    }
    public  Boolean ifLegal()
    {
        return width > 0 && length > 0;
    }
    public double getArea()
    {
        return width * length;
    }
}
//正方形
class Square : IShape
{
    private int sidth;
    public Square(int s)
    {
        sidth = s;
    }
    public Boolean ifLegal()
    {
        return sidth > 0;
    }
    public double getArea()
    {
        return sidth * sidth;
    }
}
//三角形
class Triangle :IShape
{
    private int sideOne, sideTwo, sideThree;
    public Triangle(int s1, int s2, int s3)
    {
        sideOne = s1;
        sideTwo = s2;
        sideThree = s3;
    }
    public Boolean ifLessThanAnother(int s1, int s2, int leastSide)
    {
        return Math.Abs(s1 - s2) < leastSide;
    }
    public Boolean ifLegal()
    {
        return (ifLessThanAnother(sideOne, sideTwo, sideThree) && ifLessThanAnother(sideOne, sideThree, sideTwo)
            && ifLessThanAnother(sideTwo, sideThree, sideOne));
    }
    public double getArea()
    {
        double p = (sideOne + sideTwo + sideThree) / 2;
        return Math.Sqrt(p * (p - sideOne) * (p - sideTwo) * (p - sideThree));
    }
}
class ShapeFactory
{
    public static IShape getShape(int num)
    {
        switch (num)
        {
            case 0:
                Console.WriteLine("rectangle");
                return new Rectangle(4,6);//创建的矩形长为6高为4；
            case 1:
                Console.WriteLine("square");
                return new Square(5);//创建的正方形边长为5
            case 2:
                Console.WriteLine("triangle");
                return new Triangle(3,4,5);//创建的三角形边长为3,4,5；
            default:
                return null;
        }
    }
}

class Demo
{
    static void Main()
    {
        double sumArea=0;
        for(int i = 0; i < 10; i++)
        {
            Random rd = new Random();
            int num = rd.Next();
            num = num % 3;
            IShape sh = ShapeFactory.getShape(num);
            sumArea += sh.getArea();
        }
        Console.WriteLine("the 10 shapes areas are:" + sumArea);
    }
}