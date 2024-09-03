/******************************************************************************
* Filename    = Projector.cs
*
* Author      = Sonali
*
* Product     = Software Design Patterns
* 
* Project     = Facade Design Pattern
*
* Description = The 'Projector' Class
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheaterManager
{
    public class Projector
    {
        public virtual void On()
        {
            Console.WriteLine("Projector is ON");
        }
        public virtual void Off()
        {
            Console.WriteLine("Projector is OFF");
        }

    }
}