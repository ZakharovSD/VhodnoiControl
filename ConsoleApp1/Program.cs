using ConsoleApp1;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contr contr = new Contr();
            while (true)
            {
                Console.WriteLine("Введите номер задачи");
                int otw = Convert.ToInt32(Console.ReadLine());

                switch (otw)
                {
                    case 1:
                        Console.WriteLine("Ответ: " + contr.zd1());
                        break;
                    case 2:
                        contr.zd2();
                        break;
                    case 3:
                        Console.WriteLine("Ответ: " + contr.zd3());
                        break;
                }
            }

        }
    }
}