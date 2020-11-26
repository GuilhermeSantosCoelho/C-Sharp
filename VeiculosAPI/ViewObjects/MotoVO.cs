using System;
using Commons_Core.Entities;
using Commons_Core.ViewObject;

namespace VeiculosAPI.Entities{
    public class MotoVO : BaseVO{
        public int numeroQuedas { get; set; }
        public int CapotesDoGustavao { get; set; }
    }
}