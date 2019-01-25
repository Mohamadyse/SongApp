using System.Collections.Generic;

namespace Aghanina.Models
{
    public class Artist
    {
        public string name { get; set; }
        public int Id { get; set; }
        public ICollection<Song> MyProperty { get; set; }
    }
}