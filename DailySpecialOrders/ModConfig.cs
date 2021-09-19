using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySpecialOrders
{
    public class ModConfig
    {
        public bool RefreshAfterPicking { get; set; } = true;
        public bool RefreshTuesday { get; set; } = true;
        public bool RefreshWednesday { get; set; } = true;
        public bool RefreshThursday { get; set; } = true;
        public bool RefreshFriday { get; set; } = true;
        public bool RefreshSaturday { get; set; } = true;
        public bool RefreshSunday { get; set; } = true;
    }
}
