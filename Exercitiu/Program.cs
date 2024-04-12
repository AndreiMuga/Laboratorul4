//Write a method that prints if a number read from the console is positive or negative
class Program
{
    static void Main(string[] args)
    {
        PrintSign();
    }
 
    static void PrintSign()
        {
            Console.WriteLine("Scrieti un numar de la tastatura: ");

            int primulNumar;
            primulNumar = int.Parse(Console.ReadLine());

            if (primulNumar > 0)
            {
                Console.WriteLine("Numarul este pozitiv ");
            }
            else if (primulNumar < 0)
            {
                Console.WriteLine("Numarul este negativ ");

            }
            else
            {
                Console.WriteLine("Numarul nu poate fi 0");
            }
        }
    
}

