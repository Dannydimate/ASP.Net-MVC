using WebApplication8.Models;

//una interfaz que nos sirve para desacoplar, que permite hacer las operaciones a la BD (es asincrono y generico)
namespace WebApplication8.Data
{
    public interface IRepositorio
    {
        public Task Save<T>(T obj) where T : Entity;

        public void Delete<T>(T obj) where T : Entity;

        public Task Update<T>(T obj) where T : Entity;

        public Task<List<T>> GetAll<T>() where T : Entity;

        public Task Commit();

    }

}

