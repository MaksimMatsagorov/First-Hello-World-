class RemoteControlCar
{
    private int Meters = 0;
    private int BatteryFull = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {Meters} meters";
   
    public string BatteryDisplay() =>  BatteryFull == 0 ? "Battery empty" : $"Battery at {BatteryFull}%";
    
    public void Drive()
    {
        if(BatteryFull > 0)
        {
            Meters += 20;
            BatteryFull--;
        }
    }
}
