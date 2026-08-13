public class JedliksToyCar {
    private int battery = 100;
    private int drivenMeters = 0;
    
    public static JedliksToyCar buy() {
        return new JedliksToyCar();
    }

    public String distanceDisplay() {
        return "Driven " + drivenMeters + " meters";
    }

    public String batteryDisplay() {
        if (battery == 0) {
            return "Battery empty";
        }
        
        return "Battery at " + battery + "%";
    }

    public void drive() {
        if (battery > 0) {
            battery -= 1;
            drivenMeters += 20;
        }
    }
}
