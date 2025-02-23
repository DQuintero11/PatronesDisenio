using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador
{
    public class Product : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _name;
        private bool _inStock;

        public Product(string name)
        {
            _name = name;
            _inStock = false;
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_name);
            }
        }

        public void SetInStock(bool inStock)
        {
            _inStock = inStock;
            if (_inStock)
            {
                Console.WriteLine($"📢 El producto '{_name}' está disponible.");
                NotifyObservers();
            }
        }
    }

}
