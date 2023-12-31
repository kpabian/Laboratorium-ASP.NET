﻿using Microsoft.AspNetCore.Mvc;

namespace Lab_4.Models
{
    public class MemoryContactService : IContactService
    {
        private readonly Dictionary<int, Contact> _items = new Dictionary<int, Contact>();
        private int id = 1;

        IDateTimeProvider _timeProvider;

        public MemoryContactService(IDateTimeProvider param)
        {
            _timeProvider = param;
        }
        public void Add(Contact contact)
        {
            contact.Created = _timeProvider.DateTimeMethod();
            contact.ID = id++;
            _items.Add(contact.ID, contact);
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
            if (_items.ContainsKey(contact.ID))
            {
                _items[contact.ID] = contact;
            }
        }
    }
}
