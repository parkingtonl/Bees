using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bees.Interfaces;

namespace Bees.Models
{
    /// <summary>
    /// Concrete class representing a Drone
    /// </summary>
    public class Drone : Bee, IBee
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Drone(int id)
        {
            _id = id;
            _health = 100M;
            _deathThreshold = 50M;
            _dead = false;
        }
    }
}