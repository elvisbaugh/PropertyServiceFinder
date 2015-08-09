using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPropertyService.Models
{
  public class EmailFormModel
  {
    public string Name { get; set; }
    public string FromContactPhoneNumber { get; set; }
    public string Address { get; set; }
    public string MessageBody { get; set; }
  }
}