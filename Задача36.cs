{
    Console.WriteLine("Введите размер массива случайных чисел:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[s];
    Random sluch = new Random();
    Console.WriteLine("Все значения массива:");
    int i;
    int sum = 0;
    for (i = 0; i < s; i++)
    {
        massiv[i] = sluch.Next(1000);
        Console.Write(massiv[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("Все нечетные значения массива:");
    for (i = 0; i < s; i++)
    {
        if (massiv[i] % 2 == 0)
        {
        }
        else
        {
            Console.Write(massiv[i]);
            Console.Write(" ");
            sum = sum + massiv[i];
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Cумма всех нечетных значений массива:");
    Console.WriteLine(sum);
}