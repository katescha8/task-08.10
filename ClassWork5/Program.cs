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
            Generate(out int[] m1);
            Generate(out int[] m2);
            Generate(out int[] m3);
            Generate(out int[] m4);
            Generate(out int[] m5);
            Generate(out int[] m6);
            Generate(out int[] m7);
            Generate(out int[] m8);
            Generate(out int[] m9);
            Generate(out int[] m10);
            Generate(out int[] m11);
            Generate(out int[] m12);
        }
        static void Task_6__1()
        {

        }
        static void Task_6__2()
        {

        }
        static void Task_6__3()
        {

        }
        static void Main(string[] args)
        {
            Task_6_3();
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
        public static void Generate(out int[] m1)
        {
            Random r = new Random();
            int[] m = { r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30), r.Next(12, 30) };
            m1 = m;
        }
    }
}
