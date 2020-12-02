using System;
using System.ComponentModel.DataAnnotations;

namespace Promenade.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}