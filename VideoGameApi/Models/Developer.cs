using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameApi.Models
{
    public class Developer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}