// 1. Сумма элементов матрицы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 1001);
        }
    }
}
// 1. Сумма элементов матрицы
int SumElementMatrix(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
    }
    return sum;
}
//  2. Произведение элементов матрицы
int MultiplicationElementMatrix(int[,] matr)
{
    int Multiplication = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Multiplication *= matr[i, j];
        }
    }
    return Multiplication;
}
// 3. Максимальный элемент матрицы
void MAXElement(int[,] matr)
{
    int Max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > Max)
            {
                Max = matr[i, j];
            }
        }
    }
    Console.Write("Максимальный элемент массива: " + Max);
}






Console.WriteLine("Enter number rows:");
int NumberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number columns:");
int NumberColumns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[NumberRows, NumberColumns];
FillArray(matrix);
PrintArray(matrix);
int TotalSum = SumElementMatrix(matrix);                       // Вывод суммы
Console.Write("Сумма элементов матрицы равна: " + TotalSum + "\n");
int TotalMultiplication = MultiplicationElementMatrix(matrix);
Console.Write("Произведение элементов матрицы равно: " + TotalMultiplication + "\n");    // Вывод произведения
MAXElement(matrix);                   // нахождение и вывод максимального элемента

