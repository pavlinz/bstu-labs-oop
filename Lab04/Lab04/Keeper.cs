using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public static class Keeper
    {
        static Stack<double> memory = new Stack<double>();

        public static void AddValue(double value)
        {
            memory.Push(value);
        }

        public static double TakeValue()
        {
            if (memory.Count != 0)
                return memory.Pop();
            else
                return 0;
        }

        public static void ClearMemory()
        {
            memory.Clear();
        }
    }
}
