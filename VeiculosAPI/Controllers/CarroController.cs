using Commons_Core.API;
using Microsoft.AspNetCore.Mvc;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Controllers{
     
    [ApiController]
    [Route("[controller]")]
    public class CarroController : BaseRoutes<ICarroBusiness, ICarroDAO, VeiculosContext, CarroVO, Carro, DefaultMapper>{
        public CarroController(ICarroBusiness CarroBusiness) :base(CarroBusiness){

        }
    }
}