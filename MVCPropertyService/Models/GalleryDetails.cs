using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPropertyService.Models
{
  public class GalleryDetails
  {
    public IEnumerable<HouseGallery> DisplayHouseGallery { get; set; }
    public IEnumerable<LandGallery> DisplayLandGallery { get; set; }
    public IEnumerable<HouseGalleryDetail> DisplayHouseDetails{get; set;}
    public IEnumerable<LandGalleryDetail> DisplayLandDetails { get; set; }
    public EmailFormModel DisplayEmailForm { get; set; }
  }
}