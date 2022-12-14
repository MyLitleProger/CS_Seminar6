Console.Clear();
restart:
Console.WriteLine("1-5 Задачи семинара");
Console.WriteLine("6-7 Практические задачи");
Console.WriteLine("8-9 Дополнительная задача \n");
Console.Write("Что бы запустить какую то конкретную задачу введите номер этой задачи то 1 до 9: ");
int Task = int.Parse(Console.ReadLine());

switch (Task)
{
    case 1:
        /*Задача 39: Напишите программу, которая перевернет
        одномерный массив (последний элемент будет на первом
        месте, а первый - на последнем и т.д.*/

        void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
                array[i] = new Random().Next(1, 11);
        }
        void ReversArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; ++i)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        Console.Write("Введите кол-во элементов: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        InputArray(array);
        Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
        ReversArray(array);
        Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
        break;

    case 2:
        /*Задача 40: Напишите программу, которая принимает на вход три
        числа и проверяет может ли существовать треугольник с 
        сторонами такой длины.*/
        bool yes = false;
        array = new int[3];
        InputArray(array);
        Console.WriteLine($"Стороны треугольника равны: [{string.Join(", ", array)}]");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < array[(i + 1) % array.Length] + array[(i + 2) % array.Length])
                yes = true;
            else break;
        }
        Console.WriteLine(yes);
        break;

    case 3:
        /*Задача 42: Напишите программу, которая будет преобразовывать
        десятичное число в двоичное.*/

        //мое решение
        Console.Write("Введтие число: ");
        int number = int.Parse(Console.ReadLine()), temp1 = number, temp2 = 0, temp3 = 0;
        int[] binary = new int[0];
        while (temp1 >= 1)
        {
            temp2 = temp1 / 2;
            Array.Resize(ref binary, binary.Length + 1);
            binary[temp3] = temp1 % 2;
            temp1 = temp2;
            temp3++;
        }
        ReversArray(binary);
        Console.WriteLine($"{string.Join("", binary)}");
        //

        //решение на занятие
        string result = string.Empty;
        while (number > 0)
        {
            result = Convert.ToString(number % 2) + result;
            number /= 2;
        }
        Console.WriteLine(result);
        break;

    case 4: /*Задача 44: Не использя рекурсию, выведите первые 
            N чисел Фибоначчи. первые два числа Фиббоначи: 0 и 1.*/
        Console.Write("Введтие число: ");
        number = int.Parse(Console.ReadLine());
        int a0 = 0, a1 = 1, z;
        for (int i = 0; i < number; i++)
        {
            Console.Write($"{a0} ");
            z = a0 + a1;
            a0 = a1;
            a1 = z;
        }
        break;

    case 5: /*Задача 45: Напишите программу, которая будет создавать
            копию заданного массива с помощью поэлементного копирования.*/
        array = new int[10];
        int[] array1 = new int[array.Length];
        InputArray(array);
        Console.WriteLine($"[{string.Join(", ", array)}]");
        for (int i = 0; i < array.Length; i++)
        {
            array1[i] = array[i];
        }
        array1[0] = -1; //проверка
        Console.WriteLine($"[{string.Join(", ", array1)}]");
        break;

    case 6: /*Задание 41: Пользоватлеь вводит с клавиатуры М чисел
            посчитайте сколько чисел больше 0*/
        Console.Write("Введтие число: ");
        int M = int.Parse(Console.ReadLine());
        for (int j = 0; j < 5; ++j)
        {                    //цикл для тестов
            array = new int[M];
            int positive = 0;
            for (int i = 0; i < array.Length; ++i)
            {        //заполнение по быстрому
                array[i] = new Random().Next(-10, 11);
            }
            Console.Write($"[{string.Join(", ", array)}]");
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                    positive++;
            }
            Console.WriteLine($" -> {positive}");
        }
        break;

    case 7: /*Задание 43:  Напишите программу, которая найдёт точку 
            пересечения двух прямых, заданных уравнениями 
            y = k1 * x + b1, y = k2 * x + b2; 
            значения b1, k1, b2 и k2 задаются пользователем.*/
        for (int i = 0; i < 5; ++i)
        {
            int     b1 = new Random().Next(1, 10),
                    k1 = new Random().Next(1, 10),
                    b2 = new Random().Next(1, 10),
                    k2 = new Random().Next(1, 10);
            Console.WriteLine($"k1 = {k1}, b1 ={b1}, k2 = {k2}, b2 = {b2}");
            if (b2 != b1 && k2 != k1)
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = (k1 * x + b1);
                Console.WriteLine($"{x}, {y}");
            }
            else Console.WriteLine($"не получсается вычислить X, исключение деления на 0");
        }
        break;

    case 8:/*доп на рекурсию */
        void Permutation(string[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                string last = array[array.Length - 1];
                for (int i = array.Length - 2; i >= 0; i--)
                {
                    array[i + 1] = array[i];


                }
                array[0] = last;
                Console.WriteLine($"[{string.Join("", array)}]");
                //Permutation(array);
            }
        }
        string[] array4 = { "A", "B", "C" };
        Permutation(array4);

        break;

    case 9: /*Вычислить площадь треугольинка по координатам*/
        System.Console.WriteLine("Введите координаты треугольника: ");
        double  x1 = int.Parse(Console.ReadLine()),
                y1 = int.Parse(Console.ReadLine()),
                x2 = int.Parse(Console.ReadLine()),
                y2 = int.Parse(Console.ReadLine()),
                x3 = int.Parse(Console.ReadLine()),
                y3 = int.Parse(Console.ReadLine());

        double  a = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)),
                b = Math.Sqrt((x3-x1)*(x3-x1)+(y3-y1)*(y3-y1)),
                c = Math.Sqrt((x2-x3)*(x2-x3)+(y2-y3)*(y2-y3)),
                p = (a + b + c) / 2;
        
        System.Console.WriteLine($"S = {Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)),1)}");
        break;
    default:
        goto restart;
}