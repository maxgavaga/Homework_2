// Напишите программу, которая принимает на вход трехзначное число,
// а на выходе показывает вторую цифру этого числа.

System.Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2 = Convert.ToString(number);
System.Console.WriteLine("Вторая цифра заданного число: "+number2[1]);