using BerlinClock.Enums;
using BerlinClock.Model.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public static class LevelsFactory
    {
        public static IBerlinClockLevel GetLevel(LevesEnum type)
        {
            switch(type)
            {
                case LevesEnum.First:
                    return new FirstLevel();
                case LevesEnum.FirstHour:
                    return new HourFirstLevel();
                case LevesEnum.SecondHour:
                    return new HourSecondLevel();
                case LevesEnum.FirstMinute:
                    return new MinutesFirstLevel();
                case LevesEnum.SecondMinute:
                    return new MinutesSecondLevel();
                default:
                    throw new KeyNotFoundException();
            }
        }
    }
}
