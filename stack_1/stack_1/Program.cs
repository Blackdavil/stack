using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_1
{
    public class Stack
    {
        string[] stack;
        Int32 i = 0;
        Int32 j;

        public Stack(int n)
        {
            stack = new string[n];
            j = n;
        }

        public bool isFull()
        {
            if (i == j)
            {
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            if (i == 0 && stack[i] == null)
            {
                return true;
            }
            return false;
        }
        public void Push(string upload)
        {
            if (!isFull())
            {
                stack[i] = upload;
                Console.WriteLine("{0} Added successfuly", upload);
                if (i < j)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("stack is full");
                }

            }
            else
            {
                Console.WriteLine("stack is full");
            }
        }
        public string Peek()
        {
            if (i <= j && !isEmpty())
            {
                if (i == 0 && stack[i] != null)
                {
                    Console.WriteLine("Peeked {0}", stack[i]);
                    return stack[i];
                }
                else
                {
                    Console.WriteLine("Peeked {0}", stack[i - 1]);
                    return stack[i - 1];

                }

            }
            return "Stack is Empty";
        }
        public void Clear()
        {
            for (int k = 0; k < i; k++)
            {
                stack[k] = null;
            }
            i = 0;
            Console.WriteLine("Stack is Empty");
        }
        public int Count()
        {
            int temp = 0;
            for (int k = 0; k < i; k++)
            {
                if (stack[k] != null)
                {
                    temp++;
                }

            }
            if (temp == 0)
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            Console.WriteLine("{0} objects in stack", temp);
            return temp;
        }

        public void Pop()
        {
            int s = 0;
            int chk = 0;
            if (!isEmpty())
            {
                if (i == j)
                {
                    i = i - 1;
                    s = 1;

                }

                if (stack[i] == null)
                {
                    if (s < 1)
                    {
                        i = i - 1;

                    }
                    else
                    {
                        s = 0;
                        chk = 1;
                    }

                }
                stack[i] = null;

                if (i > 0 && chk == 1)
                {
                    i = i - 1;
                    chk = 0;
                }


            }
            else
            {
                Console.WriteLine("stack is Empty");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //enter
            q:
            Console.WriteLine("введите длину стека");
            bool b = Int32.TryParse(Console.ReadLine(), out int campacity);
            if (!b)
            {
                goto q;
            }
            if (campacity <= 0)
            {
                goto q;
            }
            Stack s = new Stack(campacity);
            Console.WriteLine("Длинна стека {0}", campacity.ToString());

            //programm
            programm:
            Console.WriteLine("Push, Peek, Pop, Clear, Count, isEmpty, Exit");
            string inp = Console.ReadLine().ToString();

            //push/////////////////////////////////////////////////////////////////
            if (inp == "Push" || inp == "PUSH" || inp == "push")
            {
                s.Push(Console.ReadLine());
            }
            //push/////////////////////////////////////////////////////////////////


            //peek
            if (inp == "Peek" || inp == "PEEK" || inp == "peek")
            {
                Console.WriteLine("Peek: {0}", s.Peek());
            }


            //pop
            if (inp == "Pop" || inp == "POP" || inp == "pop")
            {

                s.Pop();
            }

            if (inp == "Clear" || inp == "CLEAR" || inp == "clear")
            {

                s.Clear();
            }
            if (inp == "Count" || inp == "COUNT" || inp == "count")
            {
                s.Count();

            }
            if (inp == "isEmpty")
            {
                Console.WriteLine(s.isEmpty());

            }



            //exit/////////////////////////////////////////////////////////////////
            if (inp == "Exit" || inp == "EXIT" || inp == "exit")
            {

                return;
            }
            ///////////////////////////////////////////////////////////////////////



            goto programm;

        }
    }
}
