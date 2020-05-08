using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bees.Interfaces
{
    /// <summary>
    /// IBee Interface defining methods used by instances of subclasses of abstract class Bee (eg Drone, Queen, Worker)
    /// </summary>
    interface IBee
    {
        void Damage(int damage);

        decimal Status();

        bool IsAlive();
    }
}
