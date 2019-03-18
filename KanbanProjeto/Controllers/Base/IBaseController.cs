using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base
{
    interface IBaseController<T> where T: class
    {
        int inserirAtividade(T entity);
    }
}
