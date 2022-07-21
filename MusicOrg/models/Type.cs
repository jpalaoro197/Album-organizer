using System.Collections.Generic;

namespace MusicOrg.Models
{
  public class AlbumPlatform
  {
    private static List<AlbumPlatform> _instances = new List<AlbumPlatform> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Album> Albums { get; set; }

    public AlbumPlatform(string albumPlatform)
    {
      Name = albumPlatform;
      _instances.Add(this);
      Id = _instances.Count;
      Albums = new List<Album>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<AlbumPlatform> GetAll()
    {
      return _instances;
    }

    public static AlbumPlatform Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddAlbum(Album album)
    {
      Albums.Add(album);
    }
  }
}