using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWПерегрузка.Models
{
    enum TankType { T34, Panter};
    class Tank
    {

       /// <summary>
       /// Боекомплект
       /// </summary>
       private int Ammunition { get; set; }
        /// <summary>
        /// Броня
        /// </summary>
        private int Armor  { get; set; } 
        /// <summary>
        /// Манёвренность
        /// </summary>
        private int Maneuverablility  { get; set; } 

        public TankType TankType { get; set; }

        public Tank() { }
        public Tank(TankType Tank)
        {
            Random rand = new Random();
            Ammunition = rand.Next(0, 100);
            Armor = rand.Next(0, 100);
            Maneuverablility = rand.Next(0, 100);
            TankType = Tank;
        }

        public static Tank operator * (Tank t1, Tank t2)
        {
            Tank winner = new Tank();
            if (t1.Ammunition > t2.Ammunition &&
                t1.Armor > t2.Armor)
                winner = t1;
            else if (t1.Ammunition > t2.Ammunition &&
                t1.Maneuverablility > t2.Maneuverablility)
                winner = t1;
            else if (t1.Armor > t2.Armor &&
                t1.Maneuverablility > t2.Maneuverablility)
                winner = t1;
            else winner = t2;
            return winner;
        }

        public override string ToString()
        {
            string info = string.Format("Type: {0} " + " \n Боекомплект {1}" + "\n Броня {2}" + "\n Манёвренность {3}",
                this.TankType.ToString(), this.Ammunition, this.Armor, this.Maneuverablility);
            return info;
        }

    }
}
