namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            //Fazer um programa que capture os inputs do usuario e mostre a tabuada de 1 a 10
     Console.WriteLine("Digite um número!");
     int number = Convert.ToInt32(Console.ReadLine());


            //Resposta 1
            //Console.WriteLine("{0} 1 X " + number + "=" + number * 1);
            //Console.WriteLine("{0} 2 X " + number + "=" + number * 2);
            //Console.WriteLine("{0} 3 X " + number + "=" + number * 3);
            //Console.WriteLine("{0} 4 X " + number + "=" + number * 4);
            //Console.WriteLine("{0} 5 X " + number + "=" + number * 5);
            //Console.WriteLine("{0} 6 X " + number + "=" + number * 6);
            //Console.WriteLine("{0} 7 X " + number + "=" + number * 7);
            //Console.WriteLine("{0} 8 X " + number + "=" + number * 8);
            //Console.WriteLine("{0} 9 X " + number + "=" + number * 9);
            //Console.WriteLine("{0} 10 X " + number + "=" + number * 10);

            //Resposta 2
            Console.WriteLine("{0} X 1 = {1}", number, number * 1);
            Console.WriteLine("{0} X 1 = {1}", number, number * 2);
            Console.WriteLine("{0} X 1 = {1}", number, number * 3);
            Console.WriteLine("{0} X 1 = {1}", number, number * 4);
            Console.WriteLine("{0} X 1 = {1}", number, number * 5);
            Console.WriteLine("{0} X 1 = {1}", number, number * 6);
            Console.WriteLine("{0} X 1 = {1}", number, number * 7);
            Console.WriteLine("{0} X 1 = {1}", number, number * 8);
            Console.WriteLine("{0} X 1 = {1}", number, number * 9);
            Console.WriteLine("{0} X 1 = {1}", number, number * 10);



            //Futuramente fazer um loop que percorra até o número 10











        }
    }
}
