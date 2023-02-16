// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next (100,1000);
// int result = (number%100)/10;
// Console.WriteLine("Исходное число: "+ number + "вторая цифра: "+ result );


// Задача 13: 
// Напишите программу, которая выводит третью цифру 
// заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет
// 3267900 -> 6

// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7)
  {
  Console.WriteLine("этот день выходной -> да");
  }
 
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);