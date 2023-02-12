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
                
                break;
            }
            case -1: IsWork = false; break;
        }
    }
}