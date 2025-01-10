using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiikanHelperSolution {
  public partial class MyForm : Form {

    private RadioButton selectedRadioButton;

    public MyForm() {
      InitializeComponent();
      inputRowCountLabel.Text = "";
      outputRowCountLabel.Text = "";
      resultsRowCountLabel.Text = "";
      selectedRadioButton = inputStartRadioButton;
    }

    /// <summary>
    /// Lisää pilkut ja heittomerkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToOutputButton_Click(object sender, EventArgs e) {

      var input = ListHelper.GetRowsAsList(inputTextBox.Text);
      var output = ListHelper.GetOutputList(input, charactersToAdd: "'");

      ShowOutput(output);

      ShowResult($"Muutettu {input.Count} riviä");
    }

    /// <summary>
    /// Lisää pilkut
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddCommasButton_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.GetOutputList(input, charactersToAdd: "", addToStart: true, addToEnd: true, addCommas: true);

      ShowOutput(output);

      ShowResult($"Muutettu {input.Count} riviä");
    }

    private List<string> GetRowsAsList(TextBox textBox) {
      return ListHelper.GetRowsAsList(textBox.Text);
    }

    /// <summary>
    /// Poista outputlistalta duplikaatit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputRemoveDuplicates_Click(object sender, EventArgs e) {

      var output = GetOutput();
      ShowDuplicatesInResults(output);

      var outputList = ListHelper.RemoveDuplicates(output);
      ShowOutput(outputList);
    }

    private void ShowDuplicatesInResults(List<string> list) {

      ShowResult("");

      //results
      var q = from x in list
              group x by x into g
              let count = g.Count()
              orderby count descending
              select new { Value = g.Key, Count = count };

      var counter = 0;
      foreach(var x in q) {
        if(x.Count > 1) {
          counter++;
          AppendToResult($" Value {x.Value} Count: {x.Count}" + Environment.NewLine);
        }
      }
      if(counter == 0) {
        ShowResult("No duplicates found");
      }
    }

    /// <summary>
    /// Yhdistä outputin joka toinen rivi
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputCombineEveryEachRowButton_Click(object sender, EventArgs e) {
      var output = GetOutput();
      var outputList = ListHelper.CombineEveryEachRow(output);
      ShowOutput(outputList);
    }

    /// <summary>
    /// Laske input-listan rivit ja näytä resultsissa
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputCountRowsButton_Click(object sender, EventArgs e) {
      var input = GetInput();
      inputRowCountLabel.Text = input.Count + "";
      ShowResult($"Input list count {input.Count}");
    }

    /// <summary>
    /// Laske output-listan rivit ja näytä resultsissa
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputCountRowsButton_Click(object sender, EventArgs e) {
      var output = GetOutput();
      outputRowCountLabel.Text = output.Count + "";
      ShowResult($"Output list count {output.Count}");
    }

    /// <summary>
    /// Hanki riveiltä : ja välilyönti väliset merkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputGetUserIDsButton_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.GetListOfSubstrings(input);

      ShowOutput(output);
    }


    /// <summary>
    /// Lisää tekstiä
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddTextButton_Click(object sender, EventArgs e) {

      var input = GetInput();

      if(inputWrapTextRadioButton.Checked) {
        var outputList = ListHelper.ReplaceListItemTextWithGivenText(input, inputAddTextTextBox.Text);
        ShowOutput(outputList);
      } else {
        var output = ListHelper.GetOutputList(input,
          charactersToAdd: inputAddTextTextBox.Text,
          addToStart: GetAddToStart(),
          addToEnd: GetAddToEnd(),
          addCommas: false);

        ShowOutput(output);
      }

      ShowResult($"Muutettu {input.Count} riviä");
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

      ShowResult("");

      var filePath = inputFilePath.Text;

      //guards
      if(IsFilePathNull(filePath)) {
        return;
      }
      if(!IsFileExisting(filePath)) {
        return;
      }

      var filesLines = File.ReadAllLines(filePath);

      AppendToResult($"Found {filesLines.Length} lines from file");

      var input = GetInput();
      var output = ListHelper.GetListContainingOtherList(input, filesLines.ToList());

      ShowOutput(output);

      //results
      var list2 = GetOutput();
      AppendToResult($"{Environment.NewLine}Output list count {list2.Count}");
    }

    private bool IsFilePathNull(string filePath) {
      if(string.IsNullOrEmpty(filePath)) {
        ShowResult("FilePath cannot be null or empty");
        return true;
      }
      return false;
    }

    private bool IsFileExisting(string filePath) {
      if(!File.Exists(filePath)) {
        ShowResult($"File {filePath} does not exist");
        return false;
      }
      return true;
    }

    /// <summary>
    /// ToUpper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToUpper_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.ListToUpper(input);

      ShowOutput(output);
    }

    /// <summary>
    /// ToLower
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputToLower_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.ListToLower(input);

      ShowOutput(output);
    }

    /// <summary>
    /// Splittaa lista erotinmerkin avulla
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputSplitCsvBtn_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.Split(input, inputSplitCsv.Text);

      ShowOutput(output);
    }

    private void ShowOutput(List<string> list) {
      ShowAs(outputTextBox, outputRowCountLabel, list);
    }

    private void ShowInput(List<string> list) {
      ShowAs(inputTextBox, inputRowCountLabel, list);
    }

    private void ShowResult(List<string> list) {
      ShowAs(resultsTextBox, resultsRowCountLabel, list);
    }

    private void ShowResult(string text) {
      resultsTextBox.Text = text;
    }

    private void AppendToResult(string text) {
      resultsTextBox.Text += text;
    }

    private void ShowAs(TextBox textBox, Label countLabel, List<string> list) {
      textBox.Text = string.Join(Environment.NewLine, list);
      countLabel.Text = list.Count + "";
    }

    /// <summary>
    /// Lisää heittomerkit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputAddSingleQuotes_Click(object sender, EventArgs e) {

      var input = GetInput();
      var output = ListHelper.GetOutputList(input, charactersToAdd: "'", addToStart: true, addToEnd: true, addCommas: false);

      ShowOutput(output);

      ShowResult($"Muutettu {input.Count} riviä");
    }

    /// <summary>
    /// Näytä output duplikaatit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void outputShowDuplicates_Click(object sender, EventArgs e) {
      var list = GetOutput();
      ShowDuplicatesInResults(list);
    }

    private void inputShowDuplicates_Click(object sender, EventArgs e) {
      var input = GetInput();
      ShowDuplicatesInResults(input);
    }

    private void inputRemoveDuplicates_Click(object sender, EventArgs e) {

      var input = GetInput();
      ShowDuplicatesInResults(input);

      var output = ListHelper.RemoveDuplicates(input);
      ShowOutput(output);
    }

    /// <summary>
    /// Vertaa input- ja output listoja keskenään. Eroavaisuudet resulttiin
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void compareBtn_Click(object sender, EventArgs e) {

      var input = GetInput();
      var list2 = GetOutput();

      ShowResult("Ladataan");

      var outputList = ListHelper.CompareTwoLists(input, list2);

      ShowResult(outputList);
    }

    /// <summary>
    /// Etsi sellaisia input -tekstejä tiedostosta joita ei löydy
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inputSearchFromFilePathNotContainsBtn_Click(object sender, EventArgs e) {
      ShowResult("");

      var filePath = inputFilePath.Text;

      //guards
      if(IsFilePathNull(filePath)) {
        return;
      }
      if(!IsFileExisting(filePath)) {
        return;
      }

      var filesLines = File.ReadAllLines(filePath);

      AppendToResult($"Found {filesLines.Length} lines from file");

      var list = GetInput();

      var outputList = ListHelper.GetListNotContainingOtherList(list, filesLines.ToList());

      ShowOutput(outputList);

      //results
      var list2 = GetOutput();
      AppendToResult($"{Environment.NewLine}Output list count {list2.Count}");
    }

    /// <summary>
    /// Etsi input-listan asioita output-listalta ja näytä results-listalla sellaiset mitkä löytyivät listalta 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnFindList1ItemsInList2_Click(object sender, EventArgs e) {
      resultsTextBox.Text = "";

      var input = GetInput();
      var output = GetOutput();

      var outputList = ListHelper.GetListContainingOtherList(input, output);

      ShowResult(outputList);
    }

    /// <summary>
    /// Etsi input-listan asioita ouput-listalta ja näytä results-listalla sellaiset mitä ei löytynyt listalta 2
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnFindList1ItemsNotInList2_Click(object sender, EventArgs e) {
      resultsTextBox.Text = "";

      var input = GetInput();
      var output = GetOutput();

      var outputList = ListHelper.GetListNotContainingOtherList(input, output);

      ShowResult(outputList);
    }

    /// <summary>
    /// Flippaa input- ja output-listat keskenään
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void flipInputWithOutputBtn_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = GetOutput();

      ShowOutput(input);
      ShowInput(output);
    }

    /// <summary>
    /// Korvaa teksti toisella
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button2_Click(object sender, EventArgs e) {
      var input = GetInput();

      var text1 = textBoxFrom.Text;
      var text2 = textBoxTo.Text;

      var output = ListHelper.ReplaceListText(input, text1, text2);

      ShowOutput(output);
    }

    /// <summary>
    /// Poista annettu teksti
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button1_Click(object sender, EventArgs e) {
      var input = GetInput();

      var text = textBoxRemoveText.Text;

      var output = ListHelper.RemoveListText(input, text);

      ShowOutput(output);
    }

    private void inputCombineEveryEachOtherRowButton_Click(object sender, EventArgs e) {
      var input = GetInput();
      var inputList = ListHelper.CombineEveryEachRow(input);
      ShowInput(inputList);
    }

    private void inputTrimEndsButton_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.TrimEnds(input);
      ShowOutput(output);
    }

    private void buttonXmlToRows_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.XmlToRows(input);
      ShowOutput(output);
    }

    //poista x-merkkiä alusta
    private void button4_Click(object sender, EventArgs e) {
      var input = GetInput();
      var number = Convert.ToInt32(inputRemoveCharactersTextBox.Text);

      var output = ListHelper.RemoveCharactersFromTheStart(input, number);
      ShowOutput(output);
    }

    private List<string> GetInput() {
      return GetRowsAsList(inputTextBox);
    }

    private List<string> GetOutput() {
      return GetRowsAsList(outputTextBox);
    }

    private void buttonCountCharacters_Click(object sender, EventArgs e) {
      var input = inputCountCharacters.Text;
      var count = input.Length;
      ShowResult($"Contains {count} characters");
    }

    private void groupBox15_Enter(object sender, EventArgs e) {

    }

    private void buttonSplitRows_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.SplitGetStarts(input, inputSplitCsv.Text);
      ShowOutput(output);
    }

    private void button5_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.SplitGetEnds(input, inputSplitCsv.Text);
      ShowOutput(output);
    }

    private void buttonCountFoundText_Click(object sender, EventArgs e) {
      var input = GetInput();
      var textToFind = inputTextBoxCountFoundText.Text;
      string output = "";
      if(radioButton1.Checked) {
        output = ListHelper.CountFoundText_Contains(input, textToFind);
      } else if(radioButton2.Checked) {
        output = ListHelper.CountFoundText_Exact(input, textToFind);
      }
      ShowResult(output);
    }

    private void groupBox16_Enter(object sender, EventArgs e) {

    }

    private void buttonGetLastWord_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.GetLastWord(input);
      ShowOutput(output);
    }

    /// <summary>
    /// Hanki riveiltä x ja y väliset merkit (case sensitive)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button6_Click(object sender, EventArgs e) {
      var input = GetInput();

      var start = textBoxSubstringStart.Text;
      var end = textBoxSubstringEnd.Text;
      var output = ListHelper.GetListOfSubstringsByString(input, start, end, true);

      ShowOutput(output);
    }

    /// <summary>
    /// Hanki riveiltä x ja y väliset merkit (case insensitive)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button7_Click(object sender, EventArgs e) {
      var input = GetInput();

      var start = textBoxSubstringStart.Text;
      var end = textBoxSubstringEnd.Text;
      var output = ListHelper.GetListOfSubstringsByString(input, start, end, false);

      ShowOutput(output);
    }

    private void button8_Click(object sender, EventArgs e) {
      var input = GetInput();

      var start = textBoxSubstringStart.Text;
      var end = textBoxSubstringEnd.Text;
      var output = ListHelper.GetListOfSubstringsByStringFullWordsOnly(input, start, end);

      ShowOutput(output);
    }

    private void buttonCompareTwoFiles_Click(object sender, EventArgs e) {

      var filePathFirst = textBoxCompareTwoFilesFirst.Text.Trim('"');
      if(IsFilePathNull(filePathFirst)) {
        return;
      }
      var filePathSecond = textBoxCompareTwoFilesSecond.Text.Trim('"');
      if(IsFilePathNull(filePathSecond)) {
        return;
      }

      if(!IsFileExisting(filePathFirst)) {
        return;
      }

      if(!IsFileExisting(filePathSecond)) {
        return;
      }

      var fileLinesFirst = File.ReadAllLines(filePathFirst, Encoding.GetEncoding("windows-1254"));
      var fileLinesSecond = File.ReadAllLines(filePathSecond, Encoding.GetEncoding("windows-1254"));

      var stringMissingInSecondList = ListHelper.GetDifferencesBetweenTwoLists(fileLinesFirst, fileLinesSecond);

      ShowResult(stringMissingInSecondList);
    }

    private void buttonCompareTwoFilesFlipFileNames_Click(object sender, EventArgs e) {
      var filePathFirst = textBoxCompareTwoFilesFirst.Text;
      var filePathSecond = textBoxCompareTwoFilesSecond.Text;

      textBoxCompareTwoFilesSecond.Text = filePathFirst;
      textBoxCompareTwoFilesFirst.Text = filePathSecond;
    }

    private void buttonOrderByText_Click(object sender, EventArgs e) {
      var input = GetInput();
      var output = ListHelper.OrderByText(input);
      ShowOutput(output);
    }

    private void groupBox18_Enter(object sender, EventArgs e) {

    }

    private void groupBox2_Enter(object sender, EventArgs e) {

    }

    private void buttonCalculateStringLength_Click(object sender, EventArgs e) {

      var input = GetInput();

      var output = ListHelper.CalculateStringLength(input);

      var outputList = new List<string>();
      outputList.Add(output.ToString());
      ShowOutput(outputList);
    }

    private void button9_Click(object sender, EventArgs e) {

      var input = GetInput();

      var output = ListHelper.RemoveEmpties(input);
      ShowOutput(output);
    }
  }
}
