using ObserverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternApp
{
    class Customer : IObserver
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            this.Name = name;
        }
        public void update(string message)
        {
            Console.WriteLine($"customer: {Name} received a new notification: {message}");
        }
    }
}
