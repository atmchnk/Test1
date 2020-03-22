using System;

namespace Test._Timchenko
{
    class Student
    {
        public string surname { get; set; } //змінна для опису прізвища
        public string group { get; set; } //група
        public double point { get; set; } //середній бал 
        public string budget { get; set; } //бюджет/контракт

        public Student() //конструктор класу
        {
            surname = surname;
            group = group;
            point = point;
            budget = budget;
        }

        public void InputInfo()
        {
            Console.WriteLine("Введіть прізвище студента: ");
            string surname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введіть групу: ");
            string group = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введіть середній бал: ");
            double point = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Бюджет/контракт: ");
        }

        public void OutputInfo()
        {
            Console.WriteLine($"Прізвище: {surname} Група: {group} Середній бал: {point} Бюджет / контракт: {budget} ");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int n = 0; //змінна для кількості 
            try //перевірка на правильність введення інформації 
            {
                Console.Write("Введіть кількість студентів: ");
                n = Convert.ToInt32(Console.ReadLine());

                Student[] Stu = new Student[n];
                //масив посилань заповнення масиву посиланнями на об'єкти похідних класів
                for (int i = 0; i < n; i++)
                {
                    Stu[i] = new Student();
                    Stu[i].InputInfo();
                    Stu[i].OutputInfo();
                }

                Console.Write("Введіть групу студента, якого хочете знайти: ");
                string group1 = Convert.ToString(Console.ReadLine());
                if (group1 == group)
                {
                    Console.Write("Такий студент є");
                    {
                        Stu[i].OutputInfo();
                    }
                }
                else
                {
                    Console.Write("Такого студента немає ");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Вихід за межі діапазону");
            }
            catch (FormatException)
            {
                Console.WriteLine("Невірний формат вводу даних");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостатньо пам'яті для створення нового об'єкта");
            }
        }
    }
}