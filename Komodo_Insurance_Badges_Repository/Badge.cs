using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Badges_Repository
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; } = new List<string>();
        public string BadgeName { get; set; }

        public Badge() { }
        public Badge(int badgeId, List<string> doorNames, string badgeName)
        {
            BadgeID = badgeId;
            DoorNames = doorNames;
            BadgeName = badgeName;
        }
    }

}
