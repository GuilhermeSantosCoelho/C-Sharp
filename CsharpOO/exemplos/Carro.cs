using System;

namespace CsharpOO{

    public class Veiculo{
        public string cor { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public string verificaSituacaoDetran(string placa){
            return "Carro OK";
        }
    }

    public class Carro : Veiculo{
        public Carro(string cor){
            this.cor = cor;
        }

        public int numeroLugares { get; set; }
    }
}