using System.Globalization;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            float num3;
            float num4, num5;

            //Input de digitação
            Console.WriteLine("Digite o primeiro numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Soma
            num3 = num1 + num2;
            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, num3);
           
            //Subtração
            num3 = num1 - num2;
            Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, num3);

            //Multiplicação
            num3 = num1 * num2;
            Console.WriteLine("A multiplicação de {0} por {1} = {2}", num1, num2, num3);
            
            //Divisão
            num3 = num1 / num2;
            Console.WriteLine("A divisão de {0} por {1} = {2}", num1, num2, num3);
            

       
        }
    }
}
