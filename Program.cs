// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMas(int numb)
{
    int[,] mas = new int[4,4];
    int startRowInd = 0;
    int startColInd = 0;
    int endRowInd = (mas.GetLength(0)-1);
    int endColInd = (mas.GetLength(1)-1);
    while (startRowInd <= endRowInd && startColInd <= endColInd)
    {
        for (int i = 0; i <= endColInd; i++)
        {
            mas[startRowInd,i] = numb++;
        }
        startRowInd++;
        for (int i = startRowInd; i <= endRowInd; i++)
        {
            mas[i,endColInd] = numb++;
        }
        endColInd--;
        for (int i = endColInd; i >= startColInd; i--)
        {
            mas[endRowInd,i] = numb++;
        }
        endRowInd--;
        for (int i = endRowInd; i >= startRowInd; i--)
        {
            mas[i,startColInd] = numb++;
        }
        startColInd++;
        numb--;
    }
    return mas;
}


int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numb = GetInput("Введите номер, с которого нужно заполнять массив: ");
Console.WriteLine();
int[,] mas = GenerateMas(numb);
Console.WriteLine();
PrintMas(mas);