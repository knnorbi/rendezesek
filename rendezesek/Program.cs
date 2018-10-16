using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendezesek
{
    class Program
    {
        static int[] RandomTombLetrehoz(int n, int min, int max)
        {
            if (n < 1)
                return null;

            Random random = new Random();
            int[] tomb = new int[n];
            for (int i = 0; i < tomb.Length; i++)
                tomb[i] = random.Next(min, max);
            return tomb;
        }

        static void TombKiir(int[] tomb)
        {
            if (tomb == null)
            {
                Console.WriteLine("null tömböt kaptam!");
                return;
            }

            foreach (int elem in tomb)
                Console.Write(elem + " ");
            Console.Write("\n");
        }

        static void MinimumkivalasztasosRendezes(int[] T)
        {
            for (int i = 0; i < T.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < T.Length; j++)
                {
                    if (T[j] < T[min])
                        min = j;
                }
                int seged = T[i];
                T[i] = T[min];
                T[min] = seged;

            }
        }

        static void EgyszeruCseresRendezes(int[] T)
        {
            for (int i = 0; i < T.Length - 1; i++)
            {
                for (int j = i + 1; j < T.Length; j++)
                {
                    if (T[j] < T[i])
                    {
                        int seged = T[i];
                        T[i] = T[j];
                        T[j] = seged;
                    }
                }
            }
        }

        static void BuborekRendezes(int[] T)
        {
            int i = T.Length - 1;
            while (i > 0)
            {
                int idecsere = 0;
                for (int j = 0; j < i; j++)
                {
                    if (T[j] > T[j + 1])
                    {
                        int seged = T[j];
                        T[j] = T[j + 1];
                        T[j + 1] = seged;
                        idecsere = j;
                    }
                }
                i = idecsere;
            }
        }

        static void BeilleszteseRendezes(int[] T)
        {
            for (int i = 1; i < T.Length; i++)
            {
                int seged = T[i];
                int j = i - 1;
                while (j >= 0 && T[j] > seged)
                {
                    T[j + 1] = T[j];
                    j--;
                }
                T[j + 1] = seged;
            }
        }

        static void Main(string[] args)
        {
            int[] T1 = RandomTombLetrehoz(10, 1, 101);
            Console.WriteLine("Rendezettlen T1 tömb:");
            TombKiir(T1);
            MinimumkivalasztasosRendezes(T1);
            Console.WriteLine("T1 tömb rendezve:");
            TombKiir(T1);

            int[] T2 = RandomTombLetrehoz(10, 1, 101);
            Console.WriteLine("Rendezettlen T2 tömb:");
            TombKiir(T2);
            EgyszeruCseresRendezes(T2);
            Console.WriteLine("T1 tömb rendezve:");
            TombKiir(T2);

            int[] T3 = RandomTombLetrehoz(10, 1, 101);
            Console.WriteLine("Rendezettlen T3 tömb:");
            TombKiir(T3);
            BuborekRendezes(T3);
            Console.WriteLine("T3 tömb rendezve:");
            TombKiir(T3);

            int[] T4 = RandomTombLetrehoz(10, 1, 101);
            Console.WriteLine("Rendezettlen T4 tömb:");
            TombKiir(T4);
            BeilleszteseRendezes(T4);
            Console.WriteLine("T4 tömb rendezve:");
            TombKiir(T4);

            int[] T5 = RandomTombLetrehoz(10, 1, 101);
            Console.WriteLine("Rendezettlen T5 tömb:");
            TombKiir(T5);
            Array.Sort(T5);
            Console.WriteLine("T4 tömb rendezve:");
            TombKiir(T5);

            Console.ReadKey();
        }
    }
}
