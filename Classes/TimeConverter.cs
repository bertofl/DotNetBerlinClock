using BerlinClock.Classes;
using BerlinClock.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var (hours, minutes, seconds) = SplitTime(aTime);
            string resultClock = string.Empty;
            foreach (var level in (LevesEnum[])Enum.GetValues(typeof(LevesEnum)))
            {
                resultClock += $"{LevelsFactory.GetLevel(level).ParseTime(hours, minutes, seconds)}";
            }
            return resultClock;
        }

        private (int, int, int) SplitTime(string time)
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            var list = time.Split(':');
            if(list.Count() > 3)
            {
                throw new ArgumentException();
            }
            if (list.Count() >= 1)
            {
                if (!int.TryParse(list[0], out hours))
                {
                    throw new ArgumentException();
                }
            }
            if (list.Count() >= 2)
            {
                if (!int.TryParse(list[1], out minutes))
                {
                    throw new ArgumentException();
                }
            }
            if (list.Count() == 3)
            {
                if (!int.TryParse(list[2], out seconds))
                {
                    throw new ArgumentException();
                }
            }
            return (hours, minutes, seconds);
        }
    }
}
