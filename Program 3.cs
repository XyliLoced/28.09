Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

void mas(int a)
{
    Random rand = new Random();                      //random
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"[{randomArray[i]:F2}] ");
    }

}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])          //Разница массивов
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

mas(a); // Итог
Console.Write($"разница= {raz(randomArray):F2}");
//Немного не понял задания c вещественными чиселами, но вроде бы основное выполнил
//точнее не разобрался чем отличаються от обычных, как я понял лежать в определённом отрезке и дробные