using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public class MinutesFirstLevel : LevelBase
    {
        public MinutesFirstLevel()
            : base(11)
        {

        }
        public override string ParseTime(int hours, int minutes, int seconds)
        {
            base.CheckMinutes(minutes);
            var res = string.Empty;
            foreach (var n in Enumerable.Range(1, base.Colums))
            {
                res += (n <= (minutes / 5)) ? (n % 3 == 0) ? StatesColors.RED  : StatesColors.YELLOW : StatesColors.NONE;
            }
            return res + base.GetSeparator();
        }
    }
}
