using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Models
{
    public class HumanRelationship
    {
        public Human Person { get; set; }

        public bool IsChild { get; set; }

        public bool IsWife{ get; set; }

        public bool IsParent { get; set; }

        public bool IsRelative { get; set; }

        public bool IsFriend { get; set; }

        public bool IsContact { get; set; }
    }
}
