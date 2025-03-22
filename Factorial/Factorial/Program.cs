// https://dotnettutorials.net/lesson/factorial-program-in-csharp/
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= num; i++)
{
  factorial *= i;
}
Console.Write($"{factorial}");
