using System;
using System.ComponentModel.DataAnnotations;

namespace Promenade.Models
{
    public class Details
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}