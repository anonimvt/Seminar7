Console.Clear();
int n = InputInt("Введите номер строки: ");
int m = InputInt("Введите номер столбца: ");
int [,] array = new int [10,10];
FillArrayRandomarray(array);

if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента - {n} строки, и {m} - столбца равно {array[n-1,m-1]}");
}

PrintArray(array);

void FillArrayRandomarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "  ");
        }   
        Console.Write("]");
        Console.WriteLine("\t"); 
    }
}

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}