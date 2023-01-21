/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}
int x = Prompt("Введите число N: ");
//Math.Pow(x, 3);// где Х - наша переменная, а 3 - степень, в которую возводим
int i = 1;
while (i <= x)
{
    double r = Math.Pow(i, 3);
    System.Console.WriteLine($"Кубы числа от 1 до {i} равен " + r);
    i++;
}
