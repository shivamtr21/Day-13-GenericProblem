using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    public class FindMax3<T> where T : IComparable
    {
        private T[] values;

        public FindMax3(params T[] values)
        {
            this.values = values;
        }

        public T MaximumNum()
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }

        public void PrintMax()
        {
            T max = MaximumNum();
            Console.WriteLine("Maximum value is: " + max);
        }

        public T TestMaximum()
        {
            T max = MaximumNum();
            return max;
        }
    }
}
