class NeedForSpeed {
    private int speed;
    private int batteryDrain;
    private int batteryState = 100;
    private int distance = 0;
    
    NeedForSpeed(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() {
        return this.batteryState < this.batteryDrain;
    }

    public int distanceDriven() {
        return this.distance;
    }

    public void drive() {
        if (!this.batteryDrained()) {
            this.distance += speed;
            this.batteryState -= batteryDrain;
        }
    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50, 4);
    }
}

class RaceTrack {
    private int distance;
    
    RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean canFinishRace(NeedForSpeed car) {
        while (true) {
            car.drive();
            if (this.distance > car.distanceDriven() && car.batteryDrained()) {
                return false;
            } else if (this.distance <= car.distanceDriven()) {
                return true;
            }
        }
    }
}
