using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ANS_SHOP.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string ImagePath { get; set; }

        public string MinimumRequirements { get; set; }

        public string RecomendedRequirements { get; set; }
    }
}