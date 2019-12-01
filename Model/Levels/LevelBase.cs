using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public abstract class LevelBase : IBerlinClockLevel
    {
        protected int Colums;
        public LevelBase(int _colums)
        {
            Colums = _colums;
        }

        public abstract string ParseTime(int hours, int minutes, int seconds);
        public string GetSeparator(bool isLast = false) => isLast ? string.Empty : Environment.NewLine;

        protected void CheckHours(int hours)
        {
            if (hours > 24 || hours < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        protected void CheckMinutes(int minutes)
        {
            if (minutes > 59 || minutes < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        protected void CheckSeconds(int seconds)
        {
            if (seconds > 59 || seconds < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
