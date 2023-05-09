using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class PackageTests
  {
    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfPackge_Package()
    {
      Package newPackage = new Package(1, 2, 3, 4);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }
  }
}