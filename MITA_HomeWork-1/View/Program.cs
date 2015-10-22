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
        static void Main(string[] args)
        {
            //Зачем задавать цвет, если он изменяется в зависимости от здоровья? Предпологается, что изначально кошка здоровая.

            var Cat = new Cat();

            var Color = new CatColor
            {
                HealthyColor = "Белый",
                SickColor = "Зеленый"
            };

            Cat.CurrentColor = Color.HealthyColor;

            int i;
            do
            {
                Console.Write("Имя: " + Cat.Name);
                Console.Write("\nВозраст: " + Cat.Age);
                Console.Write("\nЦвет: " + Cat.CurrentColor);

                Console.Write("\nМеню:\n1) Задать имя \n2) Задать возраст \n3) Задать цвет \n4) Ударить! \n5) Покормить \n6) Выйти \n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Write("Задать имя: ");
                        Cat.Name = Console.ReadLine();
                        Console.WriteLine("Имя: " + Cat.Name);

                        break;
                    case 2:
                        Console.Write("Задать возраст: ");
                        Cat.Age = Console.ReadLine();
                        Console.WriteLine("Возраст: " + Cat.Age);
                        break;
                    case 3:
                        Console.WriteLine("Задать цвет: ");
                        break;
                    case 4:
                        if (Cat.Age == null)
                        {
                            Console.WriteLine("Сначала введите возраст!");
                            break;
                        }

                        Cat.Punish();
                        Console.WriteLine("Вы ударили ее и теперь здоровье кошки равно " + Cat.Health);
                        Console.WriteLine("Цвет изменился на " + (Cat.CurrentColor = Color.SickColor));
                        break;
                    case 5:
                        if (Cat.Age == null)
                        {
                            Console.WriteLine("Сначала введите возраст!");
                            break;
                        }

                        Cat.Feed();
                        Console.WriteLine("Вы покормили ее и теперь здоровье кошки равно " + Cat.Health);
                        Console.WriteLine("Цвет изменился на " + (Cat.CurrentColor = Color.HealthyColor));
                        break;
                    case 6:
                        Console.WriteLine("Вы решили выйти");
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n");
              
            }
            while (i != 6);
        }
    }
}
