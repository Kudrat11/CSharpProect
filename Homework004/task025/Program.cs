/*Задача 25:
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)   325
2, 4 -> 16
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(numA, numB));
int sum = 1;
int count = numB;
for (int i = 0; i < 4; i++) 
{
    sum = numA * sum;
}
System.Console.WriteLine(sum);
