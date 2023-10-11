using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Demo.Entities
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }

        protected EntidadeBase(int id)
        {
            Id = id;
        }

        protected EntidadeBase() { }
    }
}
