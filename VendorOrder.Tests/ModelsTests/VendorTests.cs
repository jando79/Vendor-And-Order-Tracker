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

    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "VendorCO 1";
      string name02 = "VendorCO 2";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "VendorCo 1";
      string name02 = "VendorCo 2";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

 }
}