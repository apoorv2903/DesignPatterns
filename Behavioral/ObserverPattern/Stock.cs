using System.Collections.Generic;
public class Stock : IStock{
    private string name;
    public double price;

    public string Name{get
    {
        return name;
    }
    set{
        name = value;
    }
    }
    public double Price{
        get{
            return price;
        }
        set{
            if(price != value){
                price = value;
                Notify();
            }
        }
    }

    private List<IInvestor> _investors; 

    public Stock(string name, double price)
    {
        this.name = name;
        this.price = price;
        this._investors = new List<IInvestor>();
    }

    public void Notify()
    {
        _investors.ForEach(investor=>{
            investor.Update(this);
        });
    }

    public void Subscribe(IInvestor i)
    {
        if(!_investors.Contains(i)){
            _investors.Add(i);
        }
    }

    public void UnSubscribe(IInvestor i)
    {
        if(_investors.Contains(i)){
            _investors.Remove(i);
        }
    }
}