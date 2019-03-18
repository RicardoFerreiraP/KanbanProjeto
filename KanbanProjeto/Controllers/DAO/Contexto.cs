using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Models;

namespace Controllers.DAO
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            //Apaga e recria a base de dados se houver a mudança na Model
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Atividade> Atividades { get; set; }
    }
}
