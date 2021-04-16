using System;
using System.Diagnostics;
using System.ComponentModel;
public class Person : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public Person(string name)
    {
        Name = name;
    }
    private string _Name = string.Empty;
    public string Name
    {
        get { return _Name; }
        set
        {
            if (_Name != value)
            {
                _Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
    }
}

public class Stack<T>
{
    public void Add(T i)
    {
        Type t = typeof(T);
    }
}


public class Program
{
    static void Main()
    {
        ThreadPriorityLevel priority;
        priority = (ThreadPriorityLevel)Enum.Parse(typeof(ThreadPriorityLevel), "Idle");
        Console.WriteLine(priority);

        Console.WriteLine();

        DateTime dateTime = new DateTime();
        Type type = dateTime.GetType();
        foreach (System.Reflection.PropertyInfo property in type.GetProperties())
        { Console.WriteLine(property.Name); }

        Console.WriteLine();

        type = typeof(System.Nullable<>);
        Console.WriteLine(type.ContainsGenericParameters);
        Console.WriteLine(type.IsGenericType);
        type = typeof(System.Nullable<DateTime>);
        Console.WriteLine(type.ContainsGenericParameters);
        Console.WriteLine(type.IsGenericType);

        Console.WriteLine();

        Stack<string> s = new Stack<string>();

        Type t = s.GetType();

        foreach (Type type1 in t.GetGenericArguments())
        {
            Console.WriteLine("Type parameter: " + type1.FullName);
        }

        Console.WriteLine();

        Person billy = new Person("billy");

        Console.WriteLine(nameof(billy));
    }
}