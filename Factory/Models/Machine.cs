using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "Please enter machine's description to continue.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter machine's name to continue.")]
        public string Name { get; set; }
        public List<MachineEngineer> JoinEntities { get; }
    }
}