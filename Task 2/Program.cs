// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit3 = Convert.ToString(number);
 if (digit3.Length > 2)
{
    System.Console.WriteLine("Третья цифра заданного Вами числа: " +digit3[2]);
}
 else
 {
    System.Console.WriteLine("Третья цифра в введенном Вами числе отсутствует!");
}