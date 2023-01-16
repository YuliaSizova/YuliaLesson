/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
System.Console.WriteLine("Введите число от 1");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
if (number<1)
{
    System.Console.Write("число не соответствует условию");
}
else
{
while (current<=number)
{
 if (current % 2 == 0)
{
    System.Console.Write(current + " ");
}
current++;
   }
}