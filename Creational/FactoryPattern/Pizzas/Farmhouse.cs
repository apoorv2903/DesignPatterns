public class Farmhouse: IPizza{
    private string Name = PizzaType.Farmhouse.ToString();
    public void prepare(){
        System.Console.WriteLine($"prepare {Name}");
    }
    public void bake(){
        System.Console.WriteLine($"bake {Name}");
    }
    public void cut(){
        System.Console.WriteLine($"cut {Name}");
    }
    public void box(){
        System.Console.WriteLine($"box {Name}");
    }
}