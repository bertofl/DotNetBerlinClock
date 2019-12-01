using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Model.Levels
{
    public interface IBerlinClockLevel
    {
        string ParseTime(int hours, int minutes, int seconds);
    }
}
