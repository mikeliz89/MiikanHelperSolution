using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MiikanHelperSolution;

namespace UnitTestProject1 {

  [TestClass]
  public class ListHelperTests {

    [TestMethod]
    public void CombineEveryEachRow_EmptyInputList() {
      var input = new List<string>();
      var output = ListHelper.CombineEveryEachRow(input);
      Assert.AreEqual(0, output.Count);
    }

    [TestMethod]
    public void CombineEveryEachRow_OneItemInInputList() {
      var input = new List<string>();
      input.Add("test");
      var output = ListHelper.CombineEveryEachRow(input);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("test", output[0]);
    }

    [TestMethod]
    public void CombineEveryEachRow_TwoItemsInInputList() {
      var input = new List<string>();
      input.Add("test");
      input.Add("test2");
      var output = ListHelper.CombineEveryEachRow(input);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("test test2", output[0]);
    }

    [TestMethod]
    public void CombineEveryEachRow_ThreeItemsInInputList() {
      var input = new List<string>();
      input.Add("test");
      input.Add("test2");
      input.Add("test3");
      var output = ListHelper.CombineEveryEachRow(input);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("test test2", output[0]);
      Assert.AreEqual("test3", output[1]);
    }

    [TestMethod]
    public void CombineEveryEachRow_FourItemsInInputList() {
      var input = new List<string>();
      input.Add("test");
      input.Add("test2");
      input.Add("test3");
      input.Add("test4");
      var output = ListHelper.CombineEveryEachRow(input);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("test test2", output[0]);
      Assert.AreEqual("test3 test4", output[1]);
    }
  }
}
