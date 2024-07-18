using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtBoss.DataAccess
{
    public class Voyage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int VoyageEventId { get; set; }
        public IList<VoyageEvent> VoyageEvents { get; set; } = new List<VoyageEvent>();
    }
}
