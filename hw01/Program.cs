//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Ввкдите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000){
    int number10 = number/10;
    int TwoNumber = number10%10;
    Console.WriteLine($"{number} вторая цифра {TwoNumber}");
}else{
    Console.WriteLine("Неверно введено число");
}