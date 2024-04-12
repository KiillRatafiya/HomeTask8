using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    public class Transport
    {
        public const string Description = "Here's your transport";
        public int speed { get; set; }


        public virtual void Move()
        {
            Console.WriteLine("Your transport is moving");
        }

        public static void Park ()
        {
            Console.WriteLine("Your transport is moving");
        }
    }

    
}
