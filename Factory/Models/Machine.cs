using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        [Required(ErrorMessage = "The machine's description can't be empty!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The machine's name can't be empty!")]
        public string Name { get; set; }
        public List<MachineEngineer> JoinEntities { get; }
    }
}
// public class Machine
//     {
//         public int MachineId { get; set; }
//         [Required(ErrorMessage = "The Machine's description can't be empty!")]
//         public string Description { get; set; }
//         [Range(1, int.MaxValue, ErrorMessage = "You must add your engineer to a machine. Have you added a machine yet?")]
//         public int EngineerId { get; set; }
//         public Engineer Engineer { get; set; }
//         public List<MachineEngineer> JoinEntities { get;}
//     }