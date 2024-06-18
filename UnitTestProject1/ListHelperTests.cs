using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MiikanHelperSolution;
using System;

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
    public void RemoveDuplicates() {
      var input = new List<string>();
      input.Add("a");
      input.Add("a");
      input.Add("b");
      input.Add("c");

      var output = ListHelper.RemoveDuplicates(input);
      Assert.AreEqual(3, output.Count);
      Assert.AreEqual("a", output[0]);
      Assert.AreEqual("b", output[1]);
      Assert.AreEqual("c", output[2]);
    }

    [TestMethod]
    public void CompareTwoLists() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");

      var output = ListHelper.CompareTwoLists(list1, list2);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("2", output[0]);
      Assert.AreEqual("3", output[1]);
    }

    [TestMethod]
    public void GetListContainingOtherList() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");

      var output = ListHelper.GetListContainingOtherList(list1, list2);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("1", output[0]);
    }

    [TestMethod]
    public void GetListContainingOtherList_Test2() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");
      list2.Add("2");

      var output = ListHelper.GetListContainingOtherList(list1, list2);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("1", output[0]);
      Assert.AreEqual("2", output[1]);
    }

    [TestMethod]
    public void GetListContainingOtherList_List2Empty() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("2");

      var list2 = new List<string>();

      var output = ListHelper.GetListContainingOtherList(list1, list2);
      Assert.AreEqual(0, output.Count);
    }

    [TestMethod]
    public void GetListNotContainingOtherList() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");

      var output = ListHelper.GetListNotContainingOtherList(list1, list2);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("2", output[0]);
    }

    [TestMethod]
    public void GetListNotContainingOtherList_Test2() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("1");
      list1.Add("2");

      var list2 = new List<string>();
      list2.Add("1");
      list2.Add("3");

      var output = ListHelper.GetListNotContainingOtherList(list1, list2);
      Assert.AreEqual(1, output.Count);
      Assert.AreEqual("2", output[0]);
    }

    [TestMethod]
    public void GetListNotContainingOtherList_List2Empty() {
      var list1 = new List<string>();
      list1.Add("1");
      list1.Add("2");
      list1.Add("1");
      list1.Add("2");

      var list2 = new List<string>();

      var output = ListHelper.GetListNotContainingOtherList(list1, list2);
      Assert.AreEqual(2, output.Count);
      Assert.AreEqual("1", output[0]);
      Assert.AreEqual("2", output[1]);
    }

    [TestMethod]
    public void GetRowsAsList_SimpleInput() {
      var input = "abc";
      var list = ListHelper.GetRowsAsList(input);
      Assert.AreEqual(1, list.Count);
      Assert.AreEqual("abc", list[0]);
    }

    [TestMethod]
    public void GetRowsAsList_MoreComplexInput() {
      var input = "abc" + Environment.NewLine + "123";
      var list = ListHelper.GetRowsAsList(input);
      Assert.AreEqual(2, list.Count);
      Assert.AreEqual("abc", list[0]);
      Assert.AreEqual("123", list[1]);
    }

    [TestMethod]
    public void ReplaceListText() {
      var list = new List<string>();
      list.Add("Miikan hieno testi");
      list.Add("Toisen henkilön hieno testi");
      var textFrom = "hieno";
      var textTo = "upea";
      var outputList = ListHelper.ReplaceListText(list, textFrom, textTo);

      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("Miikan upea testi", outputList[0]);
      Assert.AreEqual("Toisen henkilön upea testi", outputList[1]);
    }

    [TestMethod]
    public void RemoveListText() {
      var list = new List<string>();
      list.Add("Test1");
      list.Add("Test1somethingtest2");
      list.Add("Something");

      //Huom! ei poista Something koska something on eri koska case-sensitive
      var text = "something";

      var outputList = ListHelper.RemoveListText(list, text);
      Assert.AreEqual(3, outputList.Count);
      Assert.AreEqual("Test1", outputList[0]);
      Assert.AreEqual("Test1test2", outputList[1]);
      Assert.AreEqual("Something", outputList[2]);
    }

    [TestMethod]
    public void TrimEnds() {
      var list = new List<string>();
      list.Add("Test 1      ");
      list.Add("  Test   2 ");
      list.Add("");
      list.Add(" ");

      var outputList = ListHelper.TrimEnds(list);
      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("Test 1", outputList[0]);
      Assert.AreEqual("  Test   2", outputList[1]);
    }

    [TestMethod]
    public void XmlToRows() {
      var list = new List<string>();
      var unformattedXml = "<data xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><section id=\"basics\"><PASI_VehicleNumber xsi:type=\"System.String\">97563600</PASI_VehicleNumber><organisation xsi:type=\"System.String\">Helsingin kaupunki </organisation><PASI_LicensePlateType xsi:type=\"System.String\">Suomalainen rekisterikilpi</PASI_LicensePlateType><PASI_CountryCode xsi:type=\"System.String\">FIN Suomi</PASI_CountryCode><PASI_RegisterNumber xsi:type=\"System.String\">FOR-452</PASI_RegisterNumber><PASI_ChassisNumber xsi:type=\"System.String\">WVWZZZAUZJP536084</PASI_ChassisNumber><PASI_VehicleType xsi:type=\"System.String\">HenkilÃ¶auto</PASI_VehicleType><PASI_VehicleBrand xsi:type=\"System.String\">Haulotte</PASI_VehicleBrand><PASI_VehicleModel xsi:type=\"System.String\">GOLF Farmari (AC) 5ov 999cm3 A</PASI_VehicleModel><PASI_VehicleColor xsi:type=\"System.String\">Valkoinen</PASI_VehicleColor><PASI_Vehicle_TotalMass xsi:type=\"System.String\">0 kg</PASI_Vehicle_TotalMass><PASI_Vehicle_Emissions xsi:type=\"System.String\">0 g/km</PASI_Vehicle_Emissions><PASI_Vehicle_NoPlates xsi:type=\"System.String\">ei</PASI_Vehicle_NoPlates><PASI_Vehicle_PilotVehicle xsi:type=\"System.String\">ei</PASI_Vehicle_PilotVehicle><PASI_AKEUpdate xsi:type=\"System.String\">kyllÃ¤</PASI_AKEUpdate><PASI_LatestAKEUpdate xsi:type=\"System.String\">11.11.2022</PASI_LatestAKEUpdate><PASI_VehicleDetails xsi:type=\"System.String\">[Merkki: VOLKSWAGEN VW]</PASI_VehicleDetails><PASI_Vehicle_ScheduledAKEUpdate xsi:type=\"System.String\" /><pasi_foul xsi:type=\"System.String\">113068435</pasi_foul><pasi_foul xsi:type=\"System.String\">113102425</pasi_foul><pasi_transfer xsi:type=\"System.String\">36145434</pasi_transfer><pasi_transfer xsi:type=\"System.String\">36145575</pasi_transfer><pasi_transfer xsi:type=\"System.String\">111980065</pasi_transfer><pasi_plate_history xsi:type=\"System.String\">25.04.2022 -  , Kilvellinen: kyllÃ¤</pasi_plate_history><pasi_ownerorpossessor xsi:type=\"System.String\">29.04.2021 - , Ajoneuvon haltija: Peura, Otto Matias</pasi_ownerorpossessor><pasi_ownerorpossessor xsi:type=\"System.String\">29.04.2021 - , Ajoneuvon omistaja: OP Yrityspankki Oyj</pasi_ownerorpossessor></section><section id=\"documentlist\" /></data>";
      list.Add(unformattedXml);

      var outputList = ListHelper.XmlToRows(list);
      Assert.AreEqual("", "");
    }

    [TestMethod]
    public void ReplaceListItemTextWithGivenText() {
      var list = new List<string> {
        "A",
        "B"
      };

      var outputList = ListHelper.ReplaceListItemTextWithGivenText(list, "insert into {0} text");
      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("insert into A text", outputList[0]);
      Assert.AreEqual("insert into B text", outputList[1]);
    }

    [TestMethod]
    public void RemoveCharactersFromTheStart() {
      var list = new List<string>();
      list.Add("ABC");
      list.Add("BC");

      var outputList = ListHelper.RemoveCharactersFromTheStart(list, 2);
      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("C", outputList[0]);
      Assert.AreEqual("", outputList[1]);
    }

    [TestMethod]
    public void GetDifferencesBetweenTwoLists_SecondListContainsOneOfTheFirstListItems() {
      var list = new List<string> {
        "TämäonTestirivi1",
        "TämäonTestirivi2"
      };

      var list2 = new List<string>();
      list2.Add("TämäonTestirivi1");

      //The LINQ Except() method allows you to get the elements from the first sequence that are not in the second sequence.
      //It returns a new sequence with the type IEnumerable<T> that contains these elements. 
      var differences = ListHelper.GetDifferencesBetweenTwoLists(list.ToArray(), list2.ToArray());

      Assert.AreEqual(1, differences.Count);
      Assert.AreEqual("TämäonTestirivi2", differences[0]);
    }

    [TestMethod]
    public void GetDifferencesBetweenTwoLists_SecondListContainsFirstListItems() {
      var list = new List<string>();
      list.Add("TämäonTestirivi1");

      var list2 = new List<string> {
        "TämäonTestirivi1",
        "TämäonTestirivi2"
      };

      //The LINQ Except() method allows you to get the elements from the first sequence that are not in the second sequence.
      //It returns a new sequence with the type IEnumerable<T> that contains these elements. 
      var differences = ListHelper.GetDifferencesBetweenTwoLists(list.ToArray(), list2.ToArray());

      Assert.AreEqual(0, differences.Count);
    }

    [TestMethod]
    public void GetDifferencesBetweenTwoLists_SecondListDoesNotContainFirstListItems() {
      var list = new List<string>();
      list.Add("TämäonTestirivi1");
      list.Add("TämäonTestirivi2");

      var list2 = new List<string> {
        "TämäonTestirivi3",
        "TämäonTestirivi4"
      };

      //The LINQ Except() method allows you to get the elements from the first sequence that are not in the second sequence.
      //It returns a new sequence with the type IEnumerable<T> that contains these elements. 
      var differences = ListHelper.GetDifferencesBetweenTwoLists(list.ToArray(), list2.ToArray());

      Assert.AreEqual(2, differences.Count);
      Assert.AreEqual("TämäonTestirivi1", differences[0]);
      Assert.AreEqual("TämäonTestirivi2", differences[1]);
    }

    [TestMethod]
    public void OrderByText_Test() {
      var list = new List<string>();
      list.Add("banaani");
      list.Add("Apina");
      list.Add("Ääkköset");
      list.Add("-testi123");
      list.Add(""); //tyhjä
      list.Add(" "); //pelkkä välilyönti
      
      var outputList = ListHelper.OrderByText(list);
      Assert.AreEqual(4, outputList.Count);

      Assert.AreEqual("Ääkköset", outputList[0]);
      Assert.AreEqual("Apina", outputList[1]);
      Assert.AreEqual("banaani", outputList[2]);
      Assert.AreEqual("-testi123", outputList[3]);
    }

    [TestMethod]
    public void GetListOfSubstringsByStringCaseSensitive_Test() {
      var list = new List<string>();
      list.Add("id=\"eka\"");
      list.Add("ID=\"toka\"");

      //hae id=" ja " -väliset merkit
      var outputList = ListHelper.GetListOfSubstringsByString(list, "id=\"", "\"", true);
      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("eka", outputList[0]);
      Assert.AreEqual("", outputList[1]);
    }

    [TestMethod]
    public void GetListOfSubstringsByStringCaseInSensitive_Test() {
      var list = new List<string>();
      list.Add("id=\"eka\"");
      list.Add("ID=\"toka\"");

      //hae id=" ja " -väliset merkit
      var outputList = ListHelper.GetListOfSubstringsByString(list, "id=\"", "\"", false);
      Assert.AreEqual(2, outputList.Count);
      Assert.AreEqual("eka", outputList[0]);
      Assert.AreEqual("toka", outputList[1]);
    }
  }
}
