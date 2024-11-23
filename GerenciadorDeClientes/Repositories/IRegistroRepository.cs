namespace GerenciadorDeClientes.Repositories;

public interface IRegistroRepository<T> where T : class
{
    ICollection<T> GetAll();
    ICollection<T> GetByName(string name);
    void Insert(T t);    
}
