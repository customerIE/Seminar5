// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
int col=0; //количество четных чисел;
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
Random rnd = new Random();
for (int i=0; i<N; i++)
{
    array[i] = rnd.Next(1,1000);
}
foreach(int el in array) Console.Write($"_" + el);
// Массив трехзначных чисел array[] - готов;
foreach(int el in array)
{
    if( el%2 == 0)
    {col++;}
} 
Console.WriteLine();
Console.WriteLine("Кол-во четных чисел в массиве = " + col);
