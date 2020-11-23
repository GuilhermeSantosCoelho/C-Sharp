using System;

namespace CsharpOO{
    public class Moto : Veiculo{
        public Moto(string placa) : base(placa){
        }

        public Moto(){
        }

        public override int QuantidadeDePneus(){
            return 2;
        }

        public int numeroLugares { get; set; }
    }
}