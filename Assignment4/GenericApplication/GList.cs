﻿using System;

//链表节点类
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }
    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
//泛型链表实现类
public class GenericList<T>
{
    private Node<T> head;//头结点
    private Node<T> tail;//尾节点
    public static int sum = 0;
    public GenericList()
    {
        tail = head = null;
    }
    public Node<T> Head
    {
        get => head;//Lambda表达式
    }
    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }
   public void myForEach(Action<T> action)
    {
        Node<T> t = head;
        while (t != tail)
        {
            action(t.Data);
            t = t.Next;
        }
        action(t.Data);
    }
    //*************************************for dalegate
    public void fun1(int x)//求和
    {
        sum += x;
    }

}

public delegate void myDelegate(int s);
public class Demo
{
    
    
    
    static void Main()
    {
        GenericList<int> g1 = new GenericList<int>();
        Random rd= new Random();
        for(int i = 0; i < 5; i++)
        {
            g1.Add(rd.Next(0,30));
        }
        g1.myForEach(s => Console.WriteLine(s));//循环输出链表元素
        //输出求和
        int sum = 0;
        g1.myForEach(s => sum += s);
        {
            Console.WriteLine("sum=" + sum);
        }
        //输出最小值
        int min = g1.Head.Data;
        g1.myForEach(s => { min = Math.Min(min, s); });
        {
            Console.WriteLine("min=" + min);
        }
        //输出最大值
        int max = g1.Head.Data;
        g1.myForEach(s => { max = Math.Max(max, s); });
        {
            Console.WriteLine("max=" + max);
        }

        //*****************************************
        //委托作为参数
        Console.WriteLine("委托作为函数参数求链表各项之和：");
        Action<int> md1 = g1.fun1;
        g1.myForEach(md1);
        Console.WriteLine("the sum=" + GenericList<int>.sum);
    }
}



