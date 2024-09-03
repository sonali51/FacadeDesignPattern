/******************************************************************************
* Filename    = SoundSystem.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = The 'Soundsystem' Class
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterManager
{
    public class SoundSystem
    {
        public virtual void On()
        {
            Console.WriteLine("Sound system is ON");
        }
        public virtual void Off()
        {
            Console.WriteLine("Sound system is OFF");
        }
        public virtual void SetVolume(int level)
        {
            Console.WriteLine($"Sound system volume set to {level}");
        }
    }
}