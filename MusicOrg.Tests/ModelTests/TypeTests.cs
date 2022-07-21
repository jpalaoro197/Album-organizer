using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrg.Models;
using System.Collections.Generic;
using System;

namespace MusicOrg.Tests
{
  [TestClass]
  public class AlbumPlatformTests : IDisposable
  {

    public void Dispose()
    {
      AlbumPlatform.ClearAll();
    }

     [TestMethod]
    public void AlbumPlatformConstructor_CreatesInstanceOfAlbumPlatform_AlbumPlatform()
    {
      AlbumPlatform newAlbumPlatform = new AlbumPlatform("test type");
      Assert.AreEqual(typeof(AlbumPlatform), newAlbumPlatform.GetType());
    }

     [TestMethod]
    public void GetName_ReturnsName_String()
    {
    //Arrange
    string name = "Test Platform";
    AlbumPlatform newPlatform = new AlbumPlatform(name);

    //Act
    string result = newPlatform.Name;

    //Assert
    Assert.AreEqual(name, result);
    }
  }
}
