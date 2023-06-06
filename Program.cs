//Программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N: ");
var stringN = Console.ReadLine();
int n;
bool isN = int.TryParse( stringN, out n );

if (isN)

for (int i = 1; i <= n; i++)
{
  Console.Write(Math.Pow(i, 3) + "\t");
}
else
{
    Console.Write("Ошибка! Повторите ввод  ");
}




