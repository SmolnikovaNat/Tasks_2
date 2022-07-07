namespace HelloWorld
{
class Program
{
    public static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход трехзначное число и
        // на выходе показывает вторую цифру этого числа
        Console.WriteLine("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        string str = number.ToString();
        char ch = str[1];
        Console.WriteLine(ch);
    }
}
}

    
    
        