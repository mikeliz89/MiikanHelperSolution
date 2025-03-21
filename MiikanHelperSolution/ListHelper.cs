using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

    /// <summary>
    /// Hae start ja end merkkien välinen teksti
    /// </summary>
    /// <param name="list"></param>
    /// <param name="startChar"></param>
    /// <param name="endChar"></param>
    /// <returns></returns>
    public static List<string> GetListOfSubstrings(List<string> list, char startChar = ' ', char endChar = ':') {

      var outputList = new List<string>();

      foreach(var listItem in list) {
        var indexOfStartChar = listItem.IndexOf(startChar);
        var indexOfEndChar = listItem.IndexOf(endChar);

        var characterCountBetweenStartAndEndIndex = indexOfStartChar - indexOfEndChar;

        if(characterCountBetweenStartAndEndIndex > 0) {
          var subString = listItem.Substring(indexOfEndChar + 1, characterCountBetweenStartAndEndIndex - 1);
          outputList.Add(subString);
        }
      }
      return outputList;
    }

    /// <summary>
    /// Hae start ja end sanojen välinen teksti
    /// </summary>
    /// <param name="list"></param>
    /// <param name="startString"></param>
    /// <param name="endString"></param>
    /// <param name="useCaseSensitive">oletuksena true niin esim ID ja id on eri. False niin id, ID, Id, iD kaikki tarkoittaa samaa</param>
    /// <returns></returns>
    public static List<string> GetListOfSubstringsByString(List<string> list, string startString, string endString, bool useCaseSensitive = true) {
      var outputList = new List<string>();
      foreach(var listItem in list) {
        var result =
          useCaseSensitive ? GetIdValueCaseSensitive(listItem, startString, endString) :
            GetIdValueCaseInSensitive(listItem, startString, endString);
        outputList.Add(result);
      }
      return outputList;
    }

    private static string GetIdValueCaseSensitive(string input, string startString, string endString) {
      string startMarker = startString;
      int startIndex = input.IndexOf(startMarker);
      if(startIndex != -1) {
        startIndex += startMarker.Length;
        int endIndex = input.IndexOf(endString, startIndex);
        if(endIndex != -1) {
          return input.Substring(startIndex, endIndex - startIndex);
        }
      }
      return string.Empty; // Return an empty string if no match is found
    }

    private static string GetIdValueCaseInSensitive(string input, string startString, string endString) {
      string startMarker = startString;
      int startIndex = input.IndexOf(startMarker, StringComparison.OrdinalIgnoreCase);
      if(startIndex != -1) {
        startIndex += startMarker.Length;
        int endIndex = input.IndexOf(endString, startIndex, StringComparison.OrdinalIgnoreCase);
        if(endIndex != -1) {
          return input.Substring(startIndex, endIndex - startIndex);
        }
      }
      return string.Empty; // Return an empty string if no match is found
    }

    /// <summary>
    /// Hae start ja end sanojen välinen teksti, mutta vain kokonaiset sanat
    /// </summary>
    /// <param name="list"></param>
    /// <param name="startString"></param>
    /// <param name="endString"></param>
    /// <returns></returns>
    public static List<string> GetListOfSubstringsByStringFullWordsOnly(List<string> list, string startString, string endString) {
      var outputList = new List<string>();
      foreach(var listItem in list) {
        var result = GetIdValueFullWordsOnly(listItem, startString, endString);
        outputList.Add(result);
      }
      return outputList;
    }

    private static string GetIdValueFullWordsOnly(string input, string startString, string endString) {
      // Construct the pattern to match exact word startString followed by any characters until endString
      string pattern = $@"\b{Regex.Escape(startString)}(.*?)\b{Regex.Escape(endString)}";
      Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
      if(match.Success) {
        return match.Groups[1].Value;
      }
      return string.Empty; // Return an empty string if no match is found
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

    public static List<string> GetDifferencesBetweenTwoLists(string[] list, string[] list2) {
      //The LINQ Except() method allows you to get the elements from the first sequence that are not in the second sequence.
      //It returns a new sequence with the type IEnumerable<T> that contains these elements. 
      return list.Except(list2).ToList();
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
    ///  Pilko lista erotinmerkin mukaan, palauta vain alkuosat
    /// </summary>
    /// <param name="list"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    /// <remarks>TODO Unit testi</remarks>
    public static List<string> SplitGetStarts(List<string> list, string separator) {
      var outputList = new List<string>();
      foreach(var row in list) {
        var rowList = row.Split(separator.ToCharArray());
        var start = rowList[0];
        outputList.Add(start.Trim());
      }
      return outputList;
    }

    /// <summary>
    /// Pilko lista erotinmerkin mukaan, palauta vain loppuosat
    /// </summary>
    /// <param name="list"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    /// <remarks>TODO Unit testi</remarks>
    public static List<string> SplitGetEnds(List<string> list, string separator) {
      var outputList = new List<string>();
      foreach(var row in list) {
        var rowList = row.Split(separator.ToCharArray());
        if(rowList.Length > 0) {
          var start = rowList[1];
          outputList.Add(start.Trim());
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
    /// 
    /// </summary>
    /// <param name="list"></param>
    /// <param name="textTo"></param>
    /// <returns></returns>
    public static List<string> ReplaceListItemTextWithGivenText(List<string> list, string textTo) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = string.Format(textTo, item);
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

    public static List<string> TrimEnds(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item.TrimEnd();
        if(!string.IsNullOrEmpty(newItem)) {
          outputList.Add(newItem);
        }
      }
      return outputList;
    }

    public static List<string> XmlToRows(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = FormatXML.FormatXMLString(item);
        if(!string.IsNullOrEmpty(newItem)) {
          outputList.Add(newItem);
        }
      }
      return outputList;
    }

    public static List<string> RemoveCharactersFromTheStart(List<string> list, int howManyCharacters) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item;
        if(!string.IsNullOrEmpty(newItem)) {
          outputList.Add(newItem.Remove(0, howManyCharacters));
        }
      }
      return outputList;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="list"></param>
    /// <param name="textToFind"></param>
    /// <returns></returns>
    /// <remarks>TODO: Kirjoita unit testi</remarks>
    public static string CountFoundText_Exact(List<string> list, string textToFind) {
      var count = 0;
      foreach(var item in list) {
        if(!string.IsNullOrEmpty(item)) {
          if(item == textToFind) {
            count++;
          }
        }
      }
      string result = GetCountText(textToFind, count);
      return result;
    }

    private static string GetCountText(string textToFind, int count) {
      return $"Found text {textToFind} {count} times";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="list"></param>
    /// <param name="textToFind"></param>
    /// <returns></returns>
    /// <remarks>TODO: Kirjoita unit testi</remarks>
    public static string CountFoundText_Contains(List<string> list, string textToFind) {
      var count = 0;
      foreach(var item in list) {
        if(!string.IsNullOrEmpty(item)) {
          if(item.Contains(textToFind)) {
            count++;
          }
        }
      }
      string result = GetCountText(textToFind, count);
      return result;
    }

    /// <summary>
    /// Hae välilyönnillä erotettuna viimeinen sana joka riviltä
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    /// <remarks>TOOD: Unit testit</remarks>
    public static List<string> GetLastWord(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item;

        string lastWord = newItem.Split(' ').Last();
        if(lastWord.Length < 1) {
          lastWord = " ";
        }
        outputList.Add(lastWord);
      }

      return outputList;
    }

    /// <summary>
    /// Järjestä aakkosittain
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> OrderByText(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item;
        if(string.IsNullOrWhiteSpace(newItem)) {
          continue;
        }
        outputList.Add(newItem);
      }
      return outputList.OrderBy(x => x).ToList();
    }

    /// <summary>
    /// Laske merkkijonon pituus (merkit yhteensä)
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static int CalculateStringLength(List<string> list) {
      var totalLength = 0;
      foreach(var item in list) {
        totalLength += item.Length;
      }
      return totalLength;
    }

    /// <summary>
    /// Laske listan jokaiselle merkkijonon pituus
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> CalculateStringLengthList(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        outputList.Add(item.Length.ToString());
      }
      return outputList;
    }

    /// <summary>
    /// Poista tyhjät listalta
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<string> RemoveEmpties(List<string> list) {
      var outputList = new List<string>();
      foreach(var item in list) {
        var newItem = item;
        if(string.IsNullOrWhiteSpace(newItem)) {
          continue;
        }
        outputList.Add(newItem);
      }
      return outputList;
    }

    /// <summary>
    /// Wrappaa pitkä teksti annetun pituisiksi riveiksi
    /// </summary>
    /// <param name="text"></param>
    /// <param name="maxLineLength"></param>
    /// <returns></returns>
    public static List<string> WordWrap(string text, int maxLineLength) {
      List<string> lines = new List<string>();
      string[] words = text.Split(' ');
      string currentLine = "";

      foreach(string word in words) {
        if(currentLine.Length > 0 && (currentLine.Length + word.Length + 1 > maxLineLength)) {
          lines.Add(currentLine.Trim());
          currentLine = "";
        }

        if(currentLine.Length > 0) {
          currentLine += " ";
        }

        currentLine += word;
      }

      if(!string.IsNullOrWhiteSpace(currentLine)) {
        lines.Add(currentLine.Trim());
      }

      return lines;
    }
  }

}