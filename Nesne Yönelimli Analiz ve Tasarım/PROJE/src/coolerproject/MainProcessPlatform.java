package coolerproject;

public class MainProcessPlatform {
    private boolean open = false;

    public MainProcessPlatform(){
        Eyleyici eyleyici = new Eyleyici();
    }

    public void EyleyiciCalistir(String command) {

        Eyleyici eyleyici = new Eyleyici();
        System.out.println("Istek eyleyiciye bildiriliyor...");
        try {
            Thread.sleep(1500);
        } catch (Exception e) {
            System.out.println(e);
        }
        if (command.equals("ac")) {
            eyleyici.OpenCooler();
            open = true;
        } else {
            eyleyici.CloseCooler();
            open = false;
        }


    }

    public boolean CoolerStatus() {
        return open;

    }


}
