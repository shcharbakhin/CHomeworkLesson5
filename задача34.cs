{
    Console.WriteLine("Введите размер массива случайных чисел:");
    int s = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[s];
    Random sluch = new Random();
    Console.WriteLine("Все значения массива:");
    int i;
    int chot = 0;
    for (i = 0; i < s; i++)
    {
        massiv[i] = sluch.Next(99, 1000);
        Console.Write(massiv[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
    Console.WriteLine("Все четные значения массива:");
    for (i = 0; i < s; i++)
    {
        if (massiv[i] % 2 == 0)
        {
            Console.Write(massiv[i]);
            Console.Write(" ");
            chot = chot + 1;
        }
        else
        {
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("Количество четных значений массива:");
    Console.WriteLine(chot);
}