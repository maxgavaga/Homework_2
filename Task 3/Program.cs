// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет является ли этот день выходным.

System.Console.Write("Введите цифру, обозначающую день недели: ");
int Day = Convert.ToInt32 (Console.ReadLine());
void DaySearch (int Day) {
  if (Day == 6 || Day == 7) {
  Console.WriteLine("День соответствущий введенной Вами цифре, является выходным!");
  }
  else if (Day < 1 || Day > 7) {
    Console.WriteLine("Такого дня недели еще не придумали :))");
  }
  else Console.WriteLine("День соответствующий введенной Вами цифре, не является выходным.");
}
DaySearch(Day);