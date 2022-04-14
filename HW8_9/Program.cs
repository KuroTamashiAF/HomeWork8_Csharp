// Сумма элементов побочной диагонали матрицы
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
void SumElemtntSecondaryDiagonal(int[,] matr)
{
    int Sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(i+j==matr.GetLength(1)-1)
            {
                Sum+=matr[i,j];
            }
        }
    }
    Console.Write(Sum);
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
SumElemtntSecondaryDiagonal(matrix);
