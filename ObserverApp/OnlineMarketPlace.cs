using ObserverApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverApp
{
    class OnlineMarketPlace:IObservable
    {
        Dictionary<EventType, HashSet<IObserver>> subscribers;
        List<Product> products;
        List<Offer> offers;
        public OnlineMarketPlace()
        {
            
            subscribers = new Dictionary<EventType, HashSet<IObserver>>();
            products = new List<Product>();
            offers = new List<Offer>();    
        }

        public void add(EventType eventType, IObserver observer) // subscribe
        {
            if(!subscribers.ContainsKey(eventType))
            {
                subscribers[eventType] = new HashSet<IObserver>();
            }

            subscribers[eventType].Add(observer);
            
        }


        public void remove(EventType eventType, IObserver observer) // unsubscribe
        {
            subscribers[eventType].Remove(observer);
        }
        public void notify(EventType eventType,string message)
        {
            foreach(var subscriber in subscribers[eventType])
            {
                subscriber.update(message);
            }
        }

        public void addProduct(Product product)
        {
            this.products.Add(product);
            notify(EventType.NewProduct, $"A new product has been added: {product.Name}");
        }

        public void addOffer(Offer offer)
        {
            this.offers.Add(offer);
            notify(EventType.NewOffer, $"A new offer has been released: {offer.Message}");
        }


    }
}
