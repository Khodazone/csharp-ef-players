﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
    }
}