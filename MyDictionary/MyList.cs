using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyList()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {

            TKey[] tempKey = keys;
            keys = new TKey[keys.Length + 1];
            TValue[] tempValue = values;
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            for (int j = 0; j < keys.Length; j++)
            {
                if (key == null)
                {
                    throw new NotImplementedException();
                    Console.WriteLine("Key won't be null");
                }
                else
                {

                }
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Count
        {
            get { return keys.Length; }

        }

        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }

    }
}

