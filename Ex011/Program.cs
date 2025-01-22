namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o valor da casa?");
            double valorCasa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o seu salário?");
            double seuSal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantos anos para pagar?");
            int anos = Convert.ToInt32(Console.ReadLine());

            int meses = anos * 12;
            double presMensal = valorCasa / meses;
            double limitePres = seuSal * 0.3;

            if (presMensal > limitePres)
        
            {
                Console.WriteLine("Empréstimo negado");
            }
            else { Console.WriteLine("Empréstimo aceito"); 
            }

            
        

                    
        }
    }
}
