using Microsoft.EntityFrameworkCore;
using MeowColonThree.Models;

namespace MeowColonThree.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }   
        public DbSet<ContatoModel> Contatos {  get; set; }
    }
}
