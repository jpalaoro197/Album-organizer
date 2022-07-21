using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrg.Models;

namespace MusicOrg.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {
    public void Dispose()
    {
    Item.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }
  }
}