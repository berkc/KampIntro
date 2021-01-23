using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,T1>
    {
        T[] Key;
        T1[] Value;

        public MyDictionary()
        {
            Key = new T[0];
            Value = new T1[0];
        }
        public void Add(T key,T1 value)
        {
            T[] tempKey = Key;
            T1[] tempValue = Value;

            Key = new T[Key.Length+1];
            Value = new T1[Value.Length+1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Key[i] = tempKey[i];
                Value[i] = tempValue[i];
            }
            Key[Key.Length - 1]=key;
            Value[Value.Length - 1] = value;
        }
        public int Count 
        {
            get { return Key.Length; } 
        }



    }
}
