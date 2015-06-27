using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3GenericList
{
    class GenericList<T> where T : IComparable
    {
        private const int count = 3;

        public T[] element;
        private int index = 0;
        public GenericList()
        {
            element = new T[count];
        }

        public void Add(T value)
        {
            if (index >= element.Length - 1)
            {
                Array.Resize<T>(ref element, index + 1);
            }
            this.element[index] = value;
            index++;
        }
        public T this[int i]
        {
            get { return element[i]; }
        }
        public void RemoveElement(int index)
        {
            if (index < element.Length)
            {
                Array.Clear(this.element, index, 1);
            }
        }
        public void InsertElement(int index, T value)
        {
            this.element[index] = value;
        }
        public void ClearList()
        {
            this.element = new T[] { };
        }
        public int FindingIndex(T value)
        {
            int index = Array.IndexOf(this.element, value);
            return index;
        }
        public void CheckingArrayContainValue(T value)
        {
            if (Array.IndexOf(element, value) >= 0)
            {
                Console.WriteLine("list contains a value \"{0}\"", value);
            }
            else
            {
                Console.WriteLine("The value cannot exist in list!");
            }
        }
        public T Min(T firstItem, T secondItem)
        {
            if (firstItem.CompareTo(secondItem) <= 0)
            {
                return firstItem;
            }
            else
            {
                return secondItem;
            }
        }
        public T Max(T firstItem, T secondItem)
        {
            if (firstItem.CompareTo(secondItem) >= 0)
            {
                return firstItem;
            }
            else
            {
                return secondItem;
            }
        }
        public override string ToString()
        {
            return String.Format("Array element: {0}", String.Join(", ", element));
        }
    }
}
