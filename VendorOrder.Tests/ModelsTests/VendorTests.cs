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
      Category.ClearAll();
    }  
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

 }
}