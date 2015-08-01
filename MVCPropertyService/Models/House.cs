using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPropertyService.Models
{
  public class House
  {
    public int PropertyId { get; set; }
    public string PropertyName { get; set; }
    public int No_Of_Rooms { get; set; }
    public string AskingPrice { get; set; }
    public string ViewSpot { get; set; }
    public string IndexImage { get; set; }
  }
}