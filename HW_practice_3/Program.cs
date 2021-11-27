// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Ввести номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D
// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

//ввод числа вручную
int imput()
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

// формирование массива случайными числами заданного интервала  

int[] createarray(int count, int indexmin, int indexmax)
{

    int index = 0;
    int[] array = new int[count];
    while (index < count)
    {
        array[index] = new Random().Next(indexmin, indexmax);
        index++;
    }
    return array;
}

// заполнение массива вручную
int[] newarray(int count)
{

    int index = 0;
    int[] array = new int[count];
    Console.WriteLine("Теперь необходимо задать каждое число из {0} чисел", count);
    while (index < count)
    {
        Console.WriteLine("{0} число", index + 1);
        array[index] = imput();
        index++;
    }
    return array;
}
// отображение массива
void showarray(int[] name)
{
    int index = 0;
    int length = name.Length;
    Console.Write("Массив сформирован:");
    while (index < length)
    {
        Console.Write(" {0}", name[index]);
        index++;
    }
    Console.WriteLine();
}






Console.Clear();
Console.WriteLine("Введите номер задачи из списка");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Вы выбрали задачу №: {0} - ", num);

if (num == 15) // 15. Дано число. Проверить кратно ли оно 7 и 23
{
    Console.WriteLine("Дано число. Проверить кратно ли оно 7 и 23");
    double N = imput();
    int number1 = 7;
    int number2 = 23;
    double DEV = number1 * number2;
    Console.WriteLine("7x23={0}", DEV);
    if (N % number1 == 0 && N % number2 == 0)
    {
        DEV = N / number1;
        Console.WriteLine("{0}", DEV);
        DEV = N / number2;
        Console.WriteLine("{0}", DEV);
    }
    else
    {
        DEV = N % number1;
        Console.WriteLine("{0}", DEV);
        DEV = N % number2;
        Console.WriteLine("{0}", DEV);
    }
}

if (num == 16) // 15. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
{
    Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер недели выходным днём");
    double N = imput();
    if (N % 7 == 0 || N % 7 > 5)
    {
        Console.WriteLine(" выходной {0}", N = N % 7);
    }
    else
    {
        Console.WriteLine(" будний день {0}", N = N % 7);
    }
}

if (num == 19) // 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

{
    Console.WriteLine("// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0");
    int x = imput();
    int y = imput();

    if (x > 0 && y > 0)
    {
        Console.WriteLine(" второй четверти");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine(" четвертой четверти");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine(" первой четверти");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine(" второй четверти");
    }
}


if (num == 20) // 20. Ввести номер четверти, показать диапазоны для возможных координат

{
    Console.WriteLine("Ввести номер четверти, показать диапазоны для возможных координат");
    int N = imput();
    while (0 > N || N > 5)
    {
        N = imput();
    }
    if (N == 1)
    {
        Console.WriteLine("-N<x<0 и 0<y<N");
    }
    if (N == 2)
    {
        Console.WriteLine("0<x<N и 0<y<N");
    }
    if (N == 3)
    {
        Console.WriteLine("0<x<N и 0>y>-N");
    }
    if (N == 4)
    {
        Console.WriteLine("-N<x<0 и 0>y> -N");
    }

}

// 21. Программа проверяет пятизначное число на палиндромом.

if (num == 21) // 21. Программа проверяет пятизначное число на палиндромом.

{
    Console.WriteLine("Программа проверяет пятизначное число на палиндромом.");
    int index = imput();
    int[] array = newarray(index);
    showarray(array);

    for (int i = 0; i < array.Length/2; i++)
        if (array[i] != array[array.Length -1- i])
        {
          i= array.Length/2;
          Console.WriteLine(" не палиндром");
        }
        else 
        {
            if (i==array.Length/2-1)
            Console.WriteLine("палиндром");
        }  
        
        
}