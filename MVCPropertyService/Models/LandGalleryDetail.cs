using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPropertyService.Models
{
  public class LandGalleryDetail
  {
    public int PropertyId { get; set; }
    public string PropertyName { get; set; }
    public string AddressLine { get; set; }
    public string Parish_Or_State { get; set; }
    public string Country { get; set; }
    public string Acres { get; set; }
    public string AskingPrice { get; set; }
    public string ViewSpot { get; set; }
    
  }
}