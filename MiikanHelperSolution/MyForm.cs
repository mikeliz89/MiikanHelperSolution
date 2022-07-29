﻿using System;
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

    //input to output and add commas and single quotes
    private void inputToOutputButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = ListHelper.GetOutputList(list, "'");
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
      //results
      resultsTextBox.Text = $"Muutettu {list.Count} riviä";
    }

    //add commas
    private void inputAddCommasButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = ListHelper.GetOutputList(list, "");
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
      var listOfSubStrings = ListHelper.GetListOfSubstrings(list);
      //output
      outputTextBox.Text = String.Join("\r\n", listOfSubStrings);
      outputRowCountLabel.Text = listOfSubStrings.Count + "";
    }

    private void inputAddTextButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = ListHelper.GetOutputList(list, inputAddTextTextBox.Text,
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

      //output
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";

      //results
      var list2 = GetRowsAsList(outputTextBox);
      resultsTextBox.Text += $"{Environment.NewLine}Output list count {list2.Count}";
    }

    private void inputToUpper_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = new List<string>();
      foreach(var row in list) {
        outputList.Add(row.ToUpper().ToString());
      }
      //output
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
    }

    private void inputToLower_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);
      var outputList = new List<string>();
      foreach(var row in list) {
        outputList.Add(row.ToLower().ToString());
      }
      //output
      outputTextBox.Text = String.Join("\r\n", outputList);
      outputRowCountLabel.Text = outputList.Count + "";
    }
  }
}
