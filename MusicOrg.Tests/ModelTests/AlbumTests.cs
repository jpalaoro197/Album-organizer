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
    Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("test");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog.";
      Album newAlbum = new Album(description);
      string result = newAlbum.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Album newAlbum = new Album(description);

      //Act
      string updatedDescription = "Do the dishes";
      newAlbum.Description = updatedDescription;
      string result = newAlbum.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
  }
}