using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aghanina.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; } = "empty";
        public Artist Artist { get; set; }
        
    }
}
