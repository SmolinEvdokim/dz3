// Задача 1

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.Write("Vvedite 5tizna4noie 4islo: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4])
  if (number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - palindrom");
  }
  else Console.WriteLine($"Ваше число: {number} - ne palindrom.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Fehler!!!");