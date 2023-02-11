/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}



int number = GetNumber("Введите число");
int sum = 0;
while (number !=0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine($"Сумма цифр в числе {sum}");