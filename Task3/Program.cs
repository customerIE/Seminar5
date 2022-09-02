// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
int dif=0; //разница между максимальным и минимальным элементов массива.;
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    array[i] = rnd.Next(1,100);
}
foreach(int el in array) Console.Write($"_" + el);
// Массив трехзначных чисел array[] - готов;
int MaxAr(int[] array1) //Поиск макс-го эл-та массива;
{
    int max = array1[0];
    int length1=array.Length;
    for(int i=0; i<length1; i++)
    {
        if(max<array1[i])
        {
            max = array1[i];
        }
    } 
    return max;
}
int MinAr(int[] array2) //Поиск мин-го эл-та массива;
{
    int min = array2[0];
    int length2=array2.Length;
    for(int i=0; i<length2; i++)
    {
        if(min>array2[i])
        {
            min = array2[i];
        }
    } 
    return min;
}
dif = MaxAr(array) - MinAr(array);
Console.WriteLine();
Console.WriteLine(MaxAr(array) + " - " + MinAr(array) + " = " + dif);

