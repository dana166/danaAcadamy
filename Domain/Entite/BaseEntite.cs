using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entite
{
    public class BaseEntite
    {
     
        public Guid id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDelete { get; set; }
        


    }
}
