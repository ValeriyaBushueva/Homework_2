using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Homework_2
{
    // Бушуева Валерия
    internal class Program
    {
      
            #region Task1

            static void Task1()
            {
                Console.Title = "Программа1. Написать метод, возвращающий минимальное из трёх чисел.";
                int a = 5;
                int b = 3;
                int c = 7;

                static int MinimumNumber(int a, int b, int c)
                {
                    if (a < b && a < c)
                    {
                        return a;
                    }
                    else if (b < a && b < c)
                    {
                        return b;
                    }
                    else
                    {
                        return c;
                    }
                }

                Console.WriteLine("Минимальное число = " + MinimumNumber(a, b, c));
                Console.ReadLine();

                Console.Clear();
            }

            #endregion
             
             #region Task2

             static void Task2()
             {
                 Console.Title = "Написать метод подсчета количества цифр числа.";

                 Console.WriteLine(" Введите любое число:");
                 int n = Convert.ToInt32(Console.ReadLine());
                 int count = 0;

                 while (n != 0)
                 {
                     count++;
                     n = n / 10;
                 }

                 Console.WriteLine("Количество цифр введеного вами числа состовляет: " + count);
                 Console.ReadLine();

                 Console.Clear();
             }

             #endregion
             
             #region Task3

             static void Task3()
             {

                 Console.Title = " Программа 3. Подсчитать сумму всех нечетных положительных чисел.";

                 int number;
                 int AmountOfOddNumbers = 0;
                 do
                 {
                     Console.WriteLine(" Вводите числа по одному, для завершения нажмите 0 ");
                     number = Convert.ToInt32(Console.ReadLine());

                     if (number > 0 && number % 2 == 1)
                     {
                         AmountOfOddNumbers += number;
                     }

                 } while (number != 0);

                 Console.WriteLine("Сумма чисел: " + AmountOfOddNumbers);
                 Console.ReadKey();

                 Console.Clear();
             }

             #endregion
                         
            #region Task5

            static void Task5()
            {
                Console.Title = "Программа 5. Запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.";

                static string CheckNorm(double bmi, double heigth)
                {
                    string result = "";
                    if (bmi >= 18.5 && bmi <= 24.99)
                    {
                        result = "Всё в норме!";
                    }
                    else if (bmi < 18.5)
                    {
                        double recommendation = (18.5 - bmi) * heigth * heigth;
                        result = String.Format("Необходимо набрать {0:0.00} кг для нормализации веса!", recommendation);
                    }
                    else if (bmi > 24.99)
                    {
                        double recommendation = (bmi - 24.99) * heigth * heigth;
                        result = String.Format("Необходимо сбросить {0:0.00} кг для нормализации веса!",
                            recommendation);
                    }

                    return result;
                }

                Console.Write("Введите вес человека в кг: ");
                double mass = double.Parse(Console.ReadLine());

                Console.Write("Введите рост человека в см: ");
                double heigth = double.Parse(Console.ReadLine());

                heigth /= 100;

                Console.Write("Индекс массы тела : ");
                double BMI = mass / (heigth * heigth);

                Console.WriteLine("{0:0.##}", BMI);

                Console.WriteLine(CheckNorm(BMI, heigth));


                Console.ReadKey();
            }
            
            #endregion 
            
            #region Task6

            static void Task6()
            {
                Console.Title =
                    "Программа 6. Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000." +
                    "\n«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени, используя структуру DateTime.";

                static bool CheckGoodNumber(int value)
                {
                    string charArray = Convert.ToString(value);
                    int sum = 0;
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        sum += charArray[i] - '0'; //https://stackoverflow.com/a/239107
                    }

                    if (value % sum == 0)
                        return true;
                    else
                        return false;
                }

                int AmountOfGoodNumbers = 0;

                Console.Write(
                    "Диапазон <хороших> чисел: от 1 до 1 000 000 000.\nНеобходимо подождать, пока программа выполняется");
                DateTime start = DateTime.Now;


                for (int i = 1; i < 1000000000; i++)
                {
                    if (CheckGoodNumber(i))
                    {
                        AmountOfGoodNumbers++;
                    }
                }

                Console.Write("\nВремя работы программы: "); //Время работы программы: 00:02:50.9021925

                Console.WriteLine(DateTime.Now - start);

                //В заданном диапазоне содержится 61574509 <Хороших> чисел
                Console.WriteLine("\nВ заданном диапазоне содержится " + AmountOfGoodNumbers + " «Хороших» чисел");
                Console.ReadKey();

                Console.Clear();
            }

            #endregion
                           
            #region Task7

            static void Task7()
            {
                Console.Title = "Программа 7. Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).";

                RecursiveMethod(3, 30, 0);
                Console.ReadLine();

                static void RecursiveMethod(int a, int b, int count)
                {
                    Console.WriteLine(a.ToString());

                    // Разработать рекурсивный метод, который считает сумму чисел от a до b.
                    count += a;

                    if (a >= b)
                    {
                        Console.WriteLine($"FINAL COUNT: {count.ToString()}");
                        return;
                    }

                    RecursiveMethod(a + 1, b, count);
                }

                Console.Clear();
            }

            #endregion
            
            
        public static void Main(string[] args)
        {
            Console.WriteLine("Ввeдите номер задания");
            int num = int.Parse(Console.ReadLine());
            
            switch(num)
            {
                case 1:
                 Task1();
                 break;
                
                case 2:
                 Task2();
                  break;
                
                case 3:
                 Task3();
                 break;
                 
                case 4:
                 Task5();
                 break;
                 
                case 5:
                 Task6();
                 break;
                 
                case 6:
                 Task7();
                 break;
                 
                default:
                    Console.WriteLine("Такого задания здесь нет");
              break;
            }
           
        }
    }
}