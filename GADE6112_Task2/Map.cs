using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GADE6112_Task2
{
    public class Map
    {
        List<Unit> units = new List<Unit>();
        Random r = new Random();
        int numUnits = 0;



        public Map(int n)
        {
            numUnits = n;
        }

        public void Generate()
        {
            for (int i = 0; i < numUnits; i++)
            {
                if (r.Next(0, 2) == 0) //Generate Melee Unit
                {
                    MeleeUnit m = new MeleeUnit(r.Next(0, 20), r.Next(0, 20), 100, 1, 20, (i % 2 == 0 ? 1 : 0), "M");
                    units.Add(m);
                }
                else //Generate Ranged Unit
                {
                    RangeUnit ru = new RangeUnit(r.Next(0, 20), r.Next(0, 20), 100, 1, 20, 5, (i % 2 == 0 ? 1 : 0), "R");
                    units.Add(ru);
                }
            }
        }


        public void Display(GroupBox groupBox)
        {
            groupBox.Controls.Clear();
            foreach (Unit u in units)
            {
                if (u is MeleeUnit)
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    Button b = new Button();
                    b.Size = new Size(40, 40);
                    b.Location = new Point(mu.XPos * 40, mu.YPos * 40);
                    b.Text = mu.Symbol;
                    if (mu.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }
                }
                else
                {
                    RangeUnit ru = (RangeUnit)u;
                    Button b = new Button();
                    b.Size = new Size(40, 40);
                    b.Location = new Point(ru.XPos * 40, ru.YPos * 40);
                    b.Text = ru.Symbol;
                    if (ru.Faction == 0)
                    {
                        b.ForeColor = Color.Red;
                    }
                    else
                    {
                        b.ForeColor = Color.Green;
                    }
                }

            }
        }


    }
}
