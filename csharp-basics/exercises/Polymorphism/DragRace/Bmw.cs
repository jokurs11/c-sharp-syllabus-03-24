using System;

namespace DragRace
{
    public class Bmw : Car, Icar

    {
    private int _currentSpeed ;

    public override void SpeedUp()
    {
        _currentSpeed += 9;
    }

    public override void SlowDown()
    {
        var random = new Random();
        _currentSpeed -= random.Next(1, 5);
    }

        public override string ShowCurrentSpeed()
    {
        return _currentSpeed.ToString();
    }

    public override void StartEngine()
    {
        Console.WriteLine("Rrrrrrr.....");
    }
    }
}