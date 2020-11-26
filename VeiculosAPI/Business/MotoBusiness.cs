using Commons_Core.Business;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Business {
    public class MotoBusiness : BaseBusiness<IMotoDAO, VeiculosContext, MotoVO, Moto, DefaultMapper>, IMotoBusiness{
        public MotoBusiness(IMotoDAO dao) :base(dao){

        }
    }
}