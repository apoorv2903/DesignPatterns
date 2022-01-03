using System;
public class Investor: IInvestor{
    public string Name;
    public Investor(string name)
    {
        this.Name = name;
    }

    public void Update(IStock stock)
    {
        Console.WriteLine($"Notified {this.Name}, {stock.Name} changed to {stock.Price}");
    }
}