using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiikanHelperSolution {
  public partial class MyForm : Form {

    private RadioButton selectedRadioButton;

    public MyForm() {
      InitializeComponent();
      selectedRadioButton = inputStartRadioButton;
    }

    //input to output and add commas and single quotes
    private void inputToOutputButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = GetOutputList(list, "'");
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    private static List<string> GetOutputList(List<string> list, string charactersToAdd,
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

    //add commas
    private void inputAddCommasButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = GetOutputList(list, "");
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    private List<string> GetRowsAsList(TextBox textBox) {
      var inputText = textBox.Text;
      var list = inputText.Split(new[] { '\r', '\n' }).Where(x => !string.IsNullOrEmpty(x)).ToList();
      return list;
    }

    //remove duplicates
    private void outputRemoveDuplicates_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(outputTextBox);
      var outputList = list.Distinct().ToList();
      //output
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
      //results
      var q = from x in list
              group x by x into g
              let count = g.Count()
              orderby count descending
              select new { Value = g.Key, Count = count };
      resultsTextBox.Text = "";
      foreach(var x in q) {
        if(x.Count > 1) {
          resultsTextBox.Text += Environment.NewLine + $" Value {x.Value} Count: {x.Count}";
        }
      }
    }

    //ouput combine every each row 
    private void outputCombineEveryEachRowButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(outputTextBox);
      var outputList = ListHelper.CombineEveryEachRow(list);
      //output
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
    }

    private void inputCountRowsButton_Click(object sender, EventArgs e) {
      //results
      var list = GetRowsAsList(inputTextBox);
      resultsTextBox.Text = $"Input list count {list.Count}";
    }

    private void outputCountRowsButton_Click(object sender, EventArgs e) {
      //results
      var list = GetRowsAsList(outputTextBox);
      resultsTextBox.Text = $"Output list count {list.Count}";
    }

    private void inputGetUserIDsButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
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
      //output
      outputTextBox.Text = String.Join("\r\n", listOfSubStrings);
      outputRowCountLabel.Text = listOfSubStrings.Count + "";
    }

    private void inputAddTextButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = GetOutputList(list, inputAddTextTextBox.Text,
        inputStartRadioButton.Checked, inputEndRadioButton.Checked, false);
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    private void radioButtonCheckedChanged(object sender, EventArgs e) {
      var rb = sender as RadioButton;

      if(rb == null) {
        MessageBox.Show("Sender is not a RadioButton");
        return;
      }

      if(rb.Checked) {
        // Keep track of the selected RadioButton by saving a reference
        // to it.
        selectedRadioButton = rb;
      }
    }
  }
}
