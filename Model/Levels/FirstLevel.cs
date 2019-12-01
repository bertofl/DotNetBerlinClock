using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public class FirstLevel : LevelBase
    {
        public FirstLevel()
            :base(1)
        {

        }
        public override string ParseTime(int hours, int minutes, int seconds)
        {
            base.CheckSeconds(seconds);
            return seconds % 2 > 0 ? StatesColors.NONE.ToString() + Environment.NewLine : StatesColors.YELLOW.ToString() + Environment.NewLine;
        }
    }
}
