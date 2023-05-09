using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    public int Width { get;  set; }
    public int Height { get;  set; }
    public int Length { get;  set; }
    public int Weight { get;  set; }
    private static List<Package> _instances = new List<Package> { };
    public Package(int wi, int h, int l, int we)
    {
      Width = wi;
      Height = h;
      Length = l;
      Weight = we;
    }
  }
}