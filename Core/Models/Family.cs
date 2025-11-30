using System;

namespace MyApp.Core.Models
{
    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
