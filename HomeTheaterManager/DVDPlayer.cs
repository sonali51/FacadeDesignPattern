/******************************************************************************
* Filename    = DVD.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = The 'DVD' Class
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterManager
{
    public class DVDPlayer
    {
        public virtual void On()
        {

            Console.WriteLine("DVD player is ON");
        }
        public virtual void Off()
        {

            Console.WriteLine("DVD player is OFF");
        }
        public virtual void Play(string movie)
        {

            Console.WriteLine($"Playing {movie}");
        }
    }
}