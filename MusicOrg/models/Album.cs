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

    public static List<Album> GetAll()
    {
      return _instances;
    }

    public static Album Find(int searchId)
    {
      return _instances[searchId-1];
    }


    public static void ClearAll()
    {
      _instances.Clear();
    }

    
  }
}