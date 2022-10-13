using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ClassWork5
{
    class Program
    {
        public static void Task_1()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            Student s1 = new()
            { lname = "Аронов", fname = "Алексей", date = new DateTime(2004, 1, 1), exam = "Физика", scores = 79 };
            Student s2 = new()
            { lname = "Баронов", fname = "Николай", date = new DateTime(2004, 10, 14), exam = "Физика", scores = 81 };
            Student s3 = new()
            { lname = "Вечный", fname = "Андрей", date = new DateTime(2004, 7, 25), exam = "Информатика", scores = 82 };
            Student s4 = new()
            { lname = "Горелова", fname = "Мила", date = new DateTime(2004, 2, 7), exam = "Информатика", scores = 83 };
            Student s5 = new()
            { lname = "Дошина", fname = "Алёна", date = new DateTime(2004, 5, 13), exam = "Физика", scores = 84 };
            Student s6 = new()
            { lname = "Егорченко", fname = "Михаил", date = new DateTime(2004, 3, 26), exam = "Английский", scores = 87 };
            Student s7 = new()
            { lname = "Зубенко", fname = "Филипп", date = new DateTime(2003, 6, 9), exam = "Немецкий", scores = 89 };
            Student s8 = new()
            { lname = "Леонтьева", fname = "Варвара", date = new DateTime(2004, 2, 23), exam = "Физика", scores = 95 };
            Student s9 = new()
            { lname = "Мурин", fname = "Артём", date = new DateTime(2004, 7, 11), exam = "Французский", scores = 92 };
            Student s10 = new()
            { lname = "Султанбеков", fname = "Наиль", date = new DateTime(2003, 12, 31), exam = "Информатика", scores = 74 };
            students.Add(s1.lname, s1);
            students.Add(s2.lname, s2);
            students.Add(s3.lname, s3);
            students.Add(s4.lname, s4);
            students.Add(s5.lname, s5);
            students.Add(s6.lname, s6);
            students.Add(s7.lname, s7);
            students.Add(s8.lname, s8);
            students.Add(s9.lname, s9);
            students.Add(s10.lname, s10);
            foreach (var s0 in students)
            {
                Console.WriteLine(s0.Key + " " + s0.Value.scores);
            }
            Console.WriteLine("Меню: Новый студент, Удалить, Сортировать");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Новый студент":
                    Student s = new();
                    Console.Write("Введите фамилию ");
                    s.lname = Console.ReadLine();
                    Console.Write("Введите имя ");
                    s.fname = Console.ReadLine();
                    Console.Write("Введите дату рождения ");
                    s.date = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Введите сданный экзамен ");
                    s.exam = Console.ReadLine();
                    Console.Write("Введите баллы ");
                    s.scores = Convert.ToByte(Console.ReadLine());
                    students.Add(s.lname, s);
                    foreach (var s0 in students)
                    {
                        Console.WriteLine(s0.Key);
                    }
                    break;
                case "Удалить":
                    Console.Write("Введите фамилию студента ");
                    string lastn = Console.ReadLine();
                    if (students.ContainsKey(lastn))
                    {
                        students.Remove(lastn);
                    }
                    foreach (var s0 in students)
                    {
                        Console.WriteLine(s0.Value.lname);
                    }
                    break;
                case "Сортировать":
                    var sorted = students.OrderBy(x => x.Value.scores).ToDictionary(x => x.Key, x => x.Value.scores);
                    Console.WriteLine(String.Join("\n", sorted));
                    break;
            }

        }
        public static void Task_2()
        {
            List<byte> bbb = new List<byte>();
            List<byte> ss = new List<byte>();
            Console.WriteLine("Первая команда ");
            do
            {
                byte temp = 0;
                Console.Write("Введите цифру и нажмите любую клавишу для продолжнения(или дважды нажмите Enter, чтобы выйти) ");
                temp = Convert.ToByte(Console.ReadLine());
                bbb.Add(temp);
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            foreach (byte b in bbb)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine("\nВторая команда ");
            do
            {
                byte temp = 0;
                Console.Write("Введите цифру и нажмите любую клавишу для продолжнения(или дважды нажмите Enter, чтобы выйти) ");
                temp = Convert.ToByte(Console.ReadLine());
                ss.Add(temp);
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            foreach (byte s in ss)
            {
                Console.Write(s + " ");
            }
            Compare(bbb, ss);
        }
        public static void Task_3()
        {
            StreamReader sr1 = new StreamReader("C:\\Users\\admin\\Desktop\\Zhek1.txt");
            StreamReader sr2 = new StreamReader("C:\\Users\\admin\\Desktop\\Zhek2.txt");
            StreamReader sr3 = new StreamReader("C:\\Users\\admin\\Desktop\\Zhek3.txt");
            StreamReader sr4 = new StreamReader("C:\\Users\\admin\\Desktop\\Zhek4.txt");
            List<string> people1 = new List<string>();
            List<string> people2 = new List<string>();
            List<string> people3 = new List<string>();
            List<string> people4 = new List<string>();
            Stack<List<string>> zhek = new Stack<List<string>>();
            LinkedList<string> window1 = new LinkedList<string>();
            LinkedList<string> window2 = new LinkedList<string>();
            LinkedList<string> window3 = new LinkedList<string>();
            GetDossier(sr1, ref people1);
            GetDossier(sr2, ref people2);
            GetDossier(sr3, ref people3);
            GetDossier(sr4, ref people4);
            zhek.Push(people1);
            zhek.Push(people2);
            zhek.Push(people3);
            zhek.Push(people4);
            int i = zhek.Count;
            while (i > 0)
            {
                List<string> element1 = zhek.Pop();
                foreach (string s in element1)
                { Console.WriteLine(s); }
                i--;
            }
            while (i > 0)
            {
                List<string> element1 = zhek.Pop();
                if (element1.Contains("Проблема-2.оплата отопления"))
                {
                    string name = (element1.First()).Remove(0, 4);
                    byte scandal = Convert.ToByte((element1[element1.Count - 2].Remove(0, 14)));
                    byte mind = Convert.ToByte((element1[element1.Count - 1].Remove(0, 3)));
                    Console.WriteLine(name + ", вставайте в очередь во второе окно");
                    if (mind == 1)
                    {
                        if (scandal < 5)
                        { window2.AddLast(name); }
                        else
                        {
                            if (window2.Count > 0)
                            {
                                Console.Write(name + $", перед вами {window2.Count} человек. Сколько человек вы хотите обогнать? ");
                                byte temp = Convert.ToByte(Console.ReadLine());
                                if (temp < window2.Count)
                                { window2.AddBefore(window2.Last, name); }
                                else
                                { window2.AddFirst(name); }
                            }
                            else
                            { window2.AddLast(name); }
                        }
                    }
                    else
                    {
                        Random r = new Random();
                        int rnd = r.Next(0, 2);
                        if (rnd == 0)
                        {
                            if (scandal < 5)
                            { window1.AddLast(name); }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window1.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window1.Count)
                                    { window1.AddBefore(window1.Last, name); }
                                    else
                                    { window1.AddFirst(name); }
                                }
                                else
                                { window1.AddLast(name); }
                            }
                        }
                        else
                        {
                            if (scandal < 5)
                            { window3.AddLast(name); }
                            else
                            {
                                if (window3.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window3.Count)
                                    { window1.AddBefore(window3.Last, name); }
                                    else
                                    { window3.AddFirst(name); }
                                }
                                else
                                { window3.AddLast(name); }
                            }
                        }

                    }
                }
                else if (element1.Contains("Проблема-1.подключение отопления"))
                {
                    string name = (element1.First()).Remove(0, 4);
                    byte scandal = Convert.ToByte((element1[element1.Count - 2].Remove(0, 14)));
                    byte mind = Convert.ToByte((element1[element1.Count - 1].Remove(0, 3)));
                    Console.WriteLine(name + ", вставайте в очередь во первое окно");
                    if (mind == 1)
                    {
                        if (scandal < 5)
                        { window1.AddLast(name); }
                        else
                        {
                            if (window2.Count > 0)
                            {
                                Console.Write(name + $", перед вами {window1.Count} человек. Сколько человек вы хотите обогнать? ");
                                byte temp = Convert.ToByte(Console.ReadLine());
                                if (temp < window1.Count)
                                { window1.AddBefore(window1.Last, name); }
                                else
                                { window1.AddFirst(name); }
                            }
                            else
                            { window1.AddLast(name); }
                        }
                    }
                    else
                    {
                        Random r = new Random();
                        int rnd = r.Next(0, 2);
                        if (rnd == 0)
                        {
                            if (scandal < 5)
                            { window2.AddLast(name); }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window2.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window2.Count)
                                    { window2.AddBefore(window2.Last, name); }
                                    else
                                    { window2.AddFirst(name); }
                                }
                                else
                                { window2.AddLast(name); }
                            }
                        }
                        else
                        {
                            if (scandal < 5)
                            { window3.AddLast(name); }
                            else
                            {
                                if (window3.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window3.Count)
                                    { window1.AddBefore(window3.Last, name); }
                                    else
                                    { window3.AddFirst(name); }
                                }
                                else
                                { window3.AddLast(name); }
                            }
                        }
                    }
                }
                else
                {
                    string name = (element1.First()).Remove(0, 4);
                    byte scandal = Convert.ToByte((element1[element1.Count - 2].Remove(0, 14)));
                    Console.WriteLine(name + ", вставайте в очередь во третье окно");
                    byte mind = Convert.ToByte((element1[element1.Count - 1].Remove(0, 3)));
                    if (mind == 1)
                    {
                        if (scandal < 5)
                        { window3.AddLast(name); }
                        else
                        {
                            if (window3.Count > 0)
                            {
                                Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                byte temp = Convert.ToByte(Console.ReadLine());
                                if (temp < window3.Count)
                                { window1.AddBefore(window3.Last, name); }
                                else
                                { window3.AddFirst(name); }
                            }
                            else
                            { window3.AddLast(name); }
                        }
                    }
                    else
                    {
                        Random r = new Random();
                        int rnd = r.Next(0, 2);
                        if (rnd == 0)
                        {
                            if (scandal < 5)
                            { window2.AddLast(name); }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window2.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window2.Count)
                                    { window2.AddBefore(window2.Last, name); }
                                    else
                                    { window2.AddFirst(name); }
                                }
                                else
                                { window2.AddLast(name); }
                            }
                        }
                        else
                        {
                            if (scandal < 5)
                            { window1.AddLast(name); }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window1.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window1.Count)
                                    { window1.AddBefore(window1.Last, name); }
                                    else
                                    { window1.AddFirst(name); }
                                }
                                else
                                { window1.AddLast(name); }
                            }
                        }
                    }
                }
                i--;
            }
            Console.WriteLine("Очередь в первое окно:");
            foreach (string w in window1)
            { Console.WriteLine(w); }
            Console.WriteLine("Очередь во второе окно:");
            foreach (string w in window2)
            { Console.WriteLine(w); }
            Console.WriteLine("Очередь в третье окно:");
            foreach (string w in window3)
            { Console.WriteLine(w); }
        }
        public static void Task_4()
        {
            int[,] graph =  {
                         { 0, 6, 0, 0, 0, 0, 0, 9, 0 },
                         { 6, 0, 9, 0, 0, 0, 0, 11, 0 },
                         { 0, 9, 0, 5, 0, 6, 0, 0, 2 },
                         { 0, 0, 5, 0, 9, 16, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 6, 0, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 16, 0, 2, 0, 1, 6 },
                         { 9, 11, 0, 0, 0, 0, 1, 0, 5 },
                         { 0, 0, 2, 0, 0, 0, 6, 5, 0 }
                            };

            DijkstraAlgo(graph, 0, 9);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Task_4();
        }
        public struct Student
        {
            public string lname;
            public string fname;
            public DateTime date;
            public string exam;
            public byte scores;
        }
        public static void Compare(List<byte> bbb, List<byte> ss)
        {
            int k = 0;
            int l = 0;
            if (bbb.Contains(5))
            { k++; }
            if (ss.Contains(5))
            { l++; }
            if (k == l)
            { Console.WriteLine("\nDrinks All Round! Free Beers on Bjorg!"); }
            else
            { Console.WriteLine("\nОй, Бьорг - пончик! Ни для кого пива!"); }
        }
        public static void GetDossier(StreamReader sr, ref List<string> people)
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                people.Add(line);
            }
        }
        static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        static void DijkstraAlgo(int[,] graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                        distance[v] = distance[u] + graph[u, v];
            }

            PrintMinDist(distance);
        }
        public static void PrintMinDist(int[] distance)
        {
            Console.Write("Введите конечную точку ");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальное расстояние от источника до точки" + distance[j]);
        }
    }
}