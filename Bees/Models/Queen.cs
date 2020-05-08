using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bees.Interfaces;

namespace Bees.Models
{
    /// <summary>
    /// Concrete class representing a Queen
    /// </summary>
    public class Queen : Bee, IBee
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Queen(int id)
        {
            _id = id;
            _health = 100M;
            _deathThreshold = 20M;
            _dead = false;
        }
    }
}