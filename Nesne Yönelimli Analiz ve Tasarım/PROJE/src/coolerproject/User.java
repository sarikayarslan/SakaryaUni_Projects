package coolerproject;

import java.util.ArrayList;

public class User {
    private final String id;
    private final String password;
    private final String name;
    private final String surname;

    public User(Builder builder){
        this.id = builder.id;
        this.password= builder.password;
        this.name = builder.name;
        this.surname = builder.surname;
    }

    String getId() {
        return id;
    }

    String getPassword() {
        return password;
    }

    public static class Builder{
        private String id;
        private String password;
        private String name;
        private String surname;

        public Builder(){}

        public Builder id(String id){
            this.id = id;
            return this;
        }

        public Builder password(String password){
            this.password = password;
            return this;
        }

        public Builder name(String name){
            this.name = name;
            return this;
        }
        public Builder surname(String surname){
            this.surname = surname;
            return this;
        }
        public User build() {
            return new User(this);
        }




    }


}
