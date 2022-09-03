// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.

// M = 1; N = 5. -> ""5, 4, 3, 2, 1""

// M = 4; N = 8. -> ""8, 7, 6, 5, 4""




Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int userNumber1, int userNumber2)
{
        
        if (userNumber1 <= userNumber2 )
    {
    
        return $"{userNumber2} " + NumbersRec( userNumber1, userNumber2-1);
    }
    else
    {
        return String.Empty;
    }
}


Console.WriteLine(NumbersRec(userNumber1, userNumber2));