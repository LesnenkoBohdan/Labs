import java.awt.*;
import java.util.Arrays;

public class Polinom {
    float[] coefs;
    Polinom(float[] coefs){
        this.coefs = coefs;
    }

    public float[] getCoefs() {
        return coefs;
    }

    public float[] setCoefs(float[] coefs) {
        this.coefs = coefs;
        return this.coefs;
    }

    public String toString() {
        return "Polinom{" +
                "coefs=" + Arrays.toString(coefs) +
                '}';
    }
}