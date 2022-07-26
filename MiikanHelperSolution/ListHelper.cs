using System;
using System.Collections.Generic;
using System.Text;

namespace MiikanHelperSolution {
  public static class ListHelper {
    /// <summary>
    /// Yhdistä joka toinen rivi 
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> CombineEveryEachRow(List<string> list) {
      var outputList = new List<string>();
      string value = "";
      if(list.Count > 1) {
        for(int i = 1; i < list.Count + 1; i++) {
          if(i % 2 == 0) {
            value += list[i - 1];
            outputList.Add(value);
          } else {
            value = list[i - 1] + " ";
          }
        }
        if(!outputList.Contains(value)) {
          outputList.Add(value.TrimEnd());
        }
      } else if(list.Count == 1) {
        outputList.Add(list[0]);
      }

      return outputList;
    }

    public static List<string> GetOutputList(List<string> list,
      string charactersToAdd,
      bool addToStart = true,
      bool addToEnd = true,
      bool addCommas = true) {

      var outputList = new List<string>();
      for(int i = 0; i < list.Count; i++) {
        var newItem = new StringBuilder();
        if(addToStart) {
          newItem.Append(charactersToAdd);
        }
        newItem.Append(list[i]);
        if(addToEnd) {
          newItem.Append(charactersToAdd);
        }
        if(i == list.Count - 1) {
          Console.WriteLine("Last item : " + list[i]);
          outputList.Add(newItem.ToString());
        } else {
          if(addCommas) {
            newItem.Append(",");
          }
          outputList.Add(newItem.ToString());
        }
      }

      return outputList;
    }

    public static List<string> GetListOfSubstrings(List<string> list) {
      var listOfSubStrings = new List<string>();

      foreach(var listItem in list) {
        var indexOfSpace = listItem.IndexOf(' ');
        var indexOfColon = listItem.IndexOf(':');
        var characterCountBetweenSpaceAndColon = indexOfSpace - indexOfColon;
        if(characterCountBetweenSpaceAndColon > 0) {
          var subString = listItem.Substring(indexOfColon + 1, characterCountBetweenSpaceAndColon - 1);
          listOfSubStrings.Add(subString);
        }
      }

      return listOfSubStrings;
    }
  }
}
