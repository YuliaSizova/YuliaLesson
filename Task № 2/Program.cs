/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

 System.Console.WriteLine("введите 1 цифру");
int numberA = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("введите 2 цифру");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
 if (numberA == numberB)
{
    System.Console.WriteLine("цифры одинаковые");
}
 else if (numberA > numberB)
 {
    max = numberA;
    System.Console.WriteLine("max " + numberA);
 }
 else 
 {
    max = numberB;
    System.Console.WriteLine("max " + numberB);
 }