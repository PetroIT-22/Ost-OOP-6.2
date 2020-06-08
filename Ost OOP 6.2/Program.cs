using System;
using System.IO;

namespace Ost_OOP_6._2
{
    interface ISite
    {
        float Number();
        void Maxday();
        int Ser();
    }

    public abstract class Site:ISite
    {
        public string Email;
        public string PIB;
        abstract public float Number();
        abstract public void Maxday();
        abstract public int Ser();
        
        public static void Add()
        {
            Console.WriteLine("Введiть данi");

            Console.Write("Назва: ");
            string str = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", str);

            Console.Write("URL: ");
            string URL1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", URL1);

            Console.Write("Дата: ");
            string ddate = Console.ReadLine();

            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", ddate);

            Console.Write("Кількість хостів: ");
            string host1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", host1);

            Console.Write("Кількість завантажень: ");
            string down1 = Console.ReadLine();
            File.AppendAllText("text.txt", "\n");
            File.AppendAllText("text.txt", down1);

            Output.Write(Program.visit);

            Input.Key();

        }

        public static void Remove()
        {
            Console.Write("Email: ");

            string name = Console.ReadLine();

            bool[] write = new bool[Program.visit.Length];

            for (int i = 0; i < Program.visit.Length; ++i)
            {
                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].Email == name)
                    {
                        Console.WriteLine("{0,-30} {1, -30} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);

                        Console.WriteLine("Видалити? (Y/N)\n");

                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y)
                        {

                            Program.visit[i] = null;
                            Program.delete[i] = true;
                            Output.Write(Program.visit);



                        }
                        else
                        {
                            Program.delete[i] = false;
                        }
                    }
                }
            }
        }

        public static void Edit()
        {

            Console.WriteLine("Що ви хочете редагувати");
            string what = Console.ReadLine();
            switch (what)
            {
                case "Email":
                    Console.WriteLine("Що саме");
                    string name1 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].Email == name1)
                            {
                                Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);


                                Console.WriteLine("Введiть нову назву");

                                string str = Console.ReadLine();

                                Program.visit[i].Email = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "PIB":
                    Console.WriteLine("Що саме");
                    string URL1 = Console.ReadLine();



                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].Email == URL1)
                            {
                                Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);


                                Console.WriteLine("Введiть нову URL");

                                string str = Console.ReadLine();

                                Program.visit[i].PIB = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "date":
                    Console.WriteLine("Що саме");
                    string name2 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].Email == name2)
                            {
                                Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);


                                Console.WriteLine("Введiть нову дату");

                                string str = Console.ReadLine();

                                Program.visit[i].date = Convert.ToDateTime(str);

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;
                case "spam":
                    Console.WriteLine("Що саме");
                    string name3 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].Email == name3)
                            {
                                Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);


                                Console.WriteLine("Введiть нову кількість хостів");

                                int str = int.Parse(Console.ReadLine());

                                Program.visit[i].spam = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;

                case "powid":
                    Console.WriteLine("Що саме");
                    string name4 = Console.ReadLine();
                    for (int i = 0; i < Program.visit.Length; ++i)
                    {
                        if (Program.visit[i] != null)
                        {
                            if (Program.visit[i].Email == name4)
                            {
                                Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);


                                Console.WriteLine("Введiть нову кількість завантажених сторінок");

                                int str = int.Parse(Console.ReadLine());

                                Program.visit[i].powid = str;

                                Output.Write(Program.visit);
                            }
                        }

                    }
                    break;

            }


        }




        private static void Save(Spamm m)
        {
            StreamWriter save = new StreamWriter("text.txt", true);

            save.WriteLine(m.Email);
            save.WriteLine(m.PIB);
            save.WriteLine(m.date);
            save.WriteLine(m.spam);
            save.WriteLine(m.powid);

            save.Close();
        }

        public static void Parse(string[] elements, bool save)
        {
            int counter = 0;

            while (Program.visit[counter] != null)
            {
                ++counter;
            }

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.visit[counter + i / 5] = new Spamm(elements[i], elements[i + 1], DateTime.Parse(elements[i + 2]), float.Parse(elements[i + 3]), float.Parse(elements[i + 4]));

                if (save)
                {
                    Save(Program.visit[counter + i / 5]);
                }
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("text.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }


    }
    class Spamm : Site
    {
        public DateTime date;
        public float spam;
        public float powid;
        public Spamm(string Email, string PIB, DateTime date, float spam, float powid)
        {
            this.Email = Email;
            this.PIB = PIB;
            this.date = date;
            this.spam = spam;
            this.powid = powid;
        }
        public override float Number()
        {
            Console.WriteLine("Введіть період: ");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            float n1 = 0;
            float n2 = 0;
            for (int i = 0; i < Program.visit.Length; ++i)

            {

                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].date > d1 && Program.visit[i].date < d2)
                    {
                        n1 += Program.visit[i].spam;
                        n2++;

                    }
                }
            }
            Console.WriteLine("Середня кількість спаму в день за період: {0}", n1 / n2);
            return n1 / n2;
        }
        public override void Maxday()
        {
            Console.WriteLine("Введіть значення: ");
            float z = float.Parse(Console.ReadLine());
            int n = 0;
            for (int i = 0; i < Program.visit.Length; ++i)

            {

                if (Program.visit[i] != null)
                {
                    if ((Program.visit[i].spam / Program.visit[i].powid) * 100 >= z)
                    {
                        n++;
                        Console.WriteLine("{0,-30} {1, -30} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);
                    }
                }
            }
            Console.WriteLine("Кількість днів, коли відсоток спам повідомлень був менший за задане значення: {0}", n);

        }
        public override int Ser()
        {
            int n = 0;
            for (int i = 1; i < Program.visit.Length; ++i)

            {

                if (Program.visit[i] != null)
                {
                    if (Program.visit[i].spam > Program.visit[i - 1].spam)
                    {
                        n++;
                        Console.WriteLine("{0,-30} {1, -30} {2, -30} {3, -15} {4, -15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);
                    }
                }
            }
            return n;

        }
    }

    class Output
    {
        public static void Write(Spamm[] v)
        {


            for (int i = 0; i < v.Length; ++i)
            {
                if (v[i] != null)
                {
                    Console.WriteLine("{0,-30} {1, -20} {2, -30} {3, -15} {4,-15}", Program.visit[i].Email, Program.visit[i].PIB, Program.visit[i].date, Program.visit[i].spam, Program.visit[i].powid);
                }
            }
        }
    }
    class Input
    {


        public static void Key()
        {
            Site.Parse(Read(), false);

            Console.WriteLine("Додавання записiв: +");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: -");
            Console.WriteLine("Середня кількість спаму в день за період: K");
            Console.WriteLine("ДКількість днів, коли відсоток спам повідомлень був менший за задане значення: S");
            Console.WriteLine("Дні, коли кількість спаму збільшувалась: F");
            Console.WriteLine("Виведення записiв: Enter");

            Console.WriteLine("Вихiд: Esc");


            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.OemPlus:
                    Console.WriteLine();
                    Site.Add();
                    break;

                case ConsoleKey.E:
                    Console.WriteLine();
                    Site.Edit();
                    break;

                case ConsoleKey.OemMinus:
                    Console.WriteLine();
                    Site.Remove();
                    break;

                case ConsoleKey.Enter:
                    Console.WriteLine();
                    Output.Write(Program.visit);
                    Key();
                    break;
                case ConsoleKey.F:
                    Console.WriteLine();
                    Program.visit[0].Ser();
                    break;
                case ConsoleKey.S:
                    Console.WriteLine();
                    Program.visit[0].Maxday();
                    break;
                case ConsoleKey.K:
                    Console.WriteLine();
                    Program.visit[0].Number();
                    break;



                case ConsoleKey.Escape:
                    return;
            }
        }
        public static string[] Read()
        {
            StreamReader fromFile = new StreamReader("text.txt");

            return fromFile.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
        }
    }



    class Program
    {
        public static Spamm[] visit = new Spamm[1000000];
        public static bool[] delete = new bool[1000000];
        static void Main(string[] args)
        {
            Input.Key();
        }
    }
}