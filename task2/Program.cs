// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// это такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] array = GetArr();
GetArrPosition("Введите позицию элемента:", array);

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
            Console.Write(arr[i,j] + "   ");
            } 
            Console.WriteLine();
        }
        return arr;
    }

void GetArrPosition(string text, int[,] arr){ 
Console.WriteLine(text);
int rows = inputNumber("М = ");
int colums = inputNumber("N = "); 

    if (rows < arr.GetLength(0) && colums < arr.GetLength(1))
    {
        Console.WriteLine(arr[rows, colums]);
    }
    else 
    {
        Console.WriteLine($"{rows} {colums} -> такого числа в массиве нет");
    }

    int inputNumber(string str) // локальная функция
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
}
