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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      // Arrange
      List<Album> newList = new List<Album> { };

      // Act
      List<Album> result = Album.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Album newAlbum1 = new Album(description01);
      Album newAlbum2 = new Album(description02);
      List<Album> newList = new List<Album> { newAlbum1, newAlbum2 };

      //Act
      List<Album> result = Album.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
      public void GetId_AlbumsInstantiateWithAnIdAndGetterReturns_Int()
      {
       //Arrange
      string description = "Walk the dog.";
      Album newItem = new Album(description);

       //Act
      int result = newAlbum.Id;

        //Assert
      Assert.AreEqual(1, result);
      }
  }
}