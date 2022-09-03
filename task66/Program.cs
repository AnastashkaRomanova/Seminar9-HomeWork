// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 56
// M = 4; N = 8. -> 18


Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int Summ(int userNumber1, int userNumber2)
{

    if (userNumber1 <= userNumber2)
    { 
        if (userNumber1 % 2 == 0)
    {
        return userNumber1 + Summ(userNumber1 + 2, userNumber2);
    }
    else
    {
        userNumber1=userNumber1+1;
        return userNumber1 + Summ(userNumber1 + 2, userNumber2);
    }
    }
    else
        
    {
        return 0;
    }
}


Console.WriteLine(Summ(userNumber1, userNumber2));