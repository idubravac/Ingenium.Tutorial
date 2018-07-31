using AI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Models.Interfaces
{
    public interface ILivingEntity : IObject
    {
        void SetAge();

        decimal Weight { get; set; }

        decimal Height { get; set; }

        Gender Gender { get; set; }

        void Eat(IObjectEntity food);

        void Breathe();

        void Reproduce();
    }

   
}
