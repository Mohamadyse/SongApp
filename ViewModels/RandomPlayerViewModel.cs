using Aghanina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aghanina.ViewModels
{
    public class RandomPlayerViewModel
    {
        public Artist Artist { get; set; }
        public List<Song> songs = new List<Song> { new Song { Name = "survivor" }, new Song { Name = "lovely" } };
    }

}

