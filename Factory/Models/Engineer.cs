using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Please enter engineer's name to continue.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please enter engineer's description to continue.")]
    public string Description { get; set; }
    public List<MachineEngineer> JoinEntities { get;}
  }
}