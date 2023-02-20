//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int n = 3;
int num3 = 0;
if (number < 100){
    Console.WriteLine($"У числа {number} нет третий цифры");
} else {
    for (int i = 1; i < n; i++){
        num = num/10;
    }

    if(num < 10) num3 = num;
    else num3 = num%10;
    
    Console.WriteLine($"У числа {number} третья цифра с начала {num3}");
}

