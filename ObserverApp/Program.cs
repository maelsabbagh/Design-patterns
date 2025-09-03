using ObserverApp;
using ObserverPatternApp;

OnlineMarketPlace market = new OnlineMarketPlace();

Customer customerA = new Customer("Mohamed");
Customer customerB = new Customer("Ahmed");
Customer customerC = new Customer("Youssef");
Customer customerD = new Customer("Mostafa");

// subscribe
market.add(EventType.NewProduct, customerA);
market.add(EventType.NewOffer, customerA);

market.add(EventType.NewProduct, customerB);

market.add(EventType.NewOffer, customerC);

market.addProduct(new Product("adidas shoes", 200));
market.addProduct(new Product("Nike shoes", 220));

market.addOffer(new Offer("A new offer on all brands"));


//unsubscribe
market.remove(EventType.NewProduct, customerA);

market.addProduct(new Product("Puma shoes", 150));
