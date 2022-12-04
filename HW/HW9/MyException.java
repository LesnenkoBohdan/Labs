public class MyException extends Exception {

    private final String message;

    MyException(String str) {
        message=str;
    }

    @Override
    public String toString() {
        return "Exception: "+message;
    }
}