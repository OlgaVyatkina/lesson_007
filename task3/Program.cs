// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = GetArr();
GetSum("Среднее арифметическое элементов равно:", array);

int[,] GetArr(){
int rows = new Random().Next(2,10);
int colums = new Random().Next(2,10);
int [,] arr = new int[rows,colums];
    Random rand = new();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(0,10);
            Console.Write(arr[i,j] + "     ");
            } 
            Console.WriteLine();
        }
        return arr;
    }

void GetSum(string text, int[,] arr){ 
Console.WriteLine(text);
double middle = 0; 
double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
               sum += arr[j,i];
            } 
            middle = Math.Round(sum /(arr.GetLength(0)),2); 
            Console.Write(middle + "    ");
            sum = 0;
        } 
}

