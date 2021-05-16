package coolerproject;

import java.sql.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int choice;
        Cooler cool = new Cooler();
        Screen screen = new Screen();
        Eyleyici eyleyici = new Eyleyici();

        DatabaseProcess db = new DatabaseProcess();

        if (db.CheckUserLogin()) {
            do {
                screen.PrintMenu();

                Scanner scanner = new Scanner(System.in);
                choice = scanner.nextInt();
                switch (choice) {
                    case 1:
                        screen.PrintTermometer();
                        break;
                    case 2:
                        eyleyici.OpenCooler();
                        break;
                    case 3:
                        eyleyici.CloseCooler();
                        break;
                    case 4:
                        break;
                    default:
                        System.out.println("Yanlis Tercih!\n");
                        break;

                }

            }while(choice!=4);


        }


    }

}
