namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double nota_final = 70;
            string resultado = "Reprovado";

            if (nota_final >= 60)
            {
                resultado = "Aprovado";
                Console.WriteLine("O aluno foi {0}.", resultado);
            }
            else
            {
                Console.WriteLine("O aluno foi {0}.", resultado);
            }




        }
    }
}


