using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    internal class Lifo
    {
        public List<int> stack;
        public Lifo()
        {
            stack = new List<int>();
        }
        public void Push(int value)
        {
            stack.Add(value);
        }
        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                stack.RemoveAt(stack.Count - 1);
            }
        }
        public int Get()
        {
            if (stack.Count == 0)
            {
                return -1;
            }
            else
            {
                int value = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return value;
            }
        }
    }
}
