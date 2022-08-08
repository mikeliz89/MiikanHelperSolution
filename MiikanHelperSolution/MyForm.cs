using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiikanHelperSolution {
  public partial class MyForm : Form {

    private RadioButton selectedRadioButton;

    public MyForm() {
      InitializeComponent();
      outputRowCountLabel.Text = "";
      selectedRadioButton = inputStartRadioButton;
    }

    /// <summary>
    /// Lisää pilkut ja heittomerkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToOutputButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = ListHelper.GetOutputList(list, charactersToAdd: "'");

      ShowAsOutput(outputList);

      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    /// <summary>
    /// Lisää pilkut
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddCommasButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = ListHelper.GetOutputList(list, charactersToAdd: "", addToStart: true, addToEnd: true, addCommas: true);

      ShowAsOutput(outputList);

      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    private List<string> GetRowsAsList(TextBox textBox) {
      var inputText = textBox.Text;
      var list = inputText.Split(new[] { '\r', '\n' }).Where(x => !string.IsNullOrEmpty(x)).ToList();
      return list;
    }

    /// <summary>
    /// Poista outputlistalta duplikaatit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputRemoveDuplicates_Click(object sender, EventArgs e) {

      var list = GetRowsAsList(outputTextBox);
      ShowDuplicatesInResults(list);

      var outputList = ListHelper.RemoveDuplicates(list);
      ShowAsOutput(outputList);
    }

    private void ShowDuplicatesInResults(List<string> list) {

      //results
      var q = from x in list
              group x by x into g
              let count = g.Count()
              orderby count descending
              select new { Value = g.Key, Count = count };

      resultsTextBox.Text = "";

      foreach(var x in q) {
        if(x.Count > 1) {
          resultsTextBox.Text += $" Value {x.Value} Count: {x.Count}" + Environment.NewLine;
        }
      }
    }

    /// <summary>
    /// Yhdistä outputin joka toinen rivi
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputCombineEveryEachRowButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(outputTextBox);
      var outputList = ListHelper.CombineEveryEachRow(list);

      ShowAsOutput(outputList);
    }

    /// <summary>
    /// Laske input-listan rivit ja näytä resultsissa
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputCountRowsButton_Click(object sender, EventArgs e) {
      //results
      var list = GetRowsAsList(inputTextBox);
      resultsTextBox.Text = $"Input list count {list.Count}";
    }

    /// <summary>
    /// Laske output-listan rivit ja näytä resultsissa
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputCountRowsButton_Click(object sender, EventArgs e) {
      //results
      var list = GetRowsAsList(outputTextBox);
      resultsTextBox.Text = $"Output list count {list.Count}";
    }

    /// <summary>
    /// Hanki riveiltä : ja välilyönti väliset merkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputGetUserIDsButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var listOfSubStrings = ListHelper.GetListOfSubstrings(list);

      ShowAsOutput(listOfSubStrings);
    }

    /// <summary>
    /// Lisää tekstiä
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddTextButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.GetOutputList(list,
        charactersToAdd: inputAddTextTextBox.Text,
        addToStart: GetAddToStart(),
        addToEnd: GetAddToEnd(),
        addCommas: false);

      ShowAsOutput(outputList);

      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    private bool GetAddToEnd() {
      if(inputStartRadioButton.Checked) {
        return false;
      } else if(inputEndRadioButton.Checked) {
        return true;
      } else if(inputStartAndEndRadioButton.Checked) {
        return true;
      }
      return false;
    }

    private bool GetAddToStart() {
      if(inputStartRadioButton.Checked) {
        return true;
      } else if(inputEndRadioButton.Checked) {
        return false;
      } else if(inputStartAndEndRadioButton.Checked) {
        return true;
      }
      return false;
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

    /// <summary>
    /// Etsi input -tekstejä tiedostosta
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputSearchFromFilePath_Click(object sender, EventArgs e) {

      resultsTextBox.Text = "";

      var filePath = inputFilePath.Text;

      //guards
      if(string.IsNullOrEmpty(filePath)) {
        resultsTextBox.Text = "Filepath cannot be null or empty";
        return;
      }
      if(!File.Exists(filePath)) {
        resultsTextBox.Text = "File does not exist";
        return;
      }

      var filesLines = File.ReadAllLines(filePath);

      resultsTextBox.Text += $"Found {filesLines.Length} lines from file";

      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.GetListContainingOtherList(list, filesLines.ToList());

      ShowAsOutput(outputList);

      //results
      var list2 = GetRowsAsList(outputTextBox);
      resultsTextBox.Text += $"{Environment.NewLine}Output list count {list2.Count}";
    }

    /// <summary>
    /// ToUpper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToUpper_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.ListToUpper(list);

      ShowAsOutput(outputList);
    }

    /// <summary>
    /// ToLower
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToLower_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.ListToLower(list);

      ShowAsOutput(outputList);
    }

    /// <summary>
    /// Splittaa lista erotinmerkin avulla
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputSplitCsvBtn_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.Split(list, inputSplitCsv.Text);

      ShowAsOutput(outputList);
    }

    private void ShowAsOutput(List<string> outputList) {
      //output
      outputTextBox.Text = string.Join(Environment.NewLine, outputList);
      outputRowCountLabel.Text = outputList.Count + "";
    }

    /// <summary>
    /// Lisää heittomerkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddSingleQuotes_Click(object sender, EventArgs e) {

      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.GetOutputList(list, charactersToAdd: "'", addToStart: true, addToEnd: true, addCommas: false);

      ShowAsOutput(outputList);

      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    /// <summary>
    /// Näytä output duplikaatit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputShowDuplicates_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(outputTextBox);
      ShowDuplicatesInResults(list);
    }

    private void inputShowDuplicates_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      ShowDuplicatesInResults(list);
    }

    private void inputRemoveDuplicates_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      ShowDuplicatesInResults(list);

      var outputList = ListHelper.RemoveDuplicates(list);
      ShowAsOutput(outputList);
    }
  }
}
