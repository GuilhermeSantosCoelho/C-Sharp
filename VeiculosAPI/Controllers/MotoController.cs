using Commons_Core.API;
using Microsoft.AspNetCore.Mvc;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Controllers{
     
    [ApiController]
    [Route("[controller]")]
    public class MotoController : BaseRoutes<IMotoBusiness, IMotoDAO, VeiculosContext, MotoVO, Moto, DefaultMapper>{
        public MotoController(IMotoBusiness motoBusiness) :base(motoBusiness){

        }
    }
}