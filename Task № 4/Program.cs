/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/
System.Console.WriteLine("введите 1 цифру");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 2 цифру"); 
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите 3 цифру");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA == numberB & numberA == numberC)
 {
     System.Console.WriteLine("Одинаковые цифры");
 }

else if (numberA>numberB & numberA>numberC)
{
  max = numberA;
  System.Console.WriteLine("максимальное из этих чисел max " + numberA );
}
else if (numberA<numberB & numberB > numberC)
{
  max = numberB;
  System.Console.WriteLine("максимальное из этих чисел max " + numberB );

}
else {
    max = numberC;
  System.Console.WriteLine("максимальное из этих чисел max " + numberC );

}