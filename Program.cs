using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList_Stack demo = new LinkedList_Stack();
            demo.Add(70);
            demo.Add(30);
            demo.Add(56);

            demo.Peek();
           // demo.Pop();
            //demo.Pop();
            //demo.Pop();
            demo.Pop();

            demo.Display();
            Console.ReadLine();

            
        }
    }
}
