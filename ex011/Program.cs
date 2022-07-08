namespace HelloWorld
{
class Program
{
    public static void Main(string[] args)
    {
        //Напишите программу, которая выводит третью цифру заданного числа или сообщает,
        //что третьей цифры нет
        
        Console.WriteLine("Введите трехзначное число: ");
        int anyNumber = Convert.ToInt32(Console.ReadLine());
        string anyNumberText = Convert.ToString(anyNumber);
        if (anyNumberText.Length > 2)
            
        {
            Console.WriteLine(" -> " + anyNumberText[2]);
        }
        else
        {
            Console.WriteLine("-> третьей цифры нет");
        }
    }
}
}
