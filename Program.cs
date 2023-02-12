bool IsWork = true;

while (IsWork)

{
    Console.WriteLine("Для завершения работы введите: -1");
    Console.Write("Введите номер задачи ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
                {
                    Task_1();

                    void Task_1()
                    {
                        int firstnum = ReadInt("первое число");
                        int secondnum = ReadInt("второе число");

                        Calculate(firstnum, secondnum);
                    }

                    int ReadInt(string argument)
                    {
                        Console.Write($"Введите {argument}: ");
                        int number;

                        while(!int.TryParse(Console.ReadLine(),out number))
                        {
                            Console.WriteLine("вы ввели не число");
                        }
                        
                        return number;
                    }

                    void Calculate(int firstnum, int secondnum)
                    {
                        int counter = firstnum;
                        for (int i = 2; i <= secondnum; i++)
                        {
                            counter *= firstnum;
                        }

                        Console.WriteLine($"{counter}");
                    }
                    break;
                }
            case 2:
            {
                Task_2();

                void Task_2()
                {
                    int number = ReadInt("число");

                    Calculate2(number);
                }

                int ReadInt(string argument)
                {
                    Console.Write($"Введите {argument}: ");
                    int number;

                    while(!int.TryParse(Console.ReadLine(),out number))
                    {
                        Console.WriteLine("вы ввели не число");
                    }
                    
                    return number;
                }

                void Calculate2(int number)
                {
                    string digitString = number.ToString();
                    int len = digitString.Length;
                    int counter = 0;
                    int temp = number;
                    for (int i = 0; i < len; i ++)
                    {
                        counter = counter + temp % 10;
                        temp = temp / 10;
                    }
                    Console.WriteLine($"{counter}");
                }
                break;
            }

            case -1: IsWork = false; break;
        }
    }
}