class RemoteControlCar
{
    public int DriveDistance { private get; set; } = 0;
    public int BatteryCharge { private get; set; } = 100;
        
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {DriveDistance} meters";
    }

    public string BatteryDisplay()
    {
        
        if (BatteryCharge > 0)
        {
            return $"Battery at {BatteryCharge}%";
        }
        else
        {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (BatteryCharge > 0)
        {
            DriveDistance += 20;
            BatteryCharge -= 1;
        }
    }
}
