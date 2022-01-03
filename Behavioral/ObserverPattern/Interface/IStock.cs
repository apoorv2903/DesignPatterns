
//Equivalent to ISubject
public interface IStock{
    string Name{get;set;}
    double Price{get;set;}
    void Subscribe(IInvestor i);
    void UnSubscribe(IInvestor i);
    void Notify();
}   