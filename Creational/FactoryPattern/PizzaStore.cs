public class PizzaStore{
    public void orderPizza(PizzaType type){
        IPizza pizza = null;
        //get pizza based on type
        if(type == PizzaType.Farmhouse){
            pizza = new Farmhouse();
        }
        else if(type == PizzaType.VeggieDelight){
            pizza = new VeggieDelight();
        }
        //
        pizza.prepare();
        pizza.bake();
        pizza.cut();
        pizza.box();
    }
}