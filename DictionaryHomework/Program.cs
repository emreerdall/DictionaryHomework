using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class MyDict<K, V>
    {
        public K[] keys;
        public V[] values;

        public MyDict()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = keys;
            V[] tempValue = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;

        }
        public int Count
        {
            get { return keys.Length; }
        }

        public V key(K val)
        {
            int a;
            for (a = 0; a < keys.Length; a++)
            {
                if (Convert.ToString(keys[a]) == Convert.ToString(val))
                {
                    break;
                }
            }
            return values[a];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n*************** My Dictionary ***************");

            MyDict<string, int> student = new MyDict<string, int>();
            student.Add("Emre", 85);
            student.Add("Hasan", 90);
            student.Add("Ayşe", 70);
            Console.WriteLine($"{student.Count} adet öğrenci kaydı vardır.");

            Console.Write("Öğrenci Adını Giriniz: ");
            string name = Console.ReadLine();

            try
            {
                Console.WriteLine($"Öğrencinin aldığı not {student.key(name)}");
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }

            Console.ReadKey();
        }
    }
}
