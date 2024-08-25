namespace GerenciadorDeClientes.Repositories;

public interface IRepository<T> where T : class
{
    ICollection<T> GetAll();
    T GetByName(string name);
    T Insert(T t);
    T Update(T t);
    void Delete(T t);
}
