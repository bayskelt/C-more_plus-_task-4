namespace C__more_plus__task_4
{
    using System;

    internal class Program
    {
        // Функція для обчислення n-го числа Фібоначчі
        static int Fibonacci(int n)
        {
            // Початкові значення перших двох чисел Фібоначчі
            int a = 0, b = 1, c = 0;
            // Якщо n дорівнює 0, повертаємо 0
            if (n == 0) return a;
            // Ітерація для обчислення n-го числа Фібоначчі
            for (int i = 2; i <= n; i++)
            {
                c = a + b; // Сума двох попередніх чисел
                a = b;     // Зсув значення вперед
                b = c;     // Зсув значення вперед
            }
            return b; // Повертаємо n-те число Фібоначчі
        }

        static void Main()
        {
            // Запитуємо у користувача ввести довжину послідовності
            Console.Write("Введіть довжину послідовності n: ");
            int length = int.Parse(Console.ReadLine());

            // Обчислюємо кількість послідовностей, додаючи 2 до довжини
            int count = Fibonacci(length + 2);
            // Виводимо результат
            Console.WriteLine("Кількість послідовностей: " + count);
        }
    }
}
