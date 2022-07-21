using System.Collections.Generic;

namespace MusicOrg.Models
{
  public class Album
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Album> _instances = new List<Album> {};

    public Album (string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}