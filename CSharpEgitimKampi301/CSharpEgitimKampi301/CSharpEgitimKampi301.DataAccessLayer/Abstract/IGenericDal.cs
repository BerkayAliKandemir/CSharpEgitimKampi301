using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T :class
    {
        void Insert(Task entity);
        void Update(Task entity);
        void Delete(Task entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
