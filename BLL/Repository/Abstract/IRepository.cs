using Core;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
      
        List<T> GetAll();
        
        T GetById(Guid id);
      
       
       
        string Update(T model);
     
        string Delete(T model);

    }
}
