using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCatalog
{
    public class Catalog<T>
    {
        private Dictionary<string, T> _items;

        public Catalog()
        {
            _items = new Dictionary<string, T>();
        }

        public List<T> All
        {
            get { return _items.Values.ToList(); }
        }

        public void Insert(string Id, T anItem)
        {
            if (!_items.ContainsKey(Id))
            {
                _items.Add(Id, anItem);
            }
        }
        public void PrintAll()
        {
            foreach(var itm in _items)
            {
                Console.WriteLine(itm);
            }
        }

        public void Delete(string Id)
        {
            _items.Remove(Id);
        }
    }
}

