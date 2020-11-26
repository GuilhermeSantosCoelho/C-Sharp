using Commons_Core.Business;
using VeiculosAPI.Business.Interfaces;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Business {
    public class CaminhaoBusiness : BaseBusiness<ICaminhaoDAO, VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>, ICaminhaoBusiness{
        public CaminhaoBusiness(ICaminhaoDAO dao) :base(dao){

        }
    }
}