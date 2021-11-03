// формирование массива  

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

//проверка массива на возрастание

void fromDowntoUp(int[] name)
{
    int index = 0;
    int length = name.Length;
    int max = 0;
    while (index < length)
    {
        if (max < name[index])
        {
            Console.WriteLine(name[index]);
            max = name[index];
            //Console.WriteLine(max);  
        }
        index++;
    }
}

//проверка кол-ва элеиентов массива между макс и мин

//среднее значение элементов массива

int medium(int[] name)
{
    int index = 0;
    int length = name.Length;
    int sum = 0;
    while (index < length)
    {
        sum = sum + name[index];
        index++;
    }
    int max = sum / length;
    Console.WriteLine("Сумма всех элементов массива: {0}, среднее значение элемента массива: {1}", sum, max);
    return max;
}

//проверка элементов массива, которые больше среднеарифмитического элементов массива

void DownUpmed(int[] name, int max)
{
    int index = 0;
    int length = name.Length;

    while (index < length)
    {
        if (max < name[index])
        {
            Console.WriteLine(name[index]);

            //Console.WriteLine(max);  
        }
        index++;
    }
}

//четные элементы массива

void evennum(int[] name)
{
    int index = 0;
    int length = name.Length;
    Console.WriteLine("четные элементы массива:");
    while (index < length)
    {
        if (name[index] % 2 != 1)
        {
            Console.WriteLine(name[index]);
        }
        index++;
    }
}

//сортировка массива по возрастанию или убыванию

int[] arrayorder(int[] name)
{
    int max = name[0];
    Console.WriteLine("введите (1) для формирования массива по возрастанию и для убывания - (2)");
    int sel=Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < name.Length; i++)
    {
        for (int j = 0; j < name.Length; j++)
        {
            if (sel == 1)
            {
                if (name[i] < name[j]) //для сортировки по убыванию нужно поменять знак "<" на ">"
                {
                    max = name[j];
                    name[j] = name[i];
                    name[i] = max;
                }
                
            }
            else
            if (name[i] > name[j]) //для сортировки по убыванию нужно поменять знак "<" на ">"
            {
                max = name[j];
                name[j] = name[i];
                name[i] = max;
            }
         }

    }
    return name;
}

//тело программы
Console.Clear();
Console.Write("введите длину массива:");
int arrnum = Convert.ToInt32(Console.ReadLine());

Console.Write("введите мин. значение диапазона:");
int indexmin = Convert.ToInt32(Console.ReadLine());

Console.Write("введите максимальное значение диапазона:");
int indexmax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина массива: {0}, диапазон [{1} : {2})", arrnum, indexmin, indexmax);


int[] arr = createarray(arrnum, indexmin, indexmax);
showarray(arr);
//fromDowntoUp(arr);
//int max = medium(arr);
//DownUpmed(arr, max);
//evennum(arr);

int[] sortarr = arrayorder(arr);
showarray(arr);
// int count = 10;
// int[] arr = createarray(count);
// Console.WriteLine(arr[0]);
