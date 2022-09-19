Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("64) Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        System.Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        System.Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0:  break;
            case 64: NaturalNumbers(); break;
            case 66: SumNaturalNumbers(); break;
            case 68: AckermanFunction(); break;
            default: System.Console.WriteLine("error"); break;
        }
    }
}

int SetNumber(string numberName)
{
    Console.Write($"Выберите номер задачи {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NaturalNumbers()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());   

    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());  

    int len = number2 - number1;

    int[] array = new int[len+1];
    
    for (int i = 0; i < len+1; i++)
        {
            array[i] = number1;
            number1++;
        }
        Console.WriteLine($"Натуральные числа в промежутке от M до N: {String.Join(", ", array)}");
}

void SumNaturalNumbers()
{
    Console.WriteLine("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());   

    Console.WriteLine("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());  

    int len = number2 - number1;
    int sum = 0;

    int[] array = new int[len+1];
    
    for (int i = 0; i < len+1; i++)
        {
            array[i] = number1;
            sum = sum + number1;
            number1++;
        }
        Console.WriteLine($"Натуральные числа в промежутке от M до N: {String.Join(", ", array)}, сумма натуральных чисел: {sum}");    
}

void AckermanFunction()
{

int Ackerman(int n, int m)
{
   // Console.WriteLine("Введите первое неотрицательное целое число: ");
    //int n = Convert.ToInt32(Console.ReadLine());   

   // Console.WriteLine("Введите второе неотрицательное целое число: ");
   // int m = Convert.ToInt32(Console.ReadLine());  

    if (n == 0)
     {
        return m + 1;
     }
     
    else if ((n != 0) && (m == 0))
    {
        return Ackerman(n - 1, 1);
    }

    else
    {
        return Ackerman(n - 1, Ackerman(n, m - 1));
    }
   
} 
Console.WriteLine($"Результат вычисления функции Аккермана: {Ackerman(3, 3)}");  
}
     

