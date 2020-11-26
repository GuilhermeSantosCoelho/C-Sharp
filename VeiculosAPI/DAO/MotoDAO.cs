using System.Linq;
using Commons_Core.DAO;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO{
    public class MotoDAO : BaseDao<VeiculosContext, MotoVO, Moto, DefaultMapper>, IMotoDAO{
        public override IQueryable<Moto> GetCustomWhere(IQueryable<Moto> listToFilter, MotoVO filter){
            return listToFilter;
        }
    }
}