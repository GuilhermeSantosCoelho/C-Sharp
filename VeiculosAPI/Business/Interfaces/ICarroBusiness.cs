
using Commons_Core.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Business.Interfaces{
    public interface ICarroBusiness : IBaseBusiness<ICarroDAO, VeiculosContext, CarroVO, Carro, DefaultMapper>{
        
    }
}