using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Badges_Repository
{
    public class BadgeRepository
    {
        private List<Badge> _listofBadges = new List<Badge>();
                                                                    
        private Badge CreateBadges = new Badge();

        Dictionary<int, string> Badges = new Dictionary<int, string>();
            
        
        public void Doors()
        {
            for(int i = 0; i < 10; i++)
            {
                CreateBadges.DoorNames.Add("A" + i.ToString());
                CreateBadges.DoorNames.Add("B" + i.ToString());
                
            }
        }
        public void TestMe(int badgeId, string badgeName)
        {
            
            Badges.Add(badgeId, badgeName);
        }
        public void Loop()
        {
            foreach (string content in CreateBadges.DoorNames)
            {
                Console.WriteLine(content);
            }
        }

        public List<Badge> ViewAllBadges()
        {
            return _listofBadges;
        }
        
    }
}
