using System.Collections.Generic;

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
  }
}
