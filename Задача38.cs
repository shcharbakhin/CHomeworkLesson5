{
    Console.WriteLine("Введите размер массива случайных чисел:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[s];
    Random sluch = new Random();
    Console.WriteLine("Все значения массива:");
    int i;
    int max = 0;
    int raznica;
    for (i = 0; i < s; i++)
    {
        massiv[i] = sluch.Next(1000);
        Console.Write(massiv[i]);
        Console.Write(" ");
    }
    int min = massiv[0];
    for (i = 0; i < s; i++)
    {
        if (max < massiv[i])
        {
            max = massiv[i];
        }
        else
        {
        }
    
    for (int j = 0; j < s; j++)
    {
        if (min > massiv[j])
        {
            min = massiv[j];
            Console.WriteLine(min);
        }
        else
        {
        }
    }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Максимальное значения массива:");
    Console.WriteLine(max);
    Console.WriteLine(" ");
    Console.WriteLine("Минимальное значения массива:");
    Console.WriteLine(min);
    raznica = max - min;
    Console.WriteLine(" ");
    Console.WriteLine("Разница между максимальным и минимальным значением массива:");
    Console.WriteLine(raznica);
}