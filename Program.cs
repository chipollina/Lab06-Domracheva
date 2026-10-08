// Задание 1.1
// for (int i =10; i>=1; i--)
// {
//     Console.WriteLine(i);
// }

// Задание 1.2
// for (int i =2; i<=50; i+=2)
// {
//     Console.WriteLine(i);
// }

// Задание 2
// int count = 0;
// int c7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         count += i;
//     }
//     if (i % 7 == 0)
//     {
//         c7++;
//     }
// }
// Console.WriteLine($"Сумма чисел, кратных 3:{count}");
// Console.WriteLine($"количесво чисел, которые делятся на 7:{c7}");

// Задание 3 
// int number = Convert.ToInt32(Console.ReadLine());
// int total1 = 0;
// int total2 = 0;
// while (number != 0)
// {
//     if (number >= 0 )
//     {
//         total1 ++;
//     } 
//     if (number <= 0 )
//     {
//         total2 ++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($" введено положительных чисел: {total1}");
// Console.WriteLine($" введено отрицательных чисел: {total2}");

// Задание 4
// string password;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     for (int i = 1; i <=3 ; i++)
//     {
//         if (password == "qwerty")
//         {
//             Console.Write("Доступ разрешен");
//             break;
//         }
//         else
//         {
//             Console.Write("попытки закончились");
//         }
//     }
// }

//Задание 5
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} x {1} = {number * 1}");
// Console.WriteLine($"{number} x {2} = {number * 2}");
// Console.WriteLine($"{number} x {3} = {number * 3}");
// Console.WriteLine($"{number} x {4} = {number * 4}");
// Console.WriteLine($"{number} x {5} = {number * 5}");
// Console.WriteLine($"{number} x {6} = {number * 6}");
// Console.WriteLine($"{number} x {7} = {number * 7}");
// Console.WriteLine($"{number} x {8} = {number * 8}");
// Console.WriteLine($"{number} x {9} = {number * 9}");
// Console.WriteLine($"{number} x {10} = {number*10}");

//Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//     {
//         continue;
//     }
//     if (i % 10 == 0 )
//     {
//         break;
//     }
//     if (i >20 )
//     {
//         break;
//     }
//     Console.WriteLine(i);
// }

//"Угадай число"

int secret = 42;
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 5; i++)
    if (i == secret)
    {
        Console.Write("правильно");
    }
    else if (i > secret)
    {
        Console.Write("меньше");
    }
    else if (i < secret)
    {
        Console.Write("больше");
    }