
using System;
public class Clock
{
    //定义两个事件，表示时间流逝和闹钟响起
    public event Action timeGoing;
    public event Action alarmGoing;
    //获取当前时间
    private int hour = DateTime.Now.Hour;
    private int minute = DateTime.Now.Minute;
    private int second = DateTime.Now.Second;
    public void start()
    {
        Console.WriteLine("the time is:" + hour + ":" + minute + ":" + second);
        while (true)
        {
            if (second % 10 == 0)
            {
                alarmGoing();
            }
            else
            {
                timeGoing();
            }
            //延迟一秒
            Thread.Sleep(1000);
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            //秒为整十的时候响起
            
        }
        
    }

    public Clock()
    {
        //多播委托-订阅事件
        timeGoing += timeGo;
        alarmGoing += alarm;
    }
    //事件的处理
    public void timeGo()
    {
        Console.Write("DiDa...");
    }
    public void alarm()
    {
        Console.WriteLine("Alarm!!!");
    }
}

//测试
public class Demo
{
    static void  Main()
    {
        Clock myclock = new Clock();
        myclock.start();
    }
}