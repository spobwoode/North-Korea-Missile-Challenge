using System;
using System.Collections.Generic;

class Missile
{
    public static List<Missile> MissilesInFlight = new List<Missile>()
    {
        new Missile(1),
        new Missile(2),
        null,
        new Missile(3)
    };
    
    private int missileNumber;
    private int range;
    private string target;
        
    public Missile(int missileNumber)
    {
        this.missileNumber = missileNumber;
        
        Random r = new Random();
        range = r.Next(200, 12000);
        
        Console.WriteLine($"--- MISSILE {missileNumber} REPORTING IN. LONG LIVE THE DPRK! ---");
    }

    public int GetRangeInKM()
    {
        return range;
    }

    public void SetTarget(string target)
    {
        this.target = target;
        string message = $"--- MISSILE {missileNumber} ";
        if (target == "ABORT!!!")
        {
            message += "ABORT ABORT ABORT ---";
        }
        else
        {
            message += $"SETTING TARGET TO: {target}";
        }
        Console.WriteLine(message);
    }
}