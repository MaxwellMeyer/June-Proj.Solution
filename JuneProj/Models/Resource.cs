using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JuneProj.Models
{
  public class Resource
  {
    public int ResourceId { get; set; }
    public string Description { get; set; }
    public string Website { get; set; }
    public string Location { get; set; }
  }
}
