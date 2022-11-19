// Написать программу на языке С#, для Windows и Mac OS, 
// [в которую пользователь вводит два числа]
// [в которой записаны два числа]
// [два числа генерируются случайным образом]
// и получает сумму.

// int numberA = 3;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

int numberA = new Random().Next(1, 10); //1 2 3 4 5 ...9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);

