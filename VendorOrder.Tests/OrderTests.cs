using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }



    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder()
    {
      string title = "dummy title";
      string description = "dummy title";
      string price = "dummy title";
      string date = "dummy title";
    
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
    
      string title = "dummy title";
      string description = "dummy title";
      string price = "dummy title";
      string date = "dummy title";
    
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);

      result = newOrder.Description;
      Assert.AreEqual(description, result);

      result = newOrder.Price;
      Assert.AreEqual(price, result);

      result = newOrder.Date;
      Assert.AreEqual(date, result);

    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string title = "dummy title";
      string description = "dummy title";
      string price = "dummy title";
      string date = "dummy title";
      Order newOrder = new Order(title, description, price, date);

      string updatedDescription = "updated description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {

      List<Order> newList = new List<Order> { };


      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "dummy title";
      string description1 = "dummy title";
      string price1 = "dummy title";
      string date1 = "dummy title";

      string title2 = "dummy title";
      string description2 = "dummy title";
      string price2 = "dummy title";
      string date2 = "dummy title";
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}