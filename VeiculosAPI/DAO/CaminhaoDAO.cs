using System.Linq;
using Commons_Core.DAO;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO{
    public class CaminhaoDAO : BaseDao<VeiculosContext, CaminhaoVO, Caminhao, DefaultMapper>, ICaminhaoDAO{
        public override IQueryable<Caminhao> GetCustomWhere(IQueryable<Caminhao> listToFilter, CaminhaoVO filter){
            return listToFilter;
        }
    }
}