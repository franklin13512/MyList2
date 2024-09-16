using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class MyList1<T>
    {
        private T[] Data = new T[4];
        private int Count = 0;

        //访问动态数组容量
        public int Capacity
        {
            get { return Data.Length; }
        }

        //访问动态数组元素量
        public int Number
        {
            get { return Count; }
        }

        public void Add(int Index, T Value) 
        {
            if (Index < 0 || Index > Count ) 
            {
                throw new ArgumentOutOfRangeException("溢出");

            }
            else if (Count >= Data.Length)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                for (int i = Count - 1; Index <= i; i--)
                {
                    Data[i + 1] = Data[i];
                }
                Data[Index] = Value;
                Count++;

                if (Count == Data.Length)
                {
                    T[] NewList = new T[Data.Length * 2];

                    for (int i = 0; i < Data.Length; i++)
                    {
                        NewList[i] = Data[i];
                    }
                    Data = NewList;
                }
            }
        }

        public void AddAtLast(T Value)
        {
            Add(Count, Value);
        }

        public void AddAtFirst(T Value)
        {
            Add(0, Value);
        }


        public T this[int index]
        {
            get { return Data[index]; }
            set
            {
                Data[index] = value;
            }
        }
    }
}
