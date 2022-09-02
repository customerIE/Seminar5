// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму четных элементов, стоящих на нечётных позициях 
// (позиция - индекс элемента в массиве).
int sum=0; //количество четных чисел;
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    array[i] = rnd.Next(-1000,1000);
}
foreach(int el in array) Console.Write($"_" + el);
// Одномерный массив array[] - готов;
for(int i=1; i<N; i=i+2)
{
    if(array[i]%2 == 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма четных элементов = " + sum);