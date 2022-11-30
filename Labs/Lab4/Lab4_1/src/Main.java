import java.util.Arrays;

/*
Lab 4 Task 1
 */
public class Lab4_1 {
    public static void main(String[] args) {
        String[] strings = new String[15] ;
        Arrays.fill(strings, new String("."));
        for (String string : strings) {
            System.out.println(string);
        }

    }
}