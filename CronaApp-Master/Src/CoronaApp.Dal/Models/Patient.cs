using System.ComponentModel.DataAnnotations;

namespace CoronaApp.Dal.Models
{
    public class Patient
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}