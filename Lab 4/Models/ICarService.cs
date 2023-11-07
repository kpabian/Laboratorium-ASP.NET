namespace Lab_4.Models
{
    public interface ICarService
    {
        int Add(Car car);
        void RemoveById(int id);
        void Update(Car car);
        List<Car> FindAll();
        Car? FindById(int id);
    }
}
