
//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
//рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// *******************Функции:****************************
//ввод числа вручную
string imput()
{
    Console.WriteLine("Введите целое число");
    string N =(Console.ReadLine());
    return N;
}

// проверка правильности ввода данных пользователем
string correctimput (int typedata, string userimp)
{
int a = typedata;
string correct = string.Empty;

while (a!=1)
{
    string userimput=imput();
    a=whatuserEntered(userimput);
    userimp=userimput;
}
correct=userimp;
return correct;
}

// определение типа вводимых данных
int whatuserEntered(string userimp) 
{
string userimput=userimp;
int tempInt;
decimal tempDec;
int TypeofDataImput=0;
int usernumber=0;

if(int.TryParse(userimput, out tempInt))
   {
    //   Console.WriteLine("целое число"); 
      TypeofDataImput=1;
    }
else 
if (decimal.TryParse(userimput, out tempDec))
   {
     Console.WriteLine("введено десятичное");
     TypeofDataImput=2;
    }
else 
    { 
    Console.WriteLine("введены символы");
    TypeofDataImput=3;
    }
return TypeofDataImput; 

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
void showarray(int[] name,int length, string Text)
{
    int index = 0;
    string text1 = Text;
    // int length = name.Length;
    Console.Write(text1);
    while (index < length)
    {
        Console.Write(" {0}", name[index]);
        index++;
    }
    Console.WriteLine();
}

//**************тело программы***************

Console.Clear();
Console.WriteLine("программа из массива случайных целых чисел формирует массив из четных чисел");

Console.WriteLine("Введите длину массива для случайных чисел");
string arraylength = imput();
int arraylengthconvert=Convert.ToInt32(correctimput(whatuserEntered(arraylength),arraylength));  // проверка корректного ввода данных и перевод строки в число
// int a = whatuserEntered(arraylength); определение типа введенных данных
// string arraylengthcorrect = correctimput(a,arraylength); повтор ввода,если данные введены неверно
Console.WriteLine();

if (arraylengthconvert<0) // проверка на случай ввода отрицательного значения
{
    arraylengthconvert=arraylengthconvert*(-1);
    Console.WriteLine("вы ввели отрицательное значение данные будут взяты по модулю [{0}]" , arraylengthconvert);
    Console.WriteLine();
}

Console.WriteLine("введите значение начала для диапазона случайных чисел");
string Nmin = imput();
int Nminconvert=Convert.ToInt32(correctimput(whatuserEntered(Nmin),Nmin)); // проверка корректного ввода данных и перевод строки в число
// int b = whatuserEntered(Nmin);
// string Nmincorrect = correctimput(b,Nmin);

Console.WriteLine("Введите конечное значение для диапазона");
string Nmax = imput();
int Nmaxconvert=Convert.ToInt32(correctimput(whatuserEntered(Nmax),Nmax)); //проверка корректного ввода данных и перевод строки в число
// int c = whatuserEntered(Nmax);
// string Nmaxcorrect = correctimput(c,Nmax);
 
if (Nmaxconvert<Nminconvert) // проверка ввода корректного диапазона
{
int temp = 0;
temp = Nmaxconvert;
Nmaxconvert = Nminconvert;
Nminconvert =temp;
Console.WriteLine("введено значение меньше начала диапазона, выбранный диапазон скорректирован [{0}:{1}]",Nminconvert,Nmaxconvert);
}

// формирование массива случайных чисел по введенным значениям и пустого массива под четные числа
int[] array = createarray(arraylengthconvert, Nminconvert, Nmaxconvert);
int[] arrayeven = createarray(arraylengthconvert, 0, 0);
int  CountArrayEven = 0;
Console.WriteLine();
showarray(array,arraylengthconvert,"массив случайных чисел сформирован");

//формирование масиива из четных данных
for (int i = 0; i < arraylengthconvert; i++) 
{
    if (array[i]%2==0)
    {
        arrayeven[CountArrayEven]=array[i];
        CountArrayEven++;
    }
}
showarray(arrayeven,CountArrayEven,"массив из четных чисел сформирован"); 
Console.WriteLine();
