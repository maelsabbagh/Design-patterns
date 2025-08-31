using StrategyApp;
using StrategyApp.Payment;
using StrategyApp.PriceCalculator;

IPriceCalculator regularPriceCalculator = new RegularPriceCalculator();
IPriceCalculator GoldPriceCalculator = new GoldPriceCalculator();
IPriceCalculator premiumPriceCalculator = new PremiumPriceCalculator();

Product tshirt = new Product("adidas", 200,regularPriceCalculator);
double tshirtPrice = tshirt.calculatePrice();

Product shoes = new Product("Nike", 250, GoldPriceCalculator);
double shoesPrice = shoes.calculatePrice();

Product wallet = new Product("wallet", 100, premiumPriceCalculator);
double walletPrice = wallet.calculatePrice();


IPaymentMethod visaPayment = new VisaPayment();
IPaymentMethod paypalPayment = new PaypalPayment();
IPaymentMethod BankPayment = new BankTransferPayment();

Checkout Visacheckout = new Checkout(visaPayment);
Checkout paypalCheckout = new Checkout(paypalPayment);
Checkout bankCheckout = new Checkout(BankPayment);

Visacheckout.processPayment(tshirtPrice);
paypalCheckout.processPayment(shoesPrice);
bankCheckout.processPayment(walletPrice);

