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

    [TestMethod]
    public void GetId_ReturnsPlatformId_Int()
    { 
    //Arrange
    string name = "Test platform";
    AlbumPlatform newPlatform = new AlbumPlatform(name);

    //Act
    int result = newPlatform.Id;

    //Assert
    Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllPlatformObjects_PlatformList()
    {
    //Arrange
    string name01 = "Work";
    string name02 = "School";
    AlbumPlatform newPlatform1 = new AlbumPlatform(name01);
    AlbumPlatform newPlatform2 = new AlbumPlatform(name02);
    List<AlbumPlatform> newList = new List<AlbumPlatform> { newPlatform1, newPlatform2 };

    //Act
    List<AlbumPlatform> result = AlbumPlatform.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
    }
  }
}
