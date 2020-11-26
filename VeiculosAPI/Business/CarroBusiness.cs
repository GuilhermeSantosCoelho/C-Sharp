using Commons_Core.Business;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Business {
    public class CarroBusiness : BaseBusiness<ICarroDAO, VeiculosContext, CarroVO, Carro, DefaultMapper>, ICarroBusiness{
        public CarroBusiness(ICarroDAO dao) :base(dao){

        }
    }
}