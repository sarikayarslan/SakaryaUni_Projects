package coolerproject;

public interface ISubject {
    public void attach(IObserver o);
    public void detach(IObserver o);
    public void notify(String m);

}
