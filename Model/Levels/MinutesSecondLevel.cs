using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public class MinutesSecondLevel : LevelBase
    {
        public MinutesSecondLevel()
            : base(4)
        {

        }
        public override string ParseTime(int hours, int minutes, int seconds)
        {
            base.CheckMinutes(minutes);
            var res = string.Empty;
            foreach (var n in Enumerable.Range(1, base.Colums))
            {
                res += (n <= (minutes % 5)) ? StatesColors.YELLOW : StatesColors.NONE;
            }
            return res + base.GetSeparator(true);
        }
    }
}
