class Lasagna
{   
    public int ExpectedMinutesInOven() => 40;// TODO: define the 'ExpectedMinutesInOven()' method
    
    public int RemainingMinutesInOven(int actualMinutes) => ExpectedMinutesInOven() - actualMinutes;

    public int PreparationTimeInMinutes(int Preparation) => Preparation * 2;
   
    public int ElapsedTimeInMinutes(int X, int Y) => X * 2 + Y;
    
}
