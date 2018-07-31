using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Models.Interfaces
{
    public interface IObjectEntity : IObject
    {
        decimal? Weight { get; set; }
    }
}
