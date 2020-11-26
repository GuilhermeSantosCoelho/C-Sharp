using System;
using Commons_Core.Entities;
using Commons_Core.ViewObject;

namespace VeiculosAPI.Entities{
    public class CarroVO : BaseVO{
        public int numeroQuedas { get; set; }
        public int CapotesDoGustavao { get; set; }
    }
}