public class CarsAssemble {

    public double productionRatePerHour(int speed) {
        int baseRate = speed * 221;
        double multiplyer = 0.0;
        
        if (speed <= 4) {
            multiplyer = 1.0;
        } else if (speed <= 8) {
            multiplyer = 0.90;
        } else if (speed == 9) {
            multiplyer = 0.80;
        } else {
            multiplyer = 0.77;
        }

        return baseRate * multiplyer;
    }

    public int workingItemsPerMinute(int speed) {
        return (int) (productionRatePerHour(speed) / 60);

    }
}
