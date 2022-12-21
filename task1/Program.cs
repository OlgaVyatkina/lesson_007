// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер массива M x N");
int m = inputNumber("М = ");
int n = inputNumber("N = ");
double [,] array = new double[m,n];
GetArr(array);


void GetArr(double[,] arr){
    Random rand = new();
        for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(rand.Next(0,10) + rand.NextDouble(),1);
            Console.Write(array[i,j] + "   ");
            } 
            Console.WriteLine();
        }
    }

int inputNumber(string str)
{
    int number;
    
    while (true)
    {
        System.Console.Write(str);
        string? text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

