using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

//tiene una asociacion de agregacion,commit ejecuta la operacion,una operacion de base de datos.


namespace WebApplication8.Data
{
    public class Repositorio: IRepositorio
    {
        private readonly WebApplication8DbContext context;

        public Repositorio(WebApplication8DbContext context)
        {
            this.context = context;
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAll<T>() where T : Entity
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task Save<T>(T obj) where T : Entity
        {
            await context.Set<T>().AddAsync(obj);
        }

        public async Task Update<T>(T obj) where T : Entity
        {
            await context.Set<T>().AddAsync(obj);
        }

        public void Delete<T>(T obj) where T : Entity
        {
           context.Set<T>().Remove(obj);
        }




    }
}
