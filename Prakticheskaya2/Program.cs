namespace Prakticheskaya2
{
    internal class Program
    {
        static void Main()
        {
            int gameNumber = 0;
            do
            {


                Console.WriteLine("Выберите номер игры: ");

                Console.WriteLine("1 - 'Угадай число' \n2 - 'Таблица умножения'\n3 - 'Вывод делителей числа'\n4 - Выйти из программы");
                gameNumber = Convert.ToInt32(Console.ReadLine());
                switch (gameNumber)
                {
                    case 1:
                        {
                            game1();
                            break;
                        }
                    case 2:
                        {
                            game2();
                            break;

                        }
                    case 3:
                        {
                            game3();
                            break;

                        }
                    case 4:
                        Console.WriteLine("Я рад что это работает, хорошего вам настроения!");
                        break;
                }


                static void game1()
                {
                    Console.WriteLine("Здравствуйте, это проходной тест на XXVI сезон шоу 'Битва экстраc**сов' ");

                    Random rnd = new Random();
                    int random_chislo = rnd.Next(1, 100);
                    int chislo = 0;
                    do
                    {
                        Console.WriteLine("Введите ваше число, падаван: ");
                        chislo = Convert.ToInt32(Console.ReadLine());
                        if (chislo != random_chislo)
                        {
                            if (chislo > random_chislo)
                                Console.WriteLine("Давай потише, братик");
                            else
                                Console.WriteLine("Давай погромче");
                        }

                    } while (random_chislo != chislo);
                    Console.WriteLine("Ну ты конечно тип, числа угадываешь)))))");
                }

                static void game2()
                {
                    Console.WriteLine("Здарова школяр, нужна табличка умножения??????");
                    int[,] tablica = new int[11, 11];
                    for (int i = 1; i < tablica.GetLength(0); i++)
                    {
                        for (int j = 1; j < tablica.GetLength(1); j++)
                        {
                            tablica[i, j] = i * j;
                        }
                    }
                    for (int i = 1; i < tablica.GetLength(0); i++)
                    {
                        for (int j = 1; j < tablica.GetLength(1); j++)
                        {
                            Console.Write(tablica[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                static void game3()
                {
                    int number = 1;
                    Console.WriteLine("Я не знаю зачем тебе это, но на ");
                    Console.WriteLine("Введи сюда своё число => ");
                    number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }

            } while (gameNumber != 4);
        }
    }
}
