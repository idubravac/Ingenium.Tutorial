using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Models.Interfaces
{
    public interface IObject
    {
        string Name { get; set; }

        DateTime? Start { get; set; }

        DateTime? Modifed { get; set; }

        DateTime? End { get; set; }

        bool IsAlive { get; set; }

        void Do();
    }
}
