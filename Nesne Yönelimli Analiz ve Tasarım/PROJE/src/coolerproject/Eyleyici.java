package coolerproject;

public class Eyleyici implements IEyleyici {
    boolean state;

    @Override
    public void OpenCooler() {
        System.out.println(" Soğutucu Açıldı");
    }

    @Override
    public void CloseCooler() {
        System.out.println(" Soğutucu Kapandı");

    }
}
