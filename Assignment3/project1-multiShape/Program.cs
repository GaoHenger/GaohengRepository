using System;

//形状接口定义
interface IShape
{
    Boolean ifLegal();
    double getArea();
}
//长方形
class Rectangle:IShape
{
    private int width;
    private int length;
    public Rectangle(int w,int l)
    {
        width = w;
        length = l;
    }
    public virtual Boolean ifLegal()
    {
        return width > 0 && length > 0;
    }
    public virtual double getArea()
    {
        return width*length;
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
    public  Boolean ifLegal()
    {
        return sidth > 0;
    }
    public double getArea()
    {
        return sidth * sidth;
    }
}
//三角形
class Triangle:IShape
{
    private int sideOne, sideTwo, sideThree;
    public Triangle(int s1,int s2,int s3)
    {
        sideOne = s1;
        sideTwo = s2;
        sideThree = s3;
    }
    public Boolean ifLessThanAnother(int s1,int s2,int leastSide)
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
//主函数验证
class Demo
{
    static void Main()
    {
        Rectangle rec = new Rectangle(2, 4);
        Square sq = new Square(3);
        Triangle tri = new Triangle(3, 4, 5);
        Console.WriteLine("rec---getArea:" + rec.getArea() + " ifLegal:" + rec.ifLegal());
        Console.WriteLine("sq---getArea:" + sq.getArea() + " ifLegal:" + sq.ifLegal());
        Console.WriteLine("tri---getArea:" + tri.getArea() + " ifLegal:" + tri.ifLegal());
    }
}
