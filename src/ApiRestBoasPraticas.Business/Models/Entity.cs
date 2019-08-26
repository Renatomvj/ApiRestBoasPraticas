using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestBoasPraticas.Business.Models
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
