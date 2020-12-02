using System;
using System.ComponentModel.DataAnnotations;

namespace Promenade.Models
{
    public class Food
    {
        public int Id { get; set; }
        public int Category {get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}