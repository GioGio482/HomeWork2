// 1.

// Console.WriteLine("Введите число: ");

// if(int.TryParse(Console.ReadLine(), out int number))
// {
//     int a = 0;
//     a = number;
//     a = a / 10 % 10;
//     Console.WriteLine("Второй цифрой с конца является "+ a);
// }

// 2.

// Console.WriteLine("Введите число: ");

// if(int.TryParse(Console.ReadLine(), out int number))
// {
//     if (number > 99)
//     {
//         int a = 0;
//         a = number;
//         for (int i = 1; i <= 2; i++)
//         {
//             a = a / 10;
//         }
//         a = a % 10;
//         Console.WriteLine(+ a);
//     }
//     else Console.WriteLine("Третьей цифры нет");
// }

// 3.

// Console.WriteLine("Введите номер дня недели : ");
// if(int.TryParse(Console.ReadLine(), out int i))
// {
//     switch (i)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
    
//     case 2:
//         Console.WriteLine("Вторник");
//         break;

//     case 3:
//         Console.WriteLine("Среда");
//         break;

//     case 4:
//         Console.WriteLine("Четверг");
//         break;

//     case 5:
//         Console.WriteLine("Пятница");
//         break;

//     case 6:
//         Console.WriteLine("Суббота");
//         Console.WriteLine("Выходной день");
//         break;

//     case 7:
//         Console.WriteLine("Воскресенье");
//         Console.WriteLine("Выходной день");
//         break;
    
//     default:
//         Console.WriteLine("Вы ввели некорректный номер дня недели");
//         break;
// }
// }
// else
// {
//     Console.WriteLine("Вы ввели не целое число");
// }
