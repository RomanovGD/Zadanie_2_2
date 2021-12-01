using System;

namespace pr2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10;
            Console.WriteLine("Задание II.\nУ Вас 15 каналов\n0 - выход");
            try
            {
                while (n != 0)
                {
                    Console.Write("\nВведите номер канала: ");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 0: Console.WriteLine("\nПриятного просмотра"); break;
                        case 1: Console.WriteLine("\nНовости \n«Время покажет»"); break;
                        case 2: Console.WriteLine("\nВести \n«Судьба человека» \n«Личное дело»"); break;
                        case 3: Console.WriteLine("\n«Сваты»"); break;
                        case 4: Console.WriteLine("\n«Воронины» \n«Послезавтра»"); break;
                        case 5: Console.WriteLine("\n«Три кота» \n«Ералаш» \n«Маша и медведь»"); break;
                        case 6: Console.WriteLine("\n«Вокруг света» \n«Уроки выживания»"); break;
                        case 7: Console.WriteLine("\n«Орёл и решка»"); break;
                        case 8: Console.WriteLine("\n«Звёздные войны» \n«Стартрек»"); break;
                        case 9: Console.WriteLine("\n«Мертвые души» \n«Война и мир» \n«Екатерина»"); break;
                        case 10: Console.WriteLine("\n«Судьба: Сага Викс» \n«Рагнарек»"); break;
                        case 11: Console.WriteLine("\n«Мстители»\n«Человек-паук» \n«Черная пантера» \n«Стражи Галактики»"); break;
                        case 12: Console.WriteLine("\n«Чужой» \n«Чужой против Хищника»"); break;
                        case 13: Console.WriteLine("\n«Кошмар на улице Вязов» \n«Сонная Лощина» \n«Кладбище домашних животных»"); break;
                        case 14: Console.WriteLine("\n«Алиса в Зазеркалье»"); break;
                        case 15: Console.WriteLine("\n«Маугли» \n«Ну, погоди!» \n«Трое из Простоквашино»"); break;
                        default: Console.WriteLine("У Вас нет этого канала :("); break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то не так");
            }

        }
    }
}
