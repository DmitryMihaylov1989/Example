int numberA = new Random().Next(1,10); // 1234... 9
Console.WriteLine("Первое число"); 
Console.WriteLine(numberA );
int numberB = new Random().Next(2,3); // 23 25 27... 28
Console.WriteLine("Второе число");
Console.WriteLine(numberB );
Console.WriteLine("Сумма");
int sum = numberA + numberB;
Console.WriteLine(sum);