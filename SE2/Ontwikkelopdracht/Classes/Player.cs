using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontwikkelopdracht
{
    class Player : Object
    {
        private int health;
        public enum state {};
        private bool alive;
        private int damage;

        public Player()
        {

        }

        private void Move()
        {

        }

        private void Death()
        {

        }
        private void Jump(int gravity)
        {

        }
        private void Attack(Enemy e)
        {

        }
        private void PowerUp(string celltype)
        {

        }
        public void GetDamage(int damage)
        {

        }

        public int Health { get { return this.health } set { this.health = value; } }
        public bool Alive { get { return this.alive } set { this.alive = value; } }
        public int Damage { get { return this.damage } set { this.damage = value; } }
    }
}
