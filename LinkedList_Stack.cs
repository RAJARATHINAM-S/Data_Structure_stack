using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class LinkedList_Stack
    {
        private Node top;


        public LinkedList_Stack()


        {


            this.top = null;


        }







        //30


        internal void Add(int value)


        {


            Node node = new Node(value);


            if (this.top == null)


                node.next = null;


            else


                node.next = this.top;


            this.top = node;


            Console.WriteLine("{0} pushed to stack ", value);


        }


        public void Display()


        {


            Node temp = this.top;


            while (temp != null)


            {


                Console.Write(temp.data + " ");


                temp = temp.next;//1400


            }


        }







        internal void Peek()


        {


            if (this.top == null)


            {


                Console.WriteLine("Stack is empty");


                return;


            }


            Console.WriteLine("{0} is in the top of the stack ", this.top.data);


        }







        internal void Pop()


        {


            if (this.top == null)


            {


                Console.WriteLine("Stack is empty, Deletion is not possible");


                return;


            }


            Console.WriteLine("Value popped is {0} ", this.top.data);


            this.top = this.top.next;


        }










    }






}

