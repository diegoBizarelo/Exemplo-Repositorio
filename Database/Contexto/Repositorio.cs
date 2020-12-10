using Microsoft.EntityFrameworkCore;
using Modelos.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Database.Contexto
{
    public class Repositorio
    {
        private LivroContexto _livro;

        public Repositorio(LivroContexto livro)
        {
            _livro = livro;
        }

        public async Task<IEnumerable<Livro>> BuscarTodosAsync()
        {
            var livros = await _livro.Set<Livro>().ToListAsync();
            return livros;
        }

        public async Task<Livro> BuscarAsync(int id)
        {
            var livro = await _livro.Set<Livro>().FindAsync(id);
            return livro;
        }

        public async Task<Livro> IserirAsync(Livro l)
        {
            var livro = await _livro.Set<Livro>().AddAsync(l);
            await _livro.SaveChangesAsync();
            return livro.Entity;
        }
    }
}
