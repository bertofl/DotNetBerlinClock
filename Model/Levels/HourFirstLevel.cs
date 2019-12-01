using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public class HourFirstLevel : LevelBase
    {
        public HourFirstLevel()
            : base(4)
        {

        }
        public override string ParseTime(int hours, int minutes, int seconds)
        {
            base.CheckHours(hours);
            var res = string.Empty;
            foreach (var n in Enumerable.Range(1, base.Colums))
            {
                res += (n <= (hours / 5)) ? StatesColors.RED : StatesColors.NONE;
            }
            return res + base.GetSeparator();
        }
    }
}
