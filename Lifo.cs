using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    internal class Lifo
    {
        public double[] stack;
        private int size = 100;
        private int index = 0;
        public Lifo()
        {
            stack = new double[100];
            for (int i = 0; i < size; i++)
            {
                stack[i] = double.NaN;
            }
        }
        public Lifo(int size)
        {
            this.size = size;
            stack = new double[size];
            for (int i = 0; i < size; i++)
            {
                stack[i] = double.NaN;
            }
        }
        public void Push(double value)
        {
            stack[index] = value;
            index++;
        }
        public double? Pop()
        {
            if (index == 0 && stack[index] != double.NaN)
            {
                return null;
            }
            else
            {
                double value = stack[index];
                stack[index] = double.NaN;
                index--;
                return value;
            }
        }
        public void Clear()
        {
            stack = new double[stack.Length];
        }
        public int GetLength()
        {
            return index;
        }
        public int GetSize()
        {
            return size;
        }
        public double[] GetAll()
        {
            double[] temp = new double[index];
            for (int i = 0; i < index; i++)
            {
                temp[i] = stack[i];
            }
            return temp;
        }
        public void Reverse()
        {
            double[] temp = new double[index];
            int tempindex = 0;
            for (int i = index; i < 0; i--)
            {
                temp[tempindex] = stack[i];
                tempindex++;
            }
            stack = temp;
        }
    }
}
