using System;

namespace DragRace
{
    public interface Icar
    {
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}
