using stack;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack
    {
        Object[] stack;
        Int32 i;
        Int32 j;


        public Stack(int n)
        {
            stack = new Object[n];
            i = 0;
            j = n;
        }


        public void Push(object item)
        {
            if (!isFull())
            {
                stack[i++] = item;
                Console.WriteLine("Added successful");
            }
            else
                Console.WriteLine("Stack is Full");
        }


        public bool isFull()
        {
            if (i == j)
                return true;
            else
                return false;
        }
        public bool isEmpty()
        {
            if (i == 0)
                return true;
            else
                return false;
        }


        public void Pop()
        {
            Console.WriteLine(i);

            if (i > 0)
            {
                Console.WriteLine(stack[--i]);
                stack[i] = null;
                i--;
            }
            else
            {
               Console.WriteLine( "nothing to pop");
            }
            //return stack[i];

        }
        public object Count(int n)
        {
            int cnt = 0 ;

            if (stack.Length != 0)
                for (int h = 0; h < n; h++)
                {
                    
                    if (stack[h] != null && stack[h].ToString() != "")
                    {
                        Console.WriteLine(stack[h]);
                        cnt++;
                    }
                }

            else
            {
                Console.WriteLine("Stack is empty");
            }

            return cnt;
        }
        public void Clear(int n)
        {
            if (i > 0)
            {


                int p = i;
            rem:

                stack[p] = null;
                if (p == 0)
                {
                    goto rem2;
                }
                p--;
                goto rem;

            }
            else
            {
                Console.WriteLine("Stack is empty"); goto rem3;
            }
            rem2:
            i = 0;
           
            Console.WriteLine("Clear stack successful");

        rem3:;
	

            

        }


        public object Peek()
        {
            if (i > 0 )
                return stack[i-1];
            return "Stack is empty";
        }
    }


}
class Program
    {

    static void Main(string[] args)
    {
        Console.WriteLine("Stack campacity:");
        int n;
        point1:
        bool chk = Int32.TryParse(Console.ReadLine(), out n);
        if (!chk)
        {
            Console.WriteLine("How do you thing, what's wrong...");
            goto point1;
        }
        Stack s = new Stack(n);
        point2:
        Console.WriteLine("Avaible commands: Push, Peek, Pop, Clear, Count, Exit");
        string inp = Console.ReadLine();
        if (inp=="push" || inp=="Push")
        {
            s.Push(Console.ReadLine());
        }
        if (inp == "peek" || inp == "Peek")
        {
            Console.WriteLine("Peek: {0}", s.Peek());
        }
        if (inp == "pop" || inp == "Pop")
        {
            s.Pop();
            Console.WriteLine("Pop: done!");
        }
        if (inp == "clear" || inp == "Clear")
        {
            s.Clear(n);
       
        }
        if (inp == "count" || inp == "Count")
        {
            Console.WriteLine("Count: {0}", s.Count(n));
            
            
        }
        if (inp == "exit" || inp == "Exit")
        {
            Console.Read();
            return;
        }
        goto point2;



       
    
    
    }
}
