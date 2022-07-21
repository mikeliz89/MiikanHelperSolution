using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MiikanHelperSolution {
  public partial class MyForm : Form {
    public MyForm() {
      InitializeComponent();
    }

    //input to output and add commas and single quotes
    private void inputToOutputButton_Click(object sender, EventArgs e) {
      var list = GetRowsAsList(inputTextBox);

      var outputList = new List<string>();
      for(int i = 0; i < list.Count; i++) {
        if(i == list.Count - 1) {
          Console.WriteLine("Last item : " + list[i]);
          outputList.Add("'" + list[i] + "'");
        } else {
          outputList.Add("'" + list[i] + "', ");
        }
      }
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

      var outputList = new List<string>();
      string value = "";
      if(list.Count > 1) {
        for(int i = 1; i < list.Count + 1; i++) {
          if(i % 2 == 0) {
            value += list[i - 1];
            outputList.Add(value);
          } else { value = list[i - 1] + " "; }
        }
      } else if(list.Count == 1) {
        outputList.Add(list[0]);
      }
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
  }
}
