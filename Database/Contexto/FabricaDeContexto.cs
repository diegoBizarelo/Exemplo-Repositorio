using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Contexto
{
    public class FabricaDeContexto : IDesignTimeDbContextFactory<LivroContexto>
    {
        public LivroContexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LivroContexto>();
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Livros; Trusted_Connection = True; MultipleActiveResultSets = true");
            return new LivroContexto(optionsBuilder.Options);
        }
    }
}
