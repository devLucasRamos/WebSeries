using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSeries.Entity
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
    }
}
