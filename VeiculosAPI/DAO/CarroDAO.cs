using System.Linq;
using Commons_Core.DAO;
using VeiculosAPI.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO{
    public class CarroDAO : BaseDao<VeiculosContext, CarroVO, Carro, DefaultMapper>, ICarroDAO{
        public override IQueryable<Carro> GetCustomWhere(IQueryable<Carro> listToFilter, CarroVO filter){
            return listToFilter;
        }
    }
}