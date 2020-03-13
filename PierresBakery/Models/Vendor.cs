using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name {get; set; }
    public int ID { get; set; }
    public List<Order> Orders {get; set;}
  }
}