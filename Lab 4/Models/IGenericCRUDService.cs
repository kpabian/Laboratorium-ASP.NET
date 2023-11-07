namespace Lab_4.Models
{
    public interface IGenericCRUDService<T, Key>
    {
        void Add(T entity);
        void DeleteById(T entity);
        void Update(T entity);
        List<T> FindAll();
        T? FindById(Key id);
    }
}
