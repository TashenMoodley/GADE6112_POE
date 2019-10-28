using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task2
{
    public class FactoryBuilding : Building
    {
        public bool isDead { get; set; }


        bool UnitType;
        int ProductionSpeed;
        int SpawnPoint;

        public int ProdSpeed()
        {
            get{ return ProductionSpeed; }
            set{ ProductionSpeed = value; }
        }

        public override void Death()
        {
            Symbol = "X";
            isDead = true;
        }



        public override string ToString()
        {
            string temp = "";
            temp += "Factory Building";
            temp += "(" + UnitType + ")";
            temp += "{" + ProductionSpeed + "}";
            temp += "(" + SpawnPoint + ")";
            return temp;
        }

    }
}
