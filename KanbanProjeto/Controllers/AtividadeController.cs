using Controllers.Base;
using Controllers.DAO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AtividadeController : IBaseController<Atividade>
    {
        Contexto contexto = new Contexto();

        public int inserirAtividade(Atividade atividade)
        {
            if(atividade != null)
            {
                contexto.Atividades.Add(atividade);
                contexto.SaveChanges();
                return 1;
            }

            return 0;
        }
    }
}
