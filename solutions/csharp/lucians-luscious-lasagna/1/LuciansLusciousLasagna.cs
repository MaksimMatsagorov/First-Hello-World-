class Lasagna
{   
    public int ExpectedMinutesInOven() // TODO: define the 'ExpectedMinutesInOven()' method
    {
     return 40;    
    }
    
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;  // TODO: define the 'RemainingMinutesInOven()' method 
    }    

    public int PreparationTimeInMinutes(int Preparation)
    {
         return Preparation * 2; // TODO: define the 'PreparationTimeInMinutes()' method
    }

    public int ElapsedTimeInMinutes(int X, int Y)
    {
        return X * 2 + Y; // TODO: define the 'ElapsedTimeInMinutes()' method
    }
}
