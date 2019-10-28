using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task2
{
    public abstract class Building
    {

        protected int Xpos;
        protected int Ypos;
        protected int Health;
        protected int MaxHealth;
        protected int Faction;
        protected string Symbol;

        public abstract void Death();

        public abstract override string ToString();

    }
}
