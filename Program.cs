Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 8)
{
    Console.WriteLine("Это не день недели");
}

else if (number >= 6 && number < 8)
{
   Console.WriteLine("Выходной"); 
}

else if (number >= 1 && number < 7)
{
   Console.WriteLine("Рабочий"); 
}

