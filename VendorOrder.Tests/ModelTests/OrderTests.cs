using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
      
    }
  
  
  
  }
}