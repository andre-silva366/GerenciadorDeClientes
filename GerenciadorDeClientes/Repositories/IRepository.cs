namespace GerenciadorDeClientes.Repositories;

public interface IRepository<T> where T : class
{
    ICollection<T> GetAll();
    ICollection<T> GetByName(string name);
    T GetById(int id);
    void Insert(T t);
    void Update(T t);
    void Delete(T t);
}
