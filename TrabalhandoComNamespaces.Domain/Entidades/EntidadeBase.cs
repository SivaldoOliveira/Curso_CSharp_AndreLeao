using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComNamespaces.Domain.Entidades
{
   
        public abstract class EntidadeBase
        {
            public string Id { get; set; }


            protected EntidadeBase()
            {
                var guid = Guid.NewGuid();
                this.Id = guid.ToString();
            }
        }
    }

