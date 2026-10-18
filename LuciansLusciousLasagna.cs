class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int time = 40;
    public int remainingTime = 0;

    public int setTime(int time)
    {
        this.time = time;
        return time;
    }

    public int getTime()
    {
        return this.time;
    }

    public int setRemainingTime(int time)
    {
        this.remainingTime = time;
        return remainingTime;
    }
    public int getRemainingTime()
    {
        return this.remainingTime;
    }
    public int ExpectedMinutesInOven()
    {
        return getTime();
    }
    public int RemainingMinutesInOven(int timeInOven = 10)
    {
        return (getTime() - timeInOven);


    }
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }
    public int ElapsedTimeInMinutes(int layers, int timeInOven)
    {
        return PreparationTimeInMinutes(layers) + (getTime()-RemainingMinutesInOven(timeInOven));

    }

}
