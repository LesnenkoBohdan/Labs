public class Planet {
    String name;
    Planet(){
        this.name = "";
    }
    Planet(String name){
        this.name = name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

}