using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CsharpOO{
    class Program{

        public static List<T> importarVeiculos<T>(string CSVPath) where T : Veiculo, new(){
            var todasAsLinhas = File.ReadAllLines(CSVPath);
            List<T> veiculos = todasAsLinhas.Select(m => {
                var infCar = m.Split(";");
                var car = new T();
                car.placa = infCar[0];
                car.cor = infCar[1];
                car.marca = infCar[2];
                car.modelo = infCar[3];
                // car.ano = infCar[4];
                return car;
            }).ToList<T>();
            return veiculos;
        }

        public static void Main(string[] args)
        {
            List<Carro> veiculos = importarVeiculos<Carro>("csv/veiculos.csv");
            // Veiculo veiculo = new Veiculo("");
            // Carro carro = new Carro("Prata");
            // Console.WriteLine("Cor do carro: " + carro.cor);
            // Console.WriteLine("Situação do carro: " + carro.verificaSituacaoDetran("1231234"));

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

        public void EscopoDeObjeto(){}
        public static void EscopoDeClasse(){}
    }
}