using System;
using Commons_Core.Entities;
using Commons_Core.ViewObject;

namespace VeiculosAPI.Entities{
    public class CaminhaoVO : BaseVO{
        public int numeroQuedas { get; set; }
        public int CapotesDoGustavao { get; set; }
    }
}