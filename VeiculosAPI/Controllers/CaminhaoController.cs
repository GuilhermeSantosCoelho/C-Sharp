using Commons_Core.API;
using Microsoft.AspNetCore.Mvc;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Controllers{
     
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : BaseRoutes<ICaminhaoBusiness, ICaminhaoDAO, VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>{
        public CaminhaoController(ICaminhaoBusiness CaminhaoBusiness) :base(CaminhaoBusiness){

        }
    }
}