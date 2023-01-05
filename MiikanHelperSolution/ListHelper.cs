using System;
using System.Collections.Generic;
using System.Linq;
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

    /// <summary>
    /// Etsi listan 1 asioita listalta 2
    /// </summary>
    /// <param name="list"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public static List<string> GetListContainingOtherList(List<string> list, List<string> list2) {
      var outputList = new List<string>();
      foreach(var row in list) {
        foreach(var row2 in list2) {
          if(row2.Contains(row)) {
            //älä laita useita kertoja
            if(!outputList.Contains(row)) {
              outputList.Add(row);
            }
          }
        }
      }
      return outputList;
    }

    /// <summary>
    /// Palauta lista niistä listan 1 asioista joita ei löydy listalta 2
    /// </summary>
    /// <param name="list"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public static List<string> GetListNotContainingOtherList(List<string> list, List<string> list2) {
      var outputList = new List<string>();
      foreach(var row in list) {
        var found = false;
        foreach(var row2 in list2) {
          if(row2.Contains(row)) {
            found = true;
          }
        }
        if(found == false) {
          if(!outputList.Contains(row)) {
            outputList.Add(row);
          }
        }
      }
      return outputList;
    }

    /// <summary>
    /// Hae rivit teskstistä ja palauta listana
    /// </summary>
    /// <param name="inputText"></param>
    /// <returns></returns>
    public static List<string> GetRowsAsList(string inputText) {
      var list = inputText.Split(new[] { '\r', '\n' }).Where(x => !string.IsNullOrEmpty(x)).ToList();
      return list;
    }

    /// <summary>
    /// Muuta erotinmerkin mukaan listaksi
    /// </summary>
    /// <param name="list"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static List<string> Split(List<string> list, string separator) {
      var outputList = new List<string>();
      foreach(var row in list) {
        var rowList = row.Split(separator.ToCharArray());
        foreach(var listItem in rowList) {
          var item = listItem.TrimStart().TrimEnd();
          if(!string.IsNullOrEmpty(item)) {
            outputList.Add(item);
          }
        }
      }
      return outputList;
    }

    /// <summary>
    /// Muuta listan kaikki rivit toUpper() stringeiksi eli isoille kirjaimille
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> ListToUpper(List<string> list) {
      var outputList = new List<string>();
      foreach(var row in list) {
        outputList.Add(row.ToUpper().ToString());
      }
      return outputList;
    }

    /// <summary>
    /// Muuta listan kaikki rivit toLower() stringeiksi eli pienille kirjaimille
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> ListToLower(List<string> list) {
      var outputList = new List<string>();
      foreach(var row in list) {
        outputList.Add(row.ToLower().ToString());
      }
      return outputList;
    }

    /// <summary>
    /// Poista listasta duplikaatit
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> RemoveDuplicates(List<string> list) {
      var outputList = list.Distinct().ToList();
      return outputList;
    }

    /// <summary>
    /// Palauta uusi lista listan 1 ja listan 2 eroista
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    public static List<string> CompareTwoLists(List<string> list1, List<string> list2) {
      var outputList = new List<string>();
      SetListDifferenceItemsToOutputList(list1, list2, outputList);
      SetListDifferenceItemsToOutputList(list2, list1, outputList);
      return outputList;
    }

    private static void SetListDifferenceItemsToOutputList(List<string> list1, List<string> list2, List<string> outputList) {
      foreach(var item in list1) {
        if(!list2.Contains(item)) {
          if(!outputList.Contains(item)) {
            outputList.Add(item);
          }
        }
      }
    }

    /// <summary>
    /// Korvaa listan textFrom-tekstit textTo texteillä
    /// </summary>
    /// <param name="list"></param>
    /// <param name="textFrom"></param>
    /// <param name="textTo"></param>
    /// <returns></returns>
    public static List<string> ReplaceListText(List<string> list, string textFrom, string textTo) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item.Replace(textFrom, textTo);
        outputList.Add(newItem);
      }
      return outputList;
    }

    /// <summary>
    /// Poista listalta annetut tekstit (case-sensitive)
    /// </summary>
    /// <param name="list"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    public static List<string> RemoveListText(List<string> list, string text) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item.Replace(text, "");
        //dont add empties
        if(!string.IsNullOrEmpty(newItem)) {
          outputList.Add(newItem);
        }
      }
      return outputList;
    }
  }
}
