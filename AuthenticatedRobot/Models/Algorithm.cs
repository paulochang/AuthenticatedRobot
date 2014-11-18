using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticatedRobot.Models
{
    public class Algorithm
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created_date { get; set; }
        public virtual ICollection<Step_M2M_Algorithm> step_m2m_algorithm { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
