namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual é o se sálario?");
            double sal = Convert.ToDouble(Console.ReadLine());

            double aumento;

            if (sal > 2500) 
            {
                aumento = sal * 0.05;
                Console.WriteLine("Acrécimo de 5%");
            }
        
            else if (sal > 1250)
            {
                aumento = sal * 0.10;
                Console.WriteLine("Acrécimo de 10%");
            }

            else
            {
                aumento = sal * 0.15;
                Console.WriteLine("Acrécimo de 15%");
            }

            double novosal = sal + aumento;
            Console.WriteLine("Seu novo salário é: " + novosal);

        }
    }
}
