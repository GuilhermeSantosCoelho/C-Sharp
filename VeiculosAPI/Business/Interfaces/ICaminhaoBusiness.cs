
using Commons_Core.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Business.Interfaces{
    public interface ICaminhaoBusiness : IBaseBusiness<ICaminhaoDAO, VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>{
        
    }
}