using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRpgIdea
{
    internal static class EventMasterList
    {
        internal static PointOfInterest TheChest = new PointOfInterest()
        {
            poiName = "shoddy chest",
            approachDescription = "You notice a shoddy looking chest a short ways ahead.",
            poiIntro = "Upon closer inspection, the chest appears to be roughly hewn from scrapwood and sheet metal, not like your typical storage chests. The thing looks more like a hastily thrown together bin with a lock.",
            Options = {}
        };
    }
}
