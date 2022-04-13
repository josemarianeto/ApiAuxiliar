using ApiAuxiliar.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAuxiliar.Data
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }



        public  DbSet<Cliente> Clientes { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }
    }
}
