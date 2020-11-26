using System;
using System.Collections.Generic;
using System.Linq;
using Commons_Core.DAO.Interfaces;
using VeiculosAPI.Entities;

namespace VeiculosAPI.DAO.Interfaces{
    public interface IMotoDAO : IBaseDao<VeiculosContext, MotoVO, Moto, DefaultMapper>{
    }
}