
// Задачи джун:
// 0. Вывести квадрат числа
// 1. По двум заданным числам проверять является ли первое квадратом второго
// 2. Даны два числа. Показать большее и меньшее число
// 3. По заданному номеру дня недели вывести его название
// 4. Найти максимальное из трех чисел
// 5. Написать программу вычисления значения функции y=f(a)
// 6. Выяснить является ли число чётным
// 7. Показать числа от -N до N
// 8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет


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

void showarray1(double[] name)
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

// нахождение максимального значения
int maxNumberarray(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (max < array[i])
        {
            max = array[i];
        }
    Console.WriteLine("Максимальное число: {0}", max);
    return max;

}

// замена текста/ццифры в числе

string replace (string text, int position, string newvalue)
{
    string result = string.Empty;
    for (int i=0; i<text.Length;i++)
    {
        if(i==position)  result = result + $"{newvalue}";
        else result = result + $"{text[i]}";
        
    }
    return result;
}


///////////////////////////////////Тело программы/////////////////////////////////////////////////////
Console.Clear();
Console.WriteLine("Введите номер задачи из списка");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Вы выбрали задачу №: {0} - ", num);

if (num == 0) //Квадрат числа
{
    Console.WriteLine("Вывести квадрат числа");
    int N = imput();
    int sqa = N * N;
    Console.WriteLine("{0}x{0}={1}", N, sqa);
}
if (num == 1) //По двум заданным числам проверять является ли первое квадратом второго 
{
    Console.WriteLine("По двум заданным числам проверять является ли первое квадратом второго");
    int N1 = imput();
    int N2 = imput();
    int sqa = N1 * N1;
    if (sqa == N2)
    {
        Console.WriteLine("Является {0}x{0}={1}", N1, sqa);
    }
    else
        Console.WriteLine("Не является {0}x{0}={1}, а второе заданное число {2}", N1, sqa, N2);
}
if (num == 2) //Даны два числа. Показать большее и меньшее число
{
    Console.WriteLine("Даны два числа. Показать большее и меньшее число");
    int N1 = imput();
    int N2 = imput();
    if (N1 > N2)
    {
        Console.WriteLine("{0} > {1}", N1, N2);
    }
    else
        Console.WriteLine("{0} < {1}", N1, N2);
}

if (num == 3) //По заданному номеру дня недели вывести его название
{
    Console.WriteLine("По заданному номеру дня недели от [1 до 7] вывести его название");
    int N = imput();
    string Daysofweek = "понедельник,вторник,среда,четверг,пятница,суббота,воскресенье";
    string[] Week = Daysofweek.Split(",");

    while (N > 7 || N < 1)  //проверка на ввод корректных данных
    {
        Console.WriteLine("введите число от 1 до 7");
        N = imput();
    }

    Console.WriteLine("номеру {1} соответсвует день недели - {0}", Week[N - 1], N);


}


if (num == 4) //Найти максимальное из трех(N) чисел
{
    Console.WriteLine("Найти максимальное из (N) чисел");

    Console.Write("введите кол-во чисел для N =");
    Console.WriteLine();
    int Narray = imput();
    int[] array = newarray(Narray);
    int max = maxNumberarray(array);
}

if (num == 5) //Функция y=f(x) 
{
    Console.WriteLine("в работе, запустите программу еще раз");
}


if (num == 6) //Выяснить является ли число чётным
{
    Console.WriteLine("Выяснить является ли число чётным");
    int N = imput();
    if (N % 2 != 1)
    {
        Console.WriteLine("Введенное число {0} - Четное", N);
    }
    else
        Console.WriteLine("Введенное число {0} - неЧетное", N);
}

if (num == 7 ) //Показать числа от -N до N 
{
    Console.WriteLine("Показать числа от -N до N ");

    //Console.Write("введите кол-во чисел для интервала -N : N");

    //int Narray = imput();
    Console.WriteLine("минимальное значение для -N");
    int Nmin = imput();
    Console.WriteLine("максимальное значение для N");
    int Nmax = imput();
    int count = Nmax - Nmin + 1;
    int[] array = new int[count];
    int max = 0;
    for (int i = 0; i < count; i++)
    {
        array[i] = Nmin + i;
        //Console.WriteLine(array[i]);
    }
    
    showarray(array);
    
}


if (num == 8) //Показать четные числа от 1 до N
{
    Console.WriteLine("Показать четные числа от 1 до N");

    int Nmin = 1;
    Console.WriteLine("значение для N");
    int Nmax = imput();
    int count = Nmax - Nmin + 1;
    int[] array = new int[count];
    for (int i = 1; i < count; i = i + 2)
    {
        array[i] = Nmin + i;
        //Console.WriteLine(array[i]);
    }
    showarray(array);

}

if (num == 9 || num == 10 || num == 11 || num==12 || num ==14) //Показать заданную/макс цифру из многозначного числа, проверить наличие N цифры в числе и удалить ее)
{
    Console.WriteLine("Показать максимальную и заданную цифру из многозначного числа, проверить наличие N цифры в числе и удалить ее");
    int N = imput();
    //string NS = Console.ReadLine();
    double digit = N;
    double dig = 0;
    string number = N.ToString();
    int index = number.Length;
    double [] newArray = new double [number.Length];
    
    for (int i=0;i<number.Length; i++)
    {
        newArray[i]=digit%10;
        dig = newArray[i]*0.1;
        digit = digit/10 - dig;
        
        //Console.WriteLine(dig);
    }
    Console.Write("(Справочно)"); showarray1(newArray);

    double Nmax = newArray[0];
    for(int i=0; i<number.Length-1;i++)
    {
        if (Nmax<newArray[i+1]) 
    {
    Nmax=newArray[i+1];
    //Console.WriteLine(Nmax);
    }
    }
    Console.WriteLine("Максимальная цифра заданного числа - {0}", Nmax);
    Console.WriteLine("порядковый номер цифры от 1 до {0}, которую нужно отобразить", number.Length);
    int Order = imput();
    while (Order>number.Length || Order<1)
    {
        Console.WriteLine("введенное число выходит за рамки многозначного числа [1:{0}], введите число заново" , number.Length);
        Order=imput();
    }
    string DeleteN = replace (number, Order-1, "_");
    //Console.WriteLine(DeleteN);

    Console.WriteLine("цифра {0} соответсвует порядковому номеру {1} многозначного числа и исключена из него {2}", number[Order - 1],Order,DeleteN);
}

if (num == 13) //Выяснить, кратно ли число заданному, если нет, вывести остаток 
{
    Console.WriteLine("Выяснить, кратно ли число заданному, если нет, вывести остаток");
    int N1 =  imput(); 
    int N2 =  imput(); 
    double div = 0;
    if (N1>N2)
    {
        if (N1%N2==0) 
        {
             Console.WriteLine( $"Кратное {N1}/{N2}={N1/N2}"); 
        }     
        else Console.WriteLine( $"Не является кратным {N1}%{N2} остаток ={N1%N2}");
    }    
    else   
        if(N2%N1 == 0) 
        { 
            Console.WriteLine($"Кратное {N2}/{N1}={N2/N1}"); 
        }     
        else Console.WriteLine($"Не является кратным {N2}%{N1} остаток ={N2%N1}"); 
}        

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. .
// 14. Найти третью цифру числа или сообщить, что её нет