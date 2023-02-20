//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите номер дня недели");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday < 1 || weekday > 7){
    Console.WriteLine("Неверно введен номер");
}else if(weekday == 6 || weekday == 7){
    Console.WriteLine($"{weekday} - выходной день");
}else{
    Console.WriteLine($"{weekday} - будний день");
}