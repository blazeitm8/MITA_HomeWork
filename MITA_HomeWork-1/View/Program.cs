using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    class Program
    {
        static void Main()
        {
            
            var color = new CatColor();

            string age;
            
            Console.Write("Покупка питомца. \nВведите возраст: ");
            age = Console.ReadLine();

            var cat = new Cat(color, age);

            Console.Write("Задайте цвет для здоровой кошки: ");
            color.HealthyColor = Console.ReadLine();

            Console.Write("Задайте цвет для больной кошки: ");
            color.SickColor = Console.ReadLine();

            int i;
            do
            {
                Console.Write("Имя: " + cat.Name);
                Console.Write("\nВозраст: " + cat.Age);
                Console.Write("\nЦвет: " + cat.CurrentColor);

                Console.Write("\nМеню:\n1) Задать имя \n2) Ударить! \n3) Покормить \n4) Выйти \n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Write("Задать имя: ");
                        cat.Name = Console.ReadLine();
                        Console.WriteLine("Имя: " + cat.Name);
                        break;
                    case 2:
                        if (cat.Age == null)
                        {
                            Console.WriteLine("Сначала введите возраст!");
                            break;
                        }
                        cat.Punish();
                        Console.WriteLine("Вы ударили ее и теперь здоровье кошки равно " + cat.Health);
                        Console.WriteLine("Цвет изменился на " + (cat.CurrentColor));
                        break;
                    case 3:
                        if (cat.Age == null)
                        {
                            Console.WriteLine("Сначала введите возраст!");
                            break;
                        }
                        cat.Feed();
                        Console.WriteLine("Вы покормили ее и теперь здоровье кошки равно " + cat.Health);
                        Console.WriteLine("Цвет изменился на " + (cat.CurrentColor));
                        break;
                    case 4:
                        Console.WriteLine("Вы решили выйти");
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n");
              
            }
            while (i != 4);
        }
    }
}
