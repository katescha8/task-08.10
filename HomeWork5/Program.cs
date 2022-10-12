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
            {lname = "Аронов",fname = "Алексей", date = new DateTime(2004,1,1),exam = "Физика",scores = 79};
            Student s2 = new()
            {lname = "Баронов",fname = "Николай",date = new DateTime(2004,10,14),exam = "Физика",scores = 81 };
            Student s3 = new()
            { lname = "Вечный", fname = "Андрей", date = new DateTime(2004,7,25), exam = "Информатика", scores = 82 };
            Student s4 = new()
            { lname = "Горелова",fname = "Мила",date = new DateTime(2004,2,7),exam = "Информатика",scores = 83 };
            Student s5 = new()
            { lname = "Дошина", fname = "Алёна", date = new DateTime(2004,5,13), exam = "Физика", scores = 84 };
            Student s6 = new() 
            { lname = "Егорченко", fname = "Михаил", date = new DateTime(2004,3,26), exam = "Английский", scores = 87 };
            Student s7 = new()
            { lname = "Зубенко", fname = "Филипп", date = new DateTime(2003,6,9), exam = "Немецкий", scores = 89 };
            Student s8 = new()
            { lname = "Леонтьева", fname = "Варвара", date = new DateTime(2004,2,23), exam = "Физика", scores = 95 };
            Student s9 = new() 
            { lname = "Мурин", fname = "Артём", date = new DateTime(2004,7,11), exam = "Французский", scores = 92 };
            Student s10 = new()
            { lname = "Султанбеков", fname = "Наиль", date = new DateTime(2003,12,31), exam = "Информатика", scores = 74 };
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
                Console.WriteLine(s0.Key +" "+ s0.Value.scores);
            }
            Console.WriteLine("Меню: Новый студент, Удалить, Сортировать"); 
            string answer = Console.ReadLine();
            switch(answer)
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

        }
        public static void Task_3()
        {

        }
        public static void Task_4()
        {

        }

        static void Main(string[] args)
        {
            Task_1();
        }
        public struct Student
        {
            public string lname;
            public string fname;
            public DateTime date;
            public string exam;
            public byte scores;
        }
    }
}
