package coolerproject;
import java.util.ArrayList;
import java.util.List;


public class Publisher implements ISubject {

    private List<IObserver> users = new ArrayList<>();

    @Override
    public void attach(IObserver subscriber) {
        users.add(subscriber);
    }

    @Override
    public void detach(IObserver subscriber) {
        users.remove(subscriber);
    }

    @Override
    public void notify(String mesaj) {
        for(IObserver subscriber: users) {
            subscriber.update(mesaj);
        }
    }
}