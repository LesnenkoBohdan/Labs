import lab7.Conection;

public class ConnectionManager {
    private Connection[] pool;
    private int index;

    public ConnectionManager(int poolSize) {
        this.pool = new Connection[poolSize];
        for (int i = 0; i < poolSize; i++) {
            this.pool[i] = new Connection();
        }
    }

    public Connection getConnection() {
        if (index < pool.length)
            return pool[index++];
        return null; // тут маж бути "завершити роботу"
    }
}