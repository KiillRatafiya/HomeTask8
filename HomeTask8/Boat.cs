using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask8
{
    public class Boat : Transport
    {
        public int AvgSpeed { get; set; }

        public override void Move()
        {
            Console.WriteLine("Your boat is moving");
        }

        public new void Park()
        {
            Console.WriteLine("Your boat can be parked");
        }
    }
}
