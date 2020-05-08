using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bees.Interfaces;

namespace Bees.Models
{
    /// <summary>
    /// Abstract class representing a Bee
    /// </summary>
    public abstract class Bee : IBee
    {
        protected int _id;
        protected decimal _health;
        protected decimal _deathThreshold;
        protected bool _dead;


        protected virtual decimal Health
        {
            get { return _health; }
        }

        protected virtual decimal DeathThreshold
        {
            get { return _deathThreshold; }
        }

        protected virtual bool Dead
        {
            get { return _dead; }
        }

        /// <summary>
        /// Damage method 
        /// </summary>
        /// <param name="damage"></param>
        public void Damage(int damage)
        {
            if ((!_dead) && (damage > -1))
            {
                _health = _health * (1 - ((decimal)damage / 100M));
                _dead = (_health < _deathThreshold) ? true : false;
            }
        }

        /// <summary>
        /// Status method
        /// </summary>
        /// <returns>Health</returns>
        public decimal Status()
        {
            var status = _health;
            return status;
        }

        /// <summary>
        /// DeathThreshold method
        /// </summary>
        /// <returns>DeathThreshold</returns>
        public decimal Threshold()
        {
            var threshold = _deathThreshold;
            return threshold;
        }

        /// <summary>
        /// IsAlive method
        /// </summary>
        /// <returns>IsAlive</returns>
        public bool IsAlive()
        {
            var isAlive = !_dead;
            return isAlive;
        }

        /// <summary>
        /// Id method
        /// </summary>
        /// <returns>Id</returns>
        public int Id()
        {
            var Id = _id;
            return Id;
        }

        /// <summary>
        /// Type method
        /// </summary>
        /// <returns>Class Name</returns>
        public string Type()
        {
            var type = this.GetType().Name;
            return type;
        }
    }
}
