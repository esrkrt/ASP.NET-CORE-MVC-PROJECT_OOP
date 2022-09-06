using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Cocrete
{
  public   class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Name { get; set; }
        public List <Customer> Customers { get; set; }
    }
}
