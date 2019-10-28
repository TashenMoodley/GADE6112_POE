using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_Task2
{
    public class ResourceBuilding : Building
    {

        public bool isDead { get; set; }

        int ResourceType;
        string ResourceGenerated;
        int ResourceGeneratedPerRound;
        int ResourcePoolRemaining;


        public int GenerateResources()
        {
            int ResourceGenerated = 0;
            int ResourcesPoolRemaining = 0;
            int ResourcesGeneratedPerRound = 0;
            ResourcesPoolRemaining = ResourcesPoolRemaining - ResourcesGeneratedPerRound;
            return ResourcesPoolRemaining;


        }


        public override void Death()
        {
            Symbol = "X";
            isDead = true;
        }

        public override string ToString()
        {
            string temp = "";
            temp += "Resource Building";
            temp += "{" + ResourceGenerated + "}";
            temp += "(" + ResourceGeneratedPerRound + ")";
            temp += "{" + ResourcePoolRemaining + "}";
            return temp;
        }


    }
}
