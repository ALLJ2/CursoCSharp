namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double nota_final, nota1, nota2, nota3, nota4;
            Console.WriteLine("Digite 1ª nota do aluno: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite 2ª nota do aluno: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite 3ª nota do aluno: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite 4ª nota do aluno: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (nota1 + nota2 + nota3 + nota4) / 4;


            string resultado;

            if (nota_final >= 60)
            {
                if (nota_final >= 90)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            if (nota_final >= 40)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("O nota do aluno: {0} - Resultado: {1}.", nota_final, resultado);





        }
    }
}

