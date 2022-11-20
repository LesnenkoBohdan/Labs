import java.util.concurrent.ThreadLocalRandom;

public class Task3_6 {
 static int n = 100000;
        enum CoinSide{
            HEAD,TAIL
        }

        static int[] countFlips(){
            boolean[] success = new boolean[]{
                    false,false
            };
            int aliceFlips = 0;
            int bobFlips = 0;
            CoinSide lastFlip;
            CoinSide currentFlip = null;
            CoinSide bobsFlip;
            do{
                if (currentFlip==null){
                    currentFlip=flipACoin();
                    aliceFlips++;
                    bobsFlip=flipACoin();
                    bobFlips++;
                    if (bobsFlip.equals(CoinSide.TAIL) && (currentFlip.equals(CoinSide.HEAD))){
                        success[1]=true;
                    }
                    continue;
                }
                lastFlip=currentFlip;
                currentFlip=flipACoin();
                if (lastFlip.equals(currentFlip) && lastFlip.equals(CoinSide.HEAD))
                    success[0]=true;
                if (!success[0])
                    aliceFlips++;
                bobsFlip=flipACoin();
                if (!success[1])
                    bobFlips++;
                if (bobsFlip.equals(CoinSide.TAIL) && (currentFlip.equals(CoinSide.HEAD))){
                    success[1]=true;
                }
            } while (!success[0] || !success[1]);

            return new int[]{aliceFlips,bobFlips};
        }
        static CoinSide flipACoin(){
            if (ThreadLocalRandom.current().nextDouble()<=0.5){
                return CoinSide.HEAD;
            }
            return CoinSide.TAIL;
        }


        public static void main(String[] args) {
            int succeed = 0;
            int total = n;
            for (int i=0; i<n; i++){
                int[] flips = countFlips();
                if (flips[0]<flips[1]){
                    succeed++;
                }
            }
            double probability = (double) succeed/total;
            System.out.println(probability);
        }
}