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

while (num < 15 || num > 30)
{
    Console.WriteLine("Введите номер задачи из списка от 15 до 25");
    num = Convert.ToInt32(Console.ReadLine());
}

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

    for (int i = 0; i < array.Length / 2; i++)
        if (array[i] != array[array.Length - 1 - i])
        {
            i = array.Length / 2;
            Console.WriteLine(" не палиндром");
        }
        else
        {
            if (i == array.Length / 2 - 1)
                Console.WriteLine("палиндром");
        }


}

if (num == 22) // Найти расстояние между точками в пространстве 2D/3D
{
    Console.WriteLine("Найти расстояние между точками в пространстве 2D/3D");
    int x1 = imput();
    int y1 = imput();
    int z1 = imput();
    int x2 = imput();
    int y2 = imput();
    int z2 = imput();

    //метод вычисления координат и возведения в квадрат
    int length(int a, int b)
    {
        int dlinna = (a - b) * (a - b);
        return dlinna;
    }
    int x = length(x1, x2);
    int y = length(y1, y2);
    int z = length(z1, z2);
    double AB = Math.Sqrt(x + y + z);
    Console.WriteLine("{0} {1} {2}", x, y, z);
    Console.WriteLine(AB);
}


if (num == 23) //Показать таблицу квадратов чисел от 1 до N
{
    Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");
    int index = imput();
    int[] array = new int[index];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * (i + 1);
    }
    showarray(array);
}

if (num == 24) //Показать кубы чисел от 1 до N
{
    Console.WriteLine("Показать кубы чисел от 1 до N");
    int index = imput();
    int[] array = new int[index];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    showarray(array);
}

if (num == 25) //Найти сумму чисел от 1 до А
{
    Console.WriteLine("Найти сумму чисел от 1 до А");
    int index = imput();
    int[] array = new int[index];
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
        s = s + array[i];
    }
    showarray(array);
    Console.WriteLine(s);
}

if (num == 26) //Возведите число А в натуральную степень B используя цикл
{
    Console.WriteLine("Возведите число А в натуральную степень B используя цикл");
    int A = imput();
    int index = imput();
    int[] array = new int[index];
    int s = 1;
    for (int i = 0; i < array.Length; i++)
    {
        s = s * A;
        array[i] = s;
    }
    showarray(array);
    Console.WriteLine(s);
}

if (num == 27) //Определить количество цифр в числе
{
    Console.WriteLine("Определить количество цифр в числе");
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    Console.WriteLine(number.Length);
}

if (num == 28) //Подсчитать сумму цифр в числе
{
    Console.WriteLine("Подсчитать сумму цифр в числе");
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    int s = 0;
    int[] array = new int[number.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Convert.ToInt32(number[i])-48;
        s=s+array[i];
    }
    showarray(array);
    Console.WriteLine(s);
}

if (num == 29) //Написать программу вычисления произведения чисел от 1 до N
{
    Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");
    int index = imput();
    int[] array = new int[index];
    int s = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=i+1;
    }
    for (int i = 0; i < array.Length-1; i++)
    {
        s=s*array[i+1];
    
    }
    showarray(array);
    Console.WriteLine(s);
}

if (num == 30) //Показать кубы чисел от 1 до N
{
    Console.WriteLine("Показать кубы чисел от 1 до N");
    int index = imput();
    int[] array = new int[index/2];
    int[] array1 = new int[index];
    for (int i = 0; i < array.Length; i++)
    {
             
        array[i] = (i+i+2) * (i+i+2) * (i+i+2);
        
    //     if (array[i]%2!=0)
    // {
    //     array[i]=0;
    // }
     

    }
    for (int i = 0; i < array1.Length; i++)
    {
             
        array1[i] = (i+1) * (i+1) * (i+1);
    }    
    showarray(array1);
    showarray(array);
    
}
