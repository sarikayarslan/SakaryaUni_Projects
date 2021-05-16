package coolerproject;

import java.util.Random;

public class TermoSensor implements ITermoSensor{
    private int termometer;

    public  TermoSensor(){
        Random random = new Random();
        termometer = random.nextInt(30);
    }

    public int GetTermometer() {
        return termometer;
    }
}
