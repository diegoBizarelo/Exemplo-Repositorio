using Microsoft.EntityFrameworkCore;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Contexto
{
    public class LivroContexto : DbContext
    {
        public DbSet<Livro> Livro { get; set; }
        public LivroContexto(DbContextOptions<LivroContexto> options) : base(options)
        {
            
        }

        
    }
}
