using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task2
{
    public abstract class Unit
    {
        protected string name;
        protected int xPos;
        protected int yPos;
        protected int health;
        protected int maxHealth;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected int faction;
        protected string symbol;
        protected bool isAttacking;

        public abstract void Move(int dir);

        public abstract void Combat(Unit attacker);

        public abstract bool InRange(Unit other);

        public abstract void Death();

        public abstract override string ToString();
    }
}
