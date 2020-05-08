using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bees.Interfaces;

namespace Bees.Models
{
    /// <summary>
    /// Concrete class representing a Worker
    /// </summary>
    public class Worker : Bee, IBee
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Worker(int id)
        {
            _id = id;
            _health = 100M;
            _deathThreshold = 70M;
            _dead = false;
        }
    }
}