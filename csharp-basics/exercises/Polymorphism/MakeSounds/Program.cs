using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            Parrot _parrot = new Parrot();
            Radio _radio = new Radio();
            Firework _firework = new Firework();

            var sounds = new List<ISound>()
            {
                _parrot, _radio, _firework
            };

            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }
        }
    }
}