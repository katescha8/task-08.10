using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace ClassWork5
{
    class Program
    {
        static void Task_6_1()
        {
            string line;
            string str = "";
            int v, c;
            StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\Temp.txt");
            while ((line = sr.ReadLine()) != null)
            {
                str += line.ToString();
            }
            str = str.ToLower();
            char[] array = str.ToCharArray();
            Console.WriteLine(str);
            Count(array,out v,out c);
            Console.WriteLine($"Гласных-{v}, согласных-{c}");
        }
        static void Task_6_2()
        {
            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];
            Console.WriteLine("Первая матрица");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Введите элемент ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    array1[i, j] = a;
                }
            }
            Console.WriteLine("Вторая матрица");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Введите элемент ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    array2[i, j] = a;
                }
            }
            Print(array1);
            Print(array2);
            int[,] array3 = Multiplicat(array1, array2);
            Print(array3);
        }
        static void Task_6_3()
        {
            Generate(out int[,] m1);
            Generate(out int[,] m2);
            Generate(out int[,] m3);
            Generate(out int[,] m4);
            Generate(out int[,] m5);
            Generate(out int[,] m6);
            Generate(out int[,] m7);
            Generate(out int[,] m8);
            Generate(out int[,] m9);
            Generate(out int[,] m10);
            Generate(out int[,] m11);
            Generate(out int[,] m12);
            double atemp1 = AverageTemp(m1);
            double atemp2 = AverageTemp(m2);
            double atemp3 = AverageTemp(m3);
            double atemp4 = AverageTemp(m4);
            double atemp5 = AverageTemp(m5);
            double atemp6 = AverageTemp(m6);
            double atemp7 = AverageTemp(m7);
            double atemp8 = AverageTemp(m8);
            double atemp9 = AverageTemp(m9);
            double atemp10 = AverageTemp(m10);
            double atemp11 = AverageTemp(m11);
            double atemp12 = AverageTemp(m12);
            double[] temperature = { atemp1, atemp2, atemp3, atemp4, atemp5, atemp6, atemp7, atemp8, atemp9, atemp10, atemp11, atemp12 };
            QuickSort(temperature, 0, temperature.Length - 1);
            Cout(temperature);
        }
        static void Task_6__1()
        {
            string line;
            string str = "";
            int v, c;
            StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\Temp.txt");
            while ((line = sr.ReadLine()) != null)
            {
                str += line.ToString();
            }
            str = str.ToLower();
            char[] ch1 = str.ToCharArray();
            List<char> lst = new List<char>();
            for (int i = 0; i < ch1.Length; i++)
            {
                lst.Add(ch1[i]);
            }
            Count(lst, out v, out c);
            Console.WriteLine($"Гласных-{v}, согласных-{c}");
        }
        static void Task_6__2()
        {
            LinkedList<LinkedList<int>> llst1 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> llst2 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> llst3 = new LinkedList<LinkedList<int>>();
            Multi(llst1, llst2, ref llst3);
        }
        static void Task_6__3()
        {
            Dictionary<string, int[]> dict = new Dictionary<string, int[]>();
            Dictionary<string, double> dict1 = new Dictionary<string, double>();
            Generate(out int[] m1);
            dict.Add("jan", m1);
            Generate(out int[] m2);
            dict.Add("feb", m2);
            Generate(out int[] m3);
            dict.Add("march", m3);
            Generate(out int[] m4);
            dict.Add("apr", m4);
            Generate(out int[] m5);
            dict.Add("may", m5);
            Generate(out int[] m6);
            dict.Add("june", m6);
            Generate(out int[] m7);
            dict.Add("jule", m7);
            Generate(out int[] m8);
            dict.Add("aug", m8);
            Generate(out int[] m9);
            dict.Add("sept", m9);
            Generate(out int[] m10);
            dict.Add("oct", m10);
            Generate(out int[] m11);
            dict.Add("nov", m11);
            Generate(out int[] m12);
            dict.Add("dec", m12);
            dict1.Add("jan", AverageTemp(m1));
            dict1.Add("feb", AverageTemp(m2));
            dict1.Add("march", AverageTemp(m3));
            dict1.Add("apr", AverageTemp(m4));
            dict1.Add("may", AverageTemp(m5));
            dict1.Add("june", AverageTemp(m6));
            dict1.Add("jule", AverageTemp(m7));
            dict1.Add("aug", AverageTemp(m8));
            dict1.Add("sept", AverageTemp(m9));
            dict1.Add("oct", AverageTemp(m10));
            dict1.Add("nov", AverageTemp(m11));
            dict1.Add("dec", AverageTemp(m12));
            foreach (var d in dict1)
            {
                Console.WriteLine(d);
            }
        }
        static void Main(string[] args)
        {
            Task_6__3();
        }
        public static void Count(char[] array, out int v, out int c)
        {
            v = 0;
            c = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            for (int i = 0; i < array.Length; i++)
            {
               foreach (char ch in vowels)
                {
                    if (array[i] == ch)
                    {
                        v++;
                    }

                }
                foreach (char ch in consonants)
                {
                    if (array[i] == ch)
                    {
                        c++;
                    }

                }
            }

        }
        public static void Count(List<char> lst, out int v, out int c)
        {
            v = 0;
            c = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            for (int i = 0; i < lst.Count; i++)
            {
                foreach (char ch in vowels)
                {
                    if (lst[i].Equals(ch))
                    {
                        v++;
                    }
                }
             }
            for (int i = 0; i < lst.Count; i++)
            {
                foreach (char ch in consonants)
                {
                    if (lst[i].Equals(ch))
                    {
                        c++;
                    }
                }

            }
        }
        public static void Print(int[,] array)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
        public static int[,] Multiplicat(int[,] array1, int[,] array2)
        {
            int[,] array3 = new int[2,2];
            int k = 0;
            int l = 1;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array3[i, j] = array1[i, k]* array2[k,j]+ array1[i, l] * array2[l,j];
                }
            }
            return array3;
        }
        public static void Cout(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
                Console.Write(m[i]+ " ");
        }
        public static void Cout(double[] m)
        {
            for (int i = 0; i < m.Length; i++)
                Console.Write(m[i] + " ");
        }
        public static void Cout(int[,] m)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(m[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Generate(out int[,] m1)
        {
            Random r = new Random();
            int[,] m = { {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 },{ r.Next(-10, 30), r.Next(-10, 30), r.Next(-10, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30) } };
            m1 = m;
        }
        public static void Generate(out int[] m1)
        {
            Random r = new Random();
            int[] m = { r.Next(-10, 30), r.Next(-10, 30), r.Next(-10, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30) };
            m1 = m;
        }
        public static double AverageTemp(int[,] m)
        {
            double avertemp = 0;
            double sum=0;
            int i = 1;
                for (int j = 0; j < m.Length/2; j++)
                {
                    sum += m[i, j];
                }
            avertemp = Math.Round(sum/(m.Length/2),1);
            return avertemp;
        }
        public static double AverageTemp(int[] m)
        {
            double avertemp = 0;
            double sum = 0;
            for (int j = 0; j < m.Length / 2; j++)
            {
                sum += m[j];
            }
            avertemp = Math.Round(sum / (m.Length / 2), 1);
            return avertemp;
        }
        public static void QuickSort(double[] array, int first, int last)
        {
            if (first >= last)
            {
                return;
            }
            int var = fission(array, first, last);
            QuickSort(array, first, var - 1);
            QuickSort(array, var + 1, last);
        }
        public static int fission(double[] array, int start, int end)
        {
            double temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }
        public static void Multi(LinkedList<LinkedList<int>> l1, LinkedList<LinkedList<int>> l2, ref LinkedList<LinkedList<int>> l3)
        {
            LinkedList<int> lst1 = new LinkedList<int>();
            LinkedList<int> lst2 = new LinkedList<int>();
            LinkedList<int> lst3 = new LinkedList<int>();
            lst1.AddFirst(1);
            lst1.AddLast(2);
            lst1.AddLast(3);
            lst1.AddLast(4);
            lst2.AddFirst(5);
            lst2.AddLast(6);
            lst2.AddLast(7);
            lst2.AddLast(8);
            l1.AddFirst(lst1);
            l2.AddFirst(lst2);
            var a1 = lst1.First;
            var b1 = lst2.First;
            var a2 = a1.Next;
            var b2 = b1.Next;
            var a3 = a2.Next;
            var b3 = b2.Next;
            var a4 = a3.Next;
            var b4 = b3.Next;
            var c0 = a1.Value * b1.Value + a2.Value * b3.Value;
            var c1 = a1.Value * b2.Value + a2.Value * b4.Value;
            var c2 = a3.Value * b1.Value + a4.Value * b3.Value;
            var c3 = a3.Value * b2.Value + a4.Value * b4.Value;
            lst3.AddFirst(c0);
            lst3.AddLast(c1);
            lst3.AddLast(c2);
            lst3.AddLast(c3);
            l3.AddFirst(lst3);
            var item = lst3.First;
            int k = 0;
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Next;
                k++;
                if (k == 2)
                { Console.WriteLine(); }
            }
        }
    }
}
