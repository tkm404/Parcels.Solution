using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public string PackageName { get; set; }
    public int Width { get;  set; }
    public int Height { get;  set; }
    public int Length { get;  set; }
    public int Weight { get;  set; }
    public int Price { get;  set; }
    private static List<Package> _instances = new List<Package> { };
    public Package (string pName)
    {
      PackageName = pName;
      _instances.Add(this);
    }
    public Package(string pName, int wi, int h, int l, int we, int p)
    {
      PackageName = pName;
      Width = wi;
      Height = h;
      Length = l;
      Weight = we;
      Price = p;
      _instances.Add(this);
    }

    public static List<Package> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}