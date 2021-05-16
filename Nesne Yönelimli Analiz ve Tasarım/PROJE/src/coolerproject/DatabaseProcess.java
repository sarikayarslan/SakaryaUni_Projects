package coolerproject;

import java.sql.*;
import java.util.ArrayList;
import java.util.Scanner;

public class DatabaseProcess {

    ArrayList<User> users = new ArrayList<User>();
    String checkId;
    String checkPassword;

    public DatabaseProcess() {



        String jdbcURL = "jdbc:postgresql://localhost:5432/COOLER";
        String username = "postgres";
        String sqlPass = "123456";
        try {
            Connection connection = DriverManager.getConnection(jdbcURL, username, sqlPass);
            if (connection != null) {
                System.out.println("Veritabanı Bağlantısı Başarılı");

            } else {
                System.out.println("Bağlanma problemlerim var");
            }

            String query = "SELECT *  FROM \"User\"";
            Statement stmt = connection.createStatement();
            ResultSet rs = stmt.executeQuery(query);


            Scanner input = new Scanner(System.in);
            System.out.print("Kullanici Adi..:");
            checkId = input.next();

            System.out.print("Sifre..:");
            checkPassword = input.next();


            while (rs.next()) {
                User user = new User.Builder().id(rs.getString("id")).password(rs.getString("password")).build();
                users.add(user);

            }

            stmt.close();
            rs.close();
            connection.close();


        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }

    public boolean CheckUserLogin() {
        System.out.println("Kullanıcı doğrulanıyor...");
        try {
            Thread.sleep(1500);
        } catch (Exception e) {
            System.out.println(e);
        }
        System.out.println("Veritabanına bağlandı ve kullanıcı hesap bilgilerini aldı...");
        try {
            Thread.sleep(1500);
        } catch (Exception e) {
            System.out.println(e);
        }
        for (int i = 0; i < users.size(); i++) {
            if (users.get(i).getId().equals(checkId) && users.get(i).getPassword().equals(checkPassword)) {
                System.out.println("Giriş Başarılı");
                return true;
            }
        }
        System.out.println("Giriş Başarısız");
        return false;
    }


}
