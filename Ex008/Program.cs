namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Para saber se o numero é par ou impar é só fazer um if else e dividir o numero por 2. Se o modulo da operação for igual a zero é par, senão é impar
            Console.WriteLine("Informe um número");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }


        }
    }
}
