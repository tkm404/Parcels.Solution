using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class PackageTests : IDisposable
  {
      public void Dispose()
      {
        Package.ClearAll();
      }
    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfPackge_Package()
    {
      Package newPackage = new Package("pack", 1, 2, 3, 4, 5);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }
    [TestMethod]
    public void PackageConstructor_SetsAWidth_Package()
    {      
      int wi = 1;
      Package newPackage = new Package("pack", wi, 2, 3, 4, 5);
      Assert.AreEqual (wi, newPackage.Width);
    }
    [TestMethod]
    public void PackageConstructor_SetsAHeight_Package()
    {      
      int h = 2;
      Package newPackage = new Package("pack", 1, h, 3, 4, 5);
      Assert.AreEqual (h, newPackage.Height);
    }
    [TestMethod]
    public void PackageConstructor_SetsALength_Package()
    {      
      int l = 3;
      Package newPackage = new Package("pack", 1, 2, l, 4, 5);
      Assert.AreEqual (l, newPackage.Length);
    }
    [TestMethod]
    public void PackageConstructor_SetsAWeight_Package()
    {      
      int we = 4;
      Package newPackage = new Package("pack", 1, 2, 3, we, 5);
      Assert.AreEqual (we, newPackage.Weight);
    }
        [TestMethod]
    public void PackageConstructor_SetsAPrice_Package()
    {      
      int p = 5;
      Package newPackage = new Package("pack", 1, 2, 3, 4, p);
      Assert.AreEqual (p, newPackage.Price);
    }
    [TestMethod]
    public void SetName_SetsAName_Package()
    {      
      string pName = "pack";
      Package newPackage = new Package(pName, 1, 2, 3, 4, 5);
      Assert.AreEqual (pName, newPackage.PackageName);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PackageList()
    { 
      List<Package> emptyList = new List<Package> {};
      List<Package> resultList = Package.GetAll();
      CollectionAssert.AreEqual(emptyList, resultList);
    }
    [TestMethod]
    public void GetAll_ReturnsPackages_PackageList()
    { 
      Package newPackage1 = new Package("pack", 1, 2, 3, 4, 5);
      Package newPackage2 = new Package("pack", 6, 7, 8, 9, 10);
      List<Package> result = new List<Package> {newPackage1, newPackage2};
      List<Package> resultList = Package.GetAll();
      CollectionAssert.AreEqual(result, resultList);
    }
  }
}