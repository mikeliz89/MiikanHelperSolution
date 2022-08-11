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

    [TestMethod]
    public void GetOutputList_EmptyInputList() {
      var input = new List<string>();
      var output = ListHelper.GetOutputList(input, "'");
      Assert.AreEqual(0, output.Count);
    }

    [TestMethod]
    public void GetOutputList_OneItemInInputList() {
      var input = new List<string>();
      input.Add("Test");
      var output = ListHelper.GetOutputList(input, "'", addToStart: true, addToEnd: true, addCommas:false);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("'Test'", output[0]);

      var output2 = ListHelper.GetOutputList(input, "'", addToStart: true, addToEnd: true, addCommas: true);
      Assert.AreEqual(1, output2.Count);
      Assert.AreEqual("'Test'", output2[0]);
    }

    [TestMethod]
    public void GetOutputList_OneItemInInputList_AddToStartAndEndFalse() {
      var input = new List<string>();
      input.Add("Test");
      var output = ListHelper.GetOutputList(input, "'", addToStart: false, addToEnd: false, addCommas: false);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("Test", output[0]);

      var output2 = ListHelper.GetOutputList(input, "'", addToStart: false, addToEnd: false, addCommas: true);
      Assert.AreEqual(1, output2.Count);
      Assert.AreEqual("Test", output2[0]);
    }

    [TestMethod]
    public void GetOutputList_TwoItemsInInputList() {
      var input = new List<string>();
      input.Add("Test");
      input.Add("Test2");
      var output = ListHelper.GetOutputList(input, "'", addToStart: true, addToEnd: true, addCommas: false);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("'Test'", output[0]);
      Assert.AreEqual("'Test2'", output[1]);

      var output2 = ListHelper.GetOutputList(input, "'", addToStart: true, addToEnd: true, addCommas: true);
      Assert.AreEqual(2, output2.Count);
      Assert.AreEqual("'Test',", output2[0]);
      Assert.AreEqual("'Test2'", output2[1]);
    }

    [TestMethod]
    public void GetListOfSubstrings_EmptyInputList() {
      var input = new List<string>();
      var output = ListHelper.GetListOfSubstrings(input);
      Assert.AreEqual(0, output.Count);
    }

    [TestMethod]
    public void GetListOfSubstrings_OneItemInInputList() {
      var input = new List<string>();
      input.Add("User:1234 testing");
      var output = ListHelper.GetListOfSubstrings(input);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("1234", output[0]);
    }

    [TestMethod]
    public void GetListOfSubstrings_OneItemInInputList_IncorrectSpaces() {
      var input = new List<string>();
      input.Add("User: 1234 testing");
      var output = ListHelper.GetListOfSubstrings(input);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("", output[0]);
    }

    [TestMethod]
    public void Split_TwoCommaSeparatedItemsInInputList() {
      var input = new List<string>();
      input.Add("a,b");
      input.Add("c,d");
      var output = ListHelper.Split(input, ",");
      Assert.AreEqual(4, output.Count);
      Assert.AreEqual("a", output[0]);
      Assert.AreEqual("b", output[1]);
      Assert.AreEqual("c", output[2]);
      Assert.AreEqual("d", output[3]);
    }

    [TestMethod]
    public void Split_TwoCommaSeparatedItemsInInputList_WrongSeparator() {
      var input = new List<string>();
      input.Add("a,b");
      input.Add("c,d");
      var output = ListHelper.Split(input, ";");
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("a,b", output[0]);
      Assert.AreEqual("c,d", output[1]);
    }

    [TestMethod]
    public void Split_OneItemContainingMultipleCommas() {
      var input = new List<string>();
      input.Add("a,b,c,d,e");
      var output = ListHelper.Split(input, ",");
      Assert.AreEqual(5, output.Count);
      Assert.AreEqual("a", output[0]);
      Assert.AreEqual("b", output[1]);
      Assert.AreEqual("c", output[2]);
      Assert.AreEqual("d", output[3]);
      Assert.AreEqual("e", output[4]);
    }

    [TestMethod]
    public void ToUpper() {
      var input = new List<string>();
      input.Add("a,b");
      input.Add("c,d");
      var output = ListHelper.ListToUpper(input);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("A,B", output[0]);
      Assert.AreEqual("C,D", output[1]);
    }

    [TestMethod]
    public void ToLower() {
      var input = new List<string>();
      input.Add("a,b");
      input.Add("c,d");
      var output = ListHelper.ListToLower(input);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("a,b", output[0]);
      Assert.AreEqual("c,d", output[1]);
    }

    [TestMethod]
    public void CompareTwoLists() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");

      var output = ListHelper.CompareTwoLists(list1, list2);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("2", output[0]);
      Assert.AreEqual("3", output[1]);
    }
  }
}
