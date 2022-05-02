using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> ListAllT();
        void TAdd(T t);
        void deleteT(T t);
        void updateT(T t);
        T getByIdT(int id);
    }
}
