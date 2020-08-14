using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Value
    {
        [Key]
        public int id { get; set; }     
        public string name { get; set; }    
        
    }
}