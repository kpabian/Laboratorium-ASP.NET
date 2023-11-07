namespace Lab_4.Models
{
    public class MemoryCarService : ICarService
    {
        private readonly Dictionary<int, Car> _items = new Dictionary<int, Car>();
        private int id = 1;
        public int Add(Car item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.ID = id + 1;
            _items.Add(item.ID, item);
            return item.ID;
        }

        public List<Car> FindAll()
        {
            return _items.Values.ToList();
        }

        public Car? FindById(int id)
        {
            return _items[id];
        }

        public void RemoveById(int id)
        {
            _items.Remove(id);
        }

        public void Update(Car car)
        {
            if (_items.ContainsKey(car.ID))
            {
                _items[car.ID] = car;
            }
        }

        
    }
}
