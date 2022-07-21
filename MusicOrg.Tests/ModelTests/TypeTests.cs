using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrg.Models;
using System.Collections.Generic;
using System;

namespace MusicOrg.Tests
{
  [TestClass]
  public class TypeTests : IDisposable
  {

    public void Dispose()
    {
      Type.ClearAll();
    }

     [TestMethod]
    public void TypeConstructor_CreatesInstanceOfType_Type()
    {
      Type newType = new Type("test type");
      Assert.AreEqual(typeof(Type), newType.GetType());
    }
  }
}
