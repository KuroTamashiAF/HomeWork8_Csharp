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
void FillArray(int[,] matr, int LowerBorder, int UpperBorder)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(LowerBorder, UpperBorder);
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
long MultiplicationElementMatrix(int[,] matr)
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
    Console.Write("Максимальный элемент массива: " + Max + "\n");
}
// 4. Минимальный элемент матрицы
void MinElement(int[,] matr)
{
    int Min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < Min)
            {
                Min = matr[i, j];
            }
        }
    }
    Console.Write("Минимальный элемент массива: " + Min + "\n");
}
// 5. Сумма элементов главной диагонали матрицы
void SumElementMainDiagonal(int[,] matr)
{
    int Sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                Sum += matr[i, j];
            }
        }
    }
    Console.Write("Сумма элементов главной диагонали равна: " + Sum + "\n");
}
// 6. Произведение элементов главной диагонали матрицы
void MultiplicationElementMainDiagonal(int[,] matr)
{
    long Multiplication = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                Multiplication *= matr[i, j];
            }
        }
    }
    Console.Write("Произведение элементов главной диагонали равна: " + Multiplication + "\n");
}
// 7. Максимальный элемент, расположенный на главной диагонали матрицы
void MaxElementOnMainDiagonal(int[,] matr)
{
    int Max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                if (matr[i, j] > Max)
                {
                    Max = matr[i, j];
                }
            }
        }
    }
    Console.Write("Максимальный элемент главной диагонали равен: " + Max + "\n");
}
// 8. Минимальный элемент, расположенный на главной диагонали матрицы
void MinElementOnMainDiagonale(int[,] matr)
{
    int Min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                if (matr[i, j] < Min)
                {
                    Min = matr[i, j];
                }
            }
        }
    }
    Console.Write("Минимальный элемент главной диагонали равен: " + Min + "\n");
}













Console.WriteLine("Enter number rows:");
int NumberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number columns:");
int NumberColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the lower bound of the array: ");
int LowerBound = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the upper bound of the array: ");
int UpperBound = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[NumberRows, NumberColumns];
FillArray(matrix, LowerBound, UpperBound);
PrintArray(matrix);
int TotalSum = SumElementMatrix(matrix);                       // Вывод суммы
Console.Write("Сумма элементов матрицы равна: " + TotalSum + "\n");
long TotalMultiplication = MultiplicationElementMatrix(matrix);
Console.Write("Произведение элементов матрицы равно: " + TotalMultiplication + "\n");    // Вывод произведения
MAXElement(matrix);                   // нахождение и вывод максимального элемента
MinElement(matrix);                   // нахождение и вывод минимального элемента
SumElementMainDiagonal(matrix);       // нахождение суммы главной диагонал и и её вывод
MultiplicationElementMainDiagonal(matrix); // нахождение произведения елементов главной диагонали и её вывод
MaxElementOnMainDiagonal(matrix);       // нахождение максимального элемента гланой диагонали и его вывод 
MinElementOnMainDiagonale(matrix);


