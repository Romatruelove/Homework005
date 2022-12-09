Console.WriteLine("Введи число элементов в массиве:");
void MaxMinNumbers()
{
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble()*100;
    foreach (double el in array)
        Console.Write($"{el} ");
        Console.WriteLine();

        double min = array[0];
        double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i]<min)
        {
            min = array[i];
        }
        else if(array[i]>max)
        {
            max = array[i];
        }
    Console.WriteLine($"{max-min}");
}
MaxMinNumbers();