using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCPropertyService.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MVCPropertyService.BusinessLayer
{
  public class GalleryBusinessLayer
  {
    public IEnumerable<HouseGallery> HouseGalleries(int imageId)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<HouseGallery> houseGalleries = new List<HouseGallery>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetGallery", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputId", imageId);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          HouseGallery houseGallery = new HouseGallery();
          houseGallery.Photo = rdr["Photo"].ToString();
          houseGallery.AlternateText = rdr["AlternateText"].ToString();
          houseGallery.OrderId = rdr["OrderId"].ToString();

          houseGalleries.Add(houseGallery);
        }
      }
      return houseGalleries;

    }


    public IEnumerable<LandGallery> LandGalleries(int imageId)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<LandGallery> landGalleries = new List<LandGallery>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetGallery", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputId", imageId);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          LandGallery landGallery = new LandGallery();
          landGallery.Photo = rdr["Photo"].ToString();
          landGallery.AlternateText = rdr["AlternateText"].ToString();
          landGallery.OrderId = rdr["OrderId"].ToString();

          landGalleries.Add(landGallery);
        }
      }
      return landGalleries;

    }



    public IEnumerable<LandGalleryDetail> LandGalleryDetails(int id)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<LandGalleryDetail> landGalleryDetails = new List<LandGalleryDetail>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetLandGalleryDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputPropertyId", id);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          LandGalleryDetail landGalleryDetail = new LandGalleryDetail();
          landGalleryDetail.PropertyId = Convert.ToInt32(rdr["PropertyId"]);
          landGalleryDetail.PropertyName = rdr["PropertyName"].ToString();
          landGalleryDetail.AddressLine = rdr["AddressLine"].ToString();
          landGalleryDetail.Parish_Or_State = rdr["Parish_Or_State"].ToString();
          landGalleryDetail.Country = rdr["Country"].ToString();
          landGalleryDetail.Acres = rdr["Acres"].ToString();
          landGalleryDetail.AskingPrice = rdr["AskingPrice"].ToString();
          landGalleryDetail.ViewSpot = rdr["ViewSpot"].ToString();

          landGalleryDetails.Add(landGalleryDetail);
        }
      }
      return landGalleryDetails;

    }


    public IEnumerable<HouseGalleryDetail> HouseGalleryDetails(int id)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<HouseGalleryDetail> houseGalleryDetails = new List<HouseGalleryDetail>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetHouseDetails", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputPropertyId", id);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          HouseGalleryDetail houseGalleryDetail = new HouseGalleryDetail();
          houseGalleryDetail.PropertyId = Convert.ToInt32(rdr["PropertyId"]);
          houseGalleryDetail.PropertyName = rdr["PropertyName"].ToString();
          houseGalleryDetail.AddressLine = rdr["AddressLine"].ToString();
          houseGalleryDetail.Parish_Or_State = rdr["Parish_Or_State"].ToString();
          houseGalleryDetail.Country = rdr["Country"].ToString();
          houseGalleryDetail.AskingPrice = rdr["AskingPrice"].ToString();
          houseGalleryDetail.ViewSpot = rdr["ViewSpot"].ToString();
          houseGalleryDetail.No_Of_Rooms = Convert.ToInt32(rdr["No_Of_Rooms"]);
          houseGalleryDetail.No_Of_Bedrooms = Convert.ToInt32(rdr["No_Of_Bedrooms"]);
          houseGalleryDetail.No_Of_Bathrooms = Convert.ToInt32(rdr["No_Of_Bathrooms"]);
          houseGalleryDetail.No_Of_Kitchen = Convert.ToInt32(rdr["No_Of_Kitchen"]);
          houseGalleryDetail.No_Of_Livingrooms = Convert.ToInt32(rdr["No_Of_Livingrooms"]);

          houseGalleryDetails.Add(houseGalleryDetail);
        }
      }
      return houseGalleryDetails;

    }



    public IEnumerable<Land> LandProperties(string parish, string landPropertyType)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<Land> landProperties = new List<Land>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetLandProperty", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputParish", parish);
        cmd.Parameters.AddWithValue("@InputPropertyType", landPropertyType);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          Land landProperty = new Land();
          landProperty.PropertyId = Convert.ToInt32(rdr["PropertyId"]);
          landProperty.PropertyName = rdr["PropertyName"].ToString();
          landProperty.Acres = rdr["Acres"].ToString();
          landProperty.AskingPrice = rdr["AskingPrice"].ToString();
          landProperty.ViewSpot = rdr["ViewSpot"].ToString();
          landProperty.IndexImage = rdr["IndexImage"].ToString();

          landProperties.Add(landProperty);
        }
      }
      return landProperties;

    }



    public IEnumerable<House> HouseProperties(string parish, string housePropertyType)
    {

      string connectionString = ConfigurationManager.ConnectionStrings["PropertyService"].ConnectionString;

      List<House> houseProperties = new List<House>();

      using (SqlConnection con = new SqlConnection(connectionString))
      {
        SqlCommand cmd = new SqlCommand("spGetHouseProperty", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@InputParish", parish);
        cmd.Parameters.AddWithValue("@InputPropertyType", housePropertyType);

        con.Open();
        SqlDataReader rdr = cmd.ExecuteReader();
        while (rdr.Read())
        {
          House houseProperty = new House();
          houseProperty.PropertyId = Convert.ToInt32(rdr["PropertyId"]);
          houseProperty.PropertyName = rdr["PropertyName"].ToString();
          houseProperty.No_Of_Rooms = Convert.ToInt32(rdr["No_Of_Rooms"]);
          houseProperty.AskingPrice = rdr["AskingPrice"].ToString();
          houseProperty.ViewSpot = rdr["ViewSpot"].ToString();
          houseProperty.IndexImage = rdr["IndexImage"].ToString();

          houseProperties.Add(houseProperty);
        }
      }
      return houseProperties;

    }


  }
}