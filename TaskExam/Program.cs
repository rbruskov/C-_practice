
//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
//рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


//ввод числа вручную
int imput()
{
    Console.WriteLine("Введите целое число");
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

// отображение массива
void showarray(int[] name,int length)
{
    int index = 0;
    // int length = name.Length;
    Console.Write("Массив сформирован:");
    while (index < length)
    {
        Console.Write(" {0}", name[index]);
        index++;
    }
    Console.WriteLine();
}

//тело программы

Console.Clear();

Console.WriteLine("программа из массива случайных целых чисел формирует массив из четных чисел");

Console.WriteLine("Введите длину массива из случайных чисел");

int arraylength = imput();

Console.WriteLine("введите значение начала для диапазона случайных чисел");

int Nmin = imput();

Console.WriteLine("Введите конечное значение для диапозона");

int Nmax = imput();

Console.WriteLine(arraylength);

int[] array = createarray(arraylength, Nmin, Nmax);
int[] arrayeven = createarray(arraylength, 0, 0);
int j = 0;
showarray(array,arraylength);

for (int i = 0; i < arraylength; i++) 
{
    if (array[i]%2==0)
    {
        arrayeven[j]=array[i];
        j++;
    }
}

showarray(arrayeven,j); 
