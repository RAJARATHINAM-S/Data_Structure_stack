using System;

namespace Data_Structure_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList data = new LinkedList();
            data.Push(70);
            data.Push(30);
            data.Push(56);
           // data.Display();
           // data.InsertAtParticularPosition(1, 50);
            data.Peek();
           // data.Push(90);
           
            data.Pop();
            data.Display();
            Console.WriteLine("Hello World!");
        }
    }
}
