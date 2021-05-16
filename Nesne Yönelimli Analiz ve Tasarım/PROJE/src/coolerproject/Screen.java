package coolerproject;

public class Screen implements IScreen {
    Publisher publisher = new Publisher();
    @Override
    public void PrintMenu() {
        System.out.println("[1] Sicakliği Göster");
        System.out.println("[2] Sogutucu Ac");
        System.out.println("[3] Sogutucu Kapat");
        System.out.println("[4] Cikis");
    }

    @Override
    public void PrintTermometer() {
        TermoSensor termoSensor = new TermoSensor();
        System.out.println(termoSensor.GetTermometer());
    }

    public void NotifyUserChange(){
        publisher.notify();
    }


}
