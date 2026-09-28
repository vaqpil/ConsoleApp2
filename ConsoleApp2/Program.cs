////                                                           5
//Console.WriteLine("Выбери число");
//Console.WriteLine("Ведите время");

//int hour = Convert.ToInt16(Console.ReadLine());
//if (hour >= 6 && hour < 12)
//{   
//    Console.WriteLine("Доброе утро");
//}         
//else if (hour >= 12 && hour < 18)
//{   
//    Console.WriteLine("Добрый день");
//}   
//else if (hour >= 18 && hour < 23)
//{   
//    Console.WriteLine("Добрый вечер");
//}   
//else if  (hour >= 23 && hour == 0)
//{   
//    Console.WriteLine("Доброй ночи");
//}    
//else if  (hour >= 1 && hour < 6)
//{   
//    Console.WriteLine("Доброй ночи");
//}   
//else if (hour == 24)
//{   
//    Console.WriteLine("Полночь");
//}   
//else
//{   
//    Console.WriteLine("Больше 24 не бывает");
//}   





//Console.WriteLine("Ведите команду");
//Console.WriteLine("1.Вход в игру");
//Console.WriteLine("2.Загрузить игру");
//Console.WriteLine("3.Выход из игры");
//string choce = Console.ReadLine();

//switch(choce)
//{
//    case "1":
//        Console.WriteLine("Выполнен вход в игру");
//        break;

//    case "2":
//        Console.WriteLine("Загрузиткa игры");
//        break;

//    case "3":
//        Console.WriteLine("Выход из игры");
//        break;
//    default: Console.WriteLine("Введите значение от 1 до 3");
//        break;
//}




//for ( int i = 1; i <= 100; i++)
//{
//    Console.WriteLine($"Текущее значение {i}");
//}




//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue; // пропускаем остаток тела
//    }
//    Console.WriteLine(1);
//}



//for (int y = 1; y <= 10; y++)
//{
//    if (y % 3 == 0)
//    {
//        continue;
//    }
//    Console.WriteLine(y);
//}



//for (int z = 10; z > 0; z--)
//{
//    Console.WriteLine(z);
//}




//for (int i = 1; i < 11; i++)
//{
//    for (int j = 1; j < 11; j++)
//    {
//        Console.Write($"{i * j}\t");
//    }
//    Console.WriteLine();
//}




Random random = new Random();
int secretnumber = random.Next(1, 100);

int usGess = 0;
int atters = 0;

Console.WriteLine("1 100");

while (usGess != secretnumber)
{
    Console.WriteLine("ваша догатка");
    usGess = Convert.ToInt32(Console.ReadLine());
    atters++;

    if (usGess < secretnumber)
    {
        Console.WriteLine(">");
    }
    else if (usGess > secretnumber)
    {  
        Console.WriteLine("<");
    }

}
Console.WriteLine("оггодал");
Console.WriteLine("конец");
Console.ReadLine();