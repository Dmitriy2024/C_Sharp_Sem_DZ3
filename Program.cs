//Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное чесло: ");
var Number =Console.ReadLine();
var NumberP = Number!.Length;

if (NumberP == 5)
{
  if(Number[0] == Number[4] && Number[1] == Number[3])
    {
      Console.Write("Число: " + Number + " ,палендром.");
    }
    else
    {
      Console.Write("Число: " + Number + "  не является палендромом.");
    }
}    
  else
  {
      Console.Write("Ошибка! Введите пятизначное число!");

  }  


/*
// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
  Console.Write("Введите координату точки А по оси X=");
  int x1= Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату точки А по оси Y=");
  int y1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату точки А по оси Z=");
  int z1 = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите координату точки В по оси X=");
  int x2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату точки В по оси Y=");
  int y2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите координату точки В по оси Z=");
  int z2 = Convert.ToInt32(Console.ReadLine());  

  double d = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
  Console.WriteLine($"Растояние между точками А:({x1}, {y1}, {z1}) и В:({x2},{y2}, {z2}) равно: {Math.Round(d,2)}");
*/


/*
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
*/



