// See https://aka.ms/new-console-template for more information

// naive implimentation 


class pizzaShop{
    public Pizza pizza;

    public pizza order(string name){
        if ( name == "pizza_some"){
            pizza = new Pizza_chicken();
        }else if ( name == "vegitable"){
            pizza = new Pizza_vegitabel();
        }

        // 
        // pizza.prepare()
        // pizza.bake();
        // pizza.cut();
        // pizza.box();

        return pizza;
    }
}


// simple factory 


class pizza{ // abstract class 

}

class Pizza_chicken : pizza{

}
class Pizza_vegitabel:pizza{

}




class pizzaCreatingFactory{
    public pizza? pizza { get; set; }
    public pizza createPizza(string pizza_name){
         pizza = null; // not important 
         if (  pizza_name== "pizza_some"){
            pizza = new Pizza_chicken();
            }else if (  pizza_name == "vegitable"){
                pizza = new Pizza_vegitabel();
            }
            return pizza;
    }
}


class PizzaShop_good{

    protected pizzaCreatingFactory factory; // my be different modifir suitable for the perpose 

    public PizzaShop_good(pizzaCreatingFactory factory)
    {
        this.factory = factory;
    }
    
    public pizza order(string name){
        pizza pizza;
        pizza = this.factory.createPizza("vegitable");

          // pizza.prepare()
        // pizza.bake();
        // pizza.cut();
        // pizza.box();
        return pizza;

    }

}




class program{
    public static void Main(string[] args){
        Console.WriteLine("working fine");
    }
}