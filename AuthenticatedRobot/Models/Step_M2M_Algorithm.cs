using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthenticatedRobot.Models
{
    public class Step_M2M_Algorithm
    {
        public int ID { get; set; }
        public int AlgorithmID { get; set; }
        public Step Step { get; set; }
        public virtual Algorithm Algorithm { get; set; }
    }
}
