using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeoREST
{

public class SingleLineAddressField
{
    public string name { get; set; }
    public string type { get; set; }
    public string alias { get; set; }
    public bool required { get; set; }
    public int length { get; set; }
    //public LocalizedNames2 localizedNames { get; set; }
    //public RecognizedNames2 recognizedNames { get; set; }
}

public class AddressField
{
  public string name { get; set; }
  public string type { get; set; }
  public string alias { get; set; }
  public bool required { get; set; }
  public int length { get; set; }
}


public class CandidateField
{
    public string name { get; set; }
    public string type { get; set; }
    public string alias { get; set; }
    public bool required { get; set; }
    public int length { get; set; }
}

public class SpatialReference
{
    public int wkid { get; set; }
    public int latestWkid { get; set; }
}

public class LocatorProperties
{
    public string UICLSID { get; set; }
    public string IntersectionConnectors { get; set; }
    public int SuggestedBatchSize { get; set; }
    public int MaxBatchSize { get; set; }
    public int LoadBalancerTimeOut { get; set; }
    public string WriteXYCoordFields { get; set; }
    public string WriteStandardizedAddressField { get; set; }
    public string WriteReferenceIDField { get; set; }
    public string WritePercentAlongField { get; set; }
}

public class GeocodeServerMetadata
{
    public double currentVersion { get; set; }
    public string serviceDescription { get; set; }
    public List<AddressField> addressFields { get; set; }
    public SingleLineAddressField singleLineAddressField { get; set; }
    public List<CandidateField> candidateFields { get; set; }
    public SpatialReference spatialReference { get; set; }
    public LocatorProperties locatorProperties { get; set; }
    public List<string> countries { get; set; }

    public GeocodeServerMetadata()
    {
      this.currentVersion = 10.2;
      this.serviceDescription = "NYC Geoclient";
      this.singleLineAddressField = new SingleLineAddressField();
      this.singleLineAddressField.name = "SingleLine";
      this.singleLineAddressField.type = "esriFieldTypeString";
      this.singleLineAddressField.alias = "Single Line Input";
      this.singleLineAddressField.required = false;
      this.singleLineAddressField.length = 100;

      this.spatialReference = new SpatialReference() { wkid = 4326, latestWkid = 4326 };
      this.countries = new List<string>();
      this.countries.Add("US");

      this.addressFields = new List<AddressField>();
      this.addressFields.Add(new AddressField(){ alias = "Name", required=true, length= 100, name = "name", type = "esriFieldTypeString"});
 
      this.candidateFields = new List<CandidateField>();
      this.candidateFields.Add(new CandidateField() { name = "Loc_name", type = "esrifieldTypeString", alias = "Loc_name", required = false, length = 22 });

      this.locatorProperties = new LocatorProperties();
      this.locatorProperties.IntersectionConnectors = "&amp; @ | and";
      this.locatorProperties.SuggestedBatchSize = 0;
      this.locatorProperties.MaxBatchSize = 0;
      this.locatorProperties.LoadBalancerTimeOut = 60;
      this.locatorProperties.WriteXYCoordFields = "TRUE";
      this.locatorProperties.WriteStandardizedAddressField = "FALSE";
      this.locatorProperties.WriteReferenceIDField = "FALSE";
      this.locatorProperties.WritePercentAlongField = "FALSE";
      this.locatorProperties.UICLSID = "1234";



    }

}


}