public class Moon {
    String name;
    Moon(){
        this.name = "Moon";
    }
    public String getName() {
        return name;
    }
    @Override
    public String toString() {
        return "Moon{" +
                "name='" + name + '\'' +
                '}';
    }
}