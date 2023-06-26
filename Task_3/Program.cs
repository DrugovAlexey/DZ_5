
double[] GenerateArray(int len, double min, double max)
{
    double[] list1 = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(-10,10) + rnd.NextDouble();
    }
    return list1;
}

void PrintArrey(double[] Arrey)
{
    for (int i = 0; i < Arrey.Length; i++)
    {
        System.Console.Write(Arrey[i] + "\t");
    }
}

(double, double) MinMax(double[] number)
{
    double min = number[0];
    double max = number[0];

    for (int index = 0; index < number.Length; index++)
    {
        if (min > number[index])
        {
            min = number[index];
        }
        if (max < number[index])
        {
            max = number[index];
        }
    }
    return (max, min);
}

double[] number = GenerateArray(6, 0, 10);
PrintArrey(number);

(double max, double min) = MinMax(number);


double Difference = max - min;

System.Console.WriteLine($"\n{min} - минимальный элемент массива, {max} - максимальный элемент массива. Разница = {max - min}");
