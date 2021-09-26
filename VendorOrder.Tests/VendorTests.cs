using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {

      string name = "Test Vendor Name";
      string description = "Test Vendor Description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
      result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor Name";
      string description = "Test Vendor Description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Elizabeth";
      string description = "Dummy description";
      string name02 = "Jamison";
      Vendor newVendor1 = new Vendor(name01, description);
      Vendor newVendor2 = new Vendor(name02, description);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Elizabeth";
      string description = "Dummy description";
      string name02 = "Jamison";
      Vendor newVendor1 = new Vendor(name01, description);
      Vendor newVendor2 = new Vendor(name02, description);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
  }
  }
}