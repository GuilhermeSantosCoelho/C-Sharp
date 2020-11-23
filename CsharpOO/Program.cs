using System;

namespace CsharpOO{
    class Program{
        public static void Main(string[] args)
        {
            Carro carro = new Carro("Prata");
            Console.WriteLine("Cor do carro: " + carro.cor);
            Console.WriteLine("Situação do carro: " + carro.verificaSituacaoDetran("1231234"));

            //numbers
            // int n1 = 12313123;
            // long n2 = 123131313123123;
            // byte n3 = 1;
            // short n4 = 123;

            // float f1 = 0.1F;
            // double d1 = 0.1;

            // char c1 = '1';

            // bool b1 = true;
        }
    }
}