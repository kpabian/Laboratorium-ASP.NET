namespace Lab_3___App.Models.Contact
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private int id = 1;
        public void Add(Contact contact)
        {
            contact.Id = id++;
            _items.Add(contact.Id, contact);
        }

        public List<Contact> FindAll()
        {
            return _items.Values.ToList();
        }

        public Contact? FindById(int id)
        {
            return _items[id];
        }

        public void RemoveById(int id)
        {
            _items.Remove(id);
        }

        public void Update(Contact contact)
        {
            if(_items.ContainsKey(contact.Id))
            {
                _items[contact.Id] = contact;
            }
            
        }
    }
}
