using strategyDesignPattern;
using strategyDesignPattern.interfaces;

// wild Duck
LoudQuack loudQuack = new LoudQuack(); // concrete ref
IFly JetFly = new JetFly(); // interface ref

Duck wildDuck = new Duck(JetFly, loudQuack, "wild Duck", "black");
wildDuck.DuckQuack();
wildDuck.DuckFly();
wildDuck.printDuck();

// city Duck

IQuack simpleQuack = new SimpleQuack();
IFly simpleFly = new SimpleFly();

Duck cityDuck = new Duck(simpleFly, simpleQuack, "city Duck", "white");
cityDuck.DuckQuack();
cityDuck.DuckFly();
cityDuck.printDuck();

// rubber duck
IFly noFly = new NoFly();
Duck rubberDuck = new Duck(noFly, simpleQuack, "rubber Duck", "yellow");
rubberDuck.DuckQuack();
rubberDuck.DuckFly();
rubberDuck.printDuck();



