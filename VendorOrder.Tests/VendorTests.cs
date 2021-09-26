using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Category()
    {
      Vendor newVendor = new Vendor("test name", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}