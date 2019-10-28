using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task2
{
    public class RangeUnit : Unit
    {



        public bool isDead { get; set; }


        public string Name
        {
            get { return base.name; }
            set { base.name = value; }
        }

        public int XPos
        {
            get { return base.xPos; }
            set { base.xPos = value; }
        }

        public int YPos
        {
            get { return base.yPos; }
            set { base.yPos = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int MaxHealth
        {
            get { return base.maxHealth; }
            set { base.maxHealth = value; }
        }

        public int Speed
        {
            get { return base.speed; }
            set { base.speed = value; }
        }

        public int Attack
        {
            get { return base.attack; }
            set { base.attack = value; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
            set { base.attackRange = value; }
        }

        public int Faction
        {
            get { return base.faction; }

        }

        public string Symbol
        {
            get { return base.symbol; }
            set { base.symbol = value; }
        }

        public bool IsAttacking
        {
            get { return base.isAttacking; }
            set { base.isAttacking = value; }
        }

        public RangeUnit(string n, int x, int y, int h, int mh, int s, int a, int ar, int f, string sy)
        {
            Name = n;
            XPos = x;
            YPos = y;
            Health = h;
            base.maxHealth = mh;
            Speed = s;
            Attack = a;
            AttackRange = ar;
            base.faction = f;
            Symbol = sy;
            IsAttacking = false;
            isDead = false;
        }


        public override void Death()
        {
            symbol = "X";
            isDead = true;
        }

        public override void Move(int dir)
        {
            switch (dir)
            {
                case 0: YPos--; break; //North
                case 1: XPos++; break; //East
                case 2: YPos++; break; //South
                case 3: XPos++; break; //West
                default: break;
            }
        }

        public override void Combat(Unit attacker)
        {
            if (attacker is MeleeUnit)
            {
                Health = Health - ((MeleeUnit)attacker).Attack;
            }

            else if (attacker is RangeUnit)
            {
                RangeUnit ru = (RangeUnit)attacker;
                Health = Health - (ru.Attack - ru.AttackRange); //(((RangeUnit)attacker)).Attack;
            }

            if (Health <= 0)
            {
                Death(); //Death!!!
            }
        }

        public override bool InRange(Unit other)
        {
            int distance = 0;
            int otherX = 0;
            int otherY = 0;
            if (other is MeleeUnit)
            {
                otherX = ((MeleeUnit)other).XPos;
                otherY = ((MeleeUnit)other).YPos;
            }
            else if (other is RangeUnit)
            {
                otherX = ((RangeUnit)other).XPos;
                otherY = ((RangeUnit)other).YPos;
            }

            distance = Math.Abs(XPos - otherX) + Math.Abs(YPos - otherY);
            if (distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            string temp = "";
            temp += "Ranged: ";
            temp += "(" + Name + ")";
            temp += "{" + Symbol + "}";
            temp += "(" + XPos + "," + YPos + ")";
            temp += Health + ", " + Attack + ", " + AttackRange + ", " + Speed;
            temp += (isDead ? " Dead!" : "ALIVE!");

            return temp;
        }

    }
}
