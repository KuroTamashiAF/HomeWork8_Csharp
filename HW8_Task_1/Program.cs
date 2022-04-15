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
//9. Сумма элементов побочной диагонали матрицы
void SumElemtntSecondaryDiagonal(int[,] matr)
{
    int Sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i + j == matr.GetLength(1) - 1)
            {
                Sum += matr[i, j];
            }
        }
    }
    Console.Write("Сумма элементов побочной диагонали равна: " + Sum + "\n");
}
//10. Произведение элементов побочной диагонали матрицы
void MultiplicationElementOnSecondaryDiagonale(int[,] matr)
{
    int Multiplication = 1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i + j == matr.GetLength(1) - 1)
            {
                Multiplication *= matr[i, j];
            }
        }
    }
    Console.Write("Произведение елементов побочной диагонали равно: " + Multiplication + "\n");
}
// 11. Максимальный элемент, расположенный на побочной диагонали матрицы
void MaxElementOnSecondaryDiagonale(int[,] matr)
{
    int Max = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i + j == matr.GetLength(1) - 1)
            {
                if (matr[i, j] > Max)
                {
                    Max = matr[i, j];
                }
            }
        }
    }
    Console.Write("Максимальный элемент побочной диагонали равен: " + Max + "\n");
}
// 12. Минимальный элемент, расположенный на побочной диагонали матрицы
void MinElementOnSecondaryDiagonale(int[,] matr)
{
    int Min = matr[0, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i + j == matr.GetLength(1) - 1)
            {
                if (matr[i, j] < Min)
                {
                    Min = matr[i, j];
                }
            }
        }
    }
    Console.Write("Минимальный элемент побочной диагонали равен: " + Min + "\n");
}
//13. Поиска минимального из максимальных элементов матрицы, 
//то есть найти максимальный элемент в каждой из строк матрицы и из них выбрать минимальный
void MaxAndMinEveryRows(int[,] matr)
{
    int[] matrMax = new int[matr.GetLength(0)];
    int[] matrMin = new int[matr.GetLength(0)];
    int Max, Min;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Max = matr[i, 0];
        Min = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > Max)
            {
                Max = matr[i, j];
            }
            if (matr[i, j] < Min)
            {
                Min = matr[i, j];
            }
        }
        // Console.WriteLine($"Максимальное значанение строки {i + 1} равно {Max} ");
        // Console.WriteLine($"Минимальное  значанение строки {i + 1} равно {Min}");
        matrMax[i] = Max;
        //Console.Write(matrMax[i] + " ");
        matrMin[i] = Min;
        //Console.Write(matrMin[i] + " ");
    }
    int matrixMax = matrMax[0];
    int matrixMin = matrMin[0];
    for (int k = 0; k < matrMax.GetLength(0); k++)
    {
        if (matrMax[k] > matrixMax)
        {
            matrixMax = matrMax[k];
        }
        if (matrMin[k] < matrixMin)
        {
            matrixMin = matrMin[k];
        }
    }
    Console.Write("Максимальное значение матрицы равно: " + matrixMax + "\n");
    Console.Write("Минимальное значение матрицы равно: " + matrixMin + "\n");
}
// 14. Транспонирование для квадратной матрицы, 
//то есть переворот матрицы относительно главной диагонали
int[,] MatrixTransposition(int[,] matr, int NumberRow, int NumberColumns)
{
    int[,] TransposedMatrix = new int[NumberColumns, NumberRow];
    for (int i = 0; i < TransposedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < TransposedMatrix.GetLength(1); j++)
        {
            TransposedMatrix[i, j] = matr[j, i];
        }
    }
    return TransposedMatrix;
}
// 15. Сумма двух матриц одинаковых размерностей.
void SumMatrix(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(0) == matr2.GetLength(0) && matr1.GetLength(1) == matr2.GetLength(1))
    {
        int[,] SumMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr1.GetLength(1); j++)
            {
                SumMatr[i, j] = matr1[i, j] + matr2[i, j];
                Console.Write(SumMatr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.Write("Данные матрицы нельзя сложить т.к они разных размерностей" + "\n");
    }
}
Console.Write("Enter number rows Matrix 1: ");
int NumberRows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number columns Matrix 1: ");
int NumberColumns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the lower bound of the array Matrix 1: ");
int LowerBound1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the upper bound of the array Matrix 1: ");
int UpperBound1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[NumberRows1, NumberColumns1];
FillArray(matrix1, LowerBound1, UpperBound1);
Console.Write("Сгенерированная по данным Матрица: " + "\n");
PrintArray(matrix1);
int TotalSum = SumElementMatrix(matrix1);                       // Вывод суммы
Console.Write("Сумма элементов матрицы равна: " + TotalSum + "\n");
long TotalMultiplication = MultiplicationElementMatrix(matrix1);
Console.Write("Произведение элементов матрицы равно: " + TotalMultiplication + "\n");    // Вывод произведения
MAXElement(matrix1);                   // нахождение и вывод максимального элемента
MinElement(matrix1);                   // нахождение и вывод минимального элемента
SumElementMainDiagonal(matrix1);       // нахождение суммы главной диагонал и и её вывод
MultiplicationElementMainDiagonal(matrix1); // нахождение произведения элементов главной диагонали и вывод
MaxElementOnMainDiagonal(matrix1);       // нахождение максимального элемента гланой диагонали и вывод 
MinElementOnMainDiagonale(matrix1);      // нахождение минимального элемента главной диагонали и вывод
SumElemtntSecondaryDiagonal(matrix1);    // нахождение суммы элементов побочной диагонали и её вывод
MultiplicationElementOnSecondaryDiagonale(matrix1); // нахождение произведения элементов побойной диагонали и вывод
MaxElementOnSecondaryDiagonale(matrix1);   // нахождение максимального элемента побочной диагонали и вывод
MinElementOnSecondaryDiagonale(matrix1);   // нахождение минимального элемента побочной диагонали и вывод 
MaxAndMinEveryRows(matrix1);         // нахождение максимального и минимального элементов матрицы и их вывод
int[,] TransposedMatrix = MatrixTransposition(matrix1, NumberRows1, NumberColumns1); // Транспонирование матрицы
Console.Write("Транспонированная матрица: " + "\n");
PrintArray(TransposedMatrix);       // Вывод транспонированной матрицы на экран 
Console.Write("Enter number rows Matrix 2: ");
int NumberRows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number columns Matrix 2: ");
int NumberColumns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the lower bound of the array Matrix 2: ");
int LowerBound2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the upper bound of the array Matrix 2: ");
int UpperBound2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[NumberRows2, NumberColumns2];
FillArray(matrix2, LowerBound2, UpperBound2);
Console.Write("Сгенерированная по данным Матрица: " + "\n");
PrintArray(matrix2);
Console.Write("Сумма двух матриц равна: "+"\n");
SumMatrix(matrix1, matrix2);                                 // сумма 2 матриц и их вывод на экран 
