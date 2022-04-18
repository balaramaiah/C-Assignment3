using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{

    internal class MyStack1
    {
        static readonly int MAX = 100;  //size of the array
        int top2;                        //integer var to store top position
        int[] st = new int[MAX]; //int array
        

        

        public void Push(int data)  //performing push operation
        {
            if (top2 > MAX)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                st[top2++] = data;
            }
        }
        public void Pop()  //performing pop operation
        {
            if (top2 < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                int value = st[top2--];
                Console.WriteLine("Popped Value: " + value);
            }
        }


    }


    class MyStack
    {
        static void Main(String[] args)
        {
            MyStack1 stack1 = new MyStack1();
            
            
                stack1.Push(10);
                stack1.Push(20);
                //stack1.Push(30);
                //stack1.Push(40);
                
               
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();//Stack Underflow

            Console.ReadKey();
            
           

        }
    }
}
