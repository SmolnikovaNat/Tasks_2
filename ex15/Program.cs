namespace HelloWorld
{
class Program
{
    public static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход цифру, обозначающую день недели
        //и проверяет является ли этот день выходным

             
        Console.WriteLine("Введите число недели: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x==1)
        {
            Console.WriteLine("нет");
        }
        if (x==2)
        {
            Console.WriteLine("нет");
        }
        if (x==3)
        {
            Console.WriteLine("нет");
        }
        if (x==4)
        {
            Console.WriteLine("нет");
        }
        if (x==5)
        {
            Console.WriteLine("нет");
        }if (x==6)
        {
            Console.WriteLine("да");            
        }
        if (x==7)
        {
            Console.WriteLine("да");
        }
       
    }
}
}
