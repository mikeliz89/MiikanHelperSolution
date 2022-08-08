﻿namespace MiikanHelperSolution {
  partial class MyForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.inputToOutputButton = new System.Windows.Forms.Button();
      this.inputTextBox = new System.Windows.Forms.TextBox();
      this.outputTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.outputRemoveDuplicatesButton = new System.Windows.Forms.Button();
      this.resultsTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.outputRowCountLabel = new System.Windows.Forms.Label();
      this.outputCombineEveryEachOtherRowButton = new System.Windows.Forms.Button();
      this.inputCountRowsButton = new System.Windows.Forms.Button();
      this.outputCountRowsButton = new System.Windows.Forms.Button();
      this.inputGetUserIDsButton = new System.Windows.Forms.Button();
      this.inputAddCommasButton = new System.Windows.Forms.Button();
      this.inputAddTextTextBox = new System.Windows.Forms.TextBox();
      this.inputAddTextButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.inputEndRadioButton = new System.Windows.Forms.RadioButton();
      this.inputStartRadioButton = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.inputSearchFromFilePath = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.inputFilePath = new System.Windows.Forms.TextBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.inputToLower = new System.Windows.Forms.Button();
      this.inputToUpper = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.inputSplitCsv = new System.Windows.Forms.TextBox();
      this.inputSplitCsvBtn = new System.Windows.Forms.Button();
      this.inputStartAndEndRadioButton = new System.Windows.Forms.RadioButton();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.SuspendLayout();
      // 
      // inputToOutputButton
      // 
      this.inputToOutputButton.Location = new System.Drawing.Point(7, 19);
      this.inputToOutputButton.Name = "inputToOutputButton";
      this.inputToOutputButton.Size = new System.Drawing.Size(154, 23);
      this.inputToOutputButton.TabIndex = 0;
      this.inputToOutputButton.Text = "Lisää heittomerkit ja pilkut";
      this.inputToOutputButton.UseVisualStyleBackColor = true;
      this.inputToOutputButton.Click += new System.EventHandler(this.inputToOutputButton_Click);
      // 
      // inputTextBox
      // 
      this.inputTextBox.Location = new System.Drawing.Point(68, 46);
      this.inputTextBox.MaxLength = 132767;
      this.inputTextBox.Multiline = true;
      this.inputTextBox.Name = "inputTextBox";
      this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.inputTextBox.Size = new System.Drawing.Size(856, 120);
      this.inputTextBox.TabIndex = 1;
      // 
      // outputTextBox
      // 
      this.outputTextBox.Location = new System.Drawing.Point(579, 330);
      this.outputTextBox.MaxLength = 132767;
      this.outputTextBox.Multiline = true;
      this.outputTextBox.Name = "outputTextBox";
      this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.outputTextBox.Size = new System.Drawing.Size(380, 200);
      this.outputTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(65, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Input lista";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(576, 308);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Output lista";
      // 
      // outputRemoveDuplicatesButton
      // 
      this.outputRemoveDuplicatesButton.Location = new System.Drawing.Point(6, 19);
      this.outputRemoveDuplicatesButton.Name = "outputRemoveDuplicatesButton";
      this.outputRemoveDuplicatesButton.Size = new System.Drawing.Size(108, 23);
      this.outputRemoveDuplicatesButton.TabIndex = 5;
      this.outputRemoveDuplicatesButton.Text = "Poista duplikaatit";
      this.outputRemoveDuplicatesButton.UseVisualStyleBackColor = true;
      this.outputRemoveDuplicatesButton.Click += new System.EventHandler(this.outputRemoveDuplicates_Click);
      // 
      // resultsTextBox
      // 
      this.resultsTextBox.Location = new System.Drawing.Point(1023, 328);
      this.resultsTextBox.Multiline = true;
      this.resultsTextBox.Name = "resultsTextBox";
      this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.resultsTextBox.Size = new System.Drawing.Size(393, 202);
      this.resultsTextBox.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(1020, 306);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Results";
      // 
      // outputRowCountLabel
      // 
      this.outputRowCountLabel.AutoSize = true;
      this.outputRowCountLabel.Location = new System.Drawing.Point(897, 309);
      this.outputRowCountLabel.Name = "outputRowCountLabel";
      this.outputRowCountLabel.Size = new System.Drawing.Size(62, 13);
      this.outputRowCountLabel.TabIndex = 8;
      this.outputRowCountLabel.Text = "placeholder";
      // 
      // outputCombineEveryEachOtherRowButton
      // 
      this.outputCombineEveryEachOtherRowButton.Location = new System.Drawing.Point(6, 48);
      this.outputCombineEveryEachOtherRowButton.Name = "outputCombineEveryEachOtherRowButton";
      this.outputCombineEveryEachOtherRowButton.Size = new System.Drawing.Size(129, 23);
      this.outputCombineEveryEachOtherRowButton.TabIndex = 9;
      this.outputCombineEveryEachOtherRowButton.Text = "Yhdistä joka toinen rivi";
      this.outputCombineEveryEachOtherRowButton.UseVisualStyleBackColor = true;
      this.outputCombineEveryEachOtherRowButton.Click += new System.EventHandler(this.outputCombineEveryEachRowButton_Click);
      // 
      // inputCountRowsButton
      // 
      this.inputCountRowsButton.Location = new System.Drawing.Point(831, 181);
      this.inputCountRowsButton.Name = "inputCountRowsButton";
      this.inputCountRowsButton.Size = new System.Drawing.Size(93, 23);
      this.inputCountRowsButton.TabIndex = 10;
      this.inputCountRowsButton.Text = "Laske rivit";
      this.inputCountRowsButton.UseVisualStyleBackColor = true;
      this.inputCountRowsButton.Click += new System.EventHandler(this.inputCountRowsButton_Click);
      // 
      // outputCountRowsButton
      // 
      this.outputCountRowsButton.Location = new System.Drawing.Point(281, 19);
      this.outputCountRowsButton.Name = "outputCountRowsButton";
      this.outputCountRowsButton.Size = new System.Drawing.Size(93, 23);
      this.outputCountRowsButton.TabIndex = 11;
      this.outputCountRowsButton.Text = "Laske rivit";
      this.outputCountRowsButton.UseVisualStyleBackColor = true;
      this.outputCountRowsButton.Click += new System.EventHandler(this.outputCountRowsButton_Click);
      // 
      // inputGetUserIDsButton
      // 
      this.inputGetUserIDsButton.Location = new System.Drawing.Point(7, 77);
      this.inputGetUserIDsButton.Name = "inputGetUserIDsButton";
      this.inputGetUserIDsButton.Size = new System.Drawing.Size(213, 23);
      this.inputGetUserIDsButton.TabIndex = 12;
      this.inputGetUserIDsButton.Text = "Hanki riveiltä : ja välilyönti väliset merkit";
      this.inputGetUserIDsButton.UseVisualStyleBackColor = true;
      this.inputGetUserIDsButton.Click += new System.EventHandler(this.inputGetUserIDsButton_Click);
      // 
      // inputAddCommasButton
      // 
      this.inputAddCommasButton.Location = new System.Drawing.Point(7, 48);
      this.inputAddCommasButton.Name = "inputAddCommasButton";
      this.inputAddCommasButton.Size = new System.Drawing.Size(99, 23);
      this.inputAddCommasButton.TabIndex = 13;
      this.inputAddCommasButton.Text = "Lisää pilkut";
      this.inputAddCommasButton.UseVisualStyleBackColor = true;
      this.inputAddCommasButton.Click += new System.EventHandler(this.inputAddCommasButton_Click);
      // 
      // inputAddTextTextBox
      // 
      this.inputAddTextTextBox.Location = new System.Drawing.Point(6, 19);
      this.inputAddTextTextBox.Name = "inputAddTextTextBox";
      this.inputAddTextTextBox.Size = new System.Drawing.Size(231, 20);
      this.inputAddTextTextBox.TabIndex = 14;
      // 
      // inputAddTextButton
      // 
      this.inputAddTextButton.Location = new System.Drawing.Point(6, 46);
      this.inputAddTextButton.Name = "inputAddTextButton";
      this.inputAddTextButton.Size = new System.Drawing.Size(118, 23);
      this.inputAddTextButton.TabIndex = 15;
      this.inputAddTextButton.Text = "Lisää annettu teksti";
      this.inputAddTextButton.UseVisualStyleBackColor = true;
      this.inputAddTextButton.Click += new System.EventHandler(this.inputAddTextButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.inputStartAndEndRadioButton);
      this.groupBox1.Controls.Add(this.inputEndRadioButton);
      this.groupBox1.Controls.Add(this.inputStartRadioButton);
      this.groupBox1.Controls.Add(this.inputAddTextTextBox);
      this.groupBox1.Controls.Add(this.inputAddTextButton);
      this.groupBox1.Location = new System.Drawing.Point(68, 293);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(431, 112);
      this.groupBox1.TabIndex = 16;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Lisää annettu teksti";
      // 
      // inputEndRadioButton
      // 
      this.inputEndRadioButton.AutoSize = true;
      this.inputEndRadioButton.Location = new System.Drawing.Point(98, 75);
      this.inputEndRadioButton.Name = "inputEndRadioButton";
      this.inputEndRadioButton.Size = new System.Drawing.Size(91, 17);
      this.inputEndRadioButton.TabIndex = 17;
      this.inputEndRadioButton.Text = "rivien loppuun";
      this.inputEndRadioButton.UseVisualStyleBackColor = true;
      this.inputEndRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
      // 
      // inputStartRadioButton
      // 
      this.inputStartRadioButton.AutoSize = true;
      this.inputStartRadioButton.Checked = true;
      this.inputStartRadioButton.Location = new System.Drawing.Point(7, 75);
      this.inputStartRadioButton.Name = "inputStartRadioButton";
      this.inputStartRadioButton.Size = new System.Drawing.Size(85, 17);
      this.inputStartRadioButton.TabIndex = 16;
      this.inputStartRadioButton.TabStop = true;
      this.inputStartRadioButton.Text = "rivien alkuun";
      this.inputStartRadioButton.UseVisualStyleBackColor = true;
      this.inputStartRadioButton.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.inputToOutputButton);
      this.groupBox2.Controls.Add(this.inputAddCommasButton);
      this.groupBox2.Controls.Add(this.inputGetUserIDsButton);
      this.groupBox2.Location = new System.Drawing.Point(68, 411);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(268, 106);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Lisää pilkkuja, heittomerkkejä";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.inputSearchFromFilePath);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.inputFilePath);
      this.groupBox3.Location = new System.Drawing.Point(68, 181);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(431, 106);
      this.groupBox3.TabIndex = 18;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Etsi tiedostosta";
      // 
      // inputSearchFromFilePath
      // 
      this.inputSearchFromFilePath.Location = new System.Drawing.Point(6, 64);
      this.inputSearchFromFilePath.Name = "inputSearchFromFilePath";
      this.inputSearchFromFilePath.Size = new System.Drawing.Size(73, 23);
      this.inputSearchFromFilePath.TabIndex = 18;
      this.inputSearchFromFilePath.Text = "Etsi";
      this.inputSearchFromFilePath.UseVisualStyleBackColor = true;
      this.inputSearchFromFilePath.Click += new System.EventHandler(this.inputSearchFromFilePath_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(4, 22);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(74, 13);
      this.label4.TabIndex = 19;
      this.label4.Text = "Tiedostopolku";
      // 
      // inputFilePath
      // 
      this.inputFilePath.Location = new System.Drawing.Point(6, 38);
      this.inputFilePath.Name = "inputFilePath";
      this.inputFilePath.Size = new System.Drawing.Size(395, 20);
      this.inputFilePath.TabIndex = 18;
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.inputToLower);
      this.groupBox4.Controls.Add(this.inputToUpper);
      this.groupBox4.Location = new System.Drawing.Point(68, 534);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(268, 60);
      this.groupBox4.TabIndex = 19;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Muuta tekstiä";
      // 
      // inputToLower
      // 
      this.inputToLower.Location = new System.Drawing.Point(85, 19);
      this.inputToLower.Name = "inputToLower";
      this.inputToLower.Size = new System.Drawing.Size(72, 25);
      this.inputToLower.TabIndex = 1;
      this.inputToLower.Text = "ToLower";
      this.inputToLower.UseVisualStyleBackColor = true;
      this.inputToLower.Click += new System.EventHandler(this.inputToLower_Click);
      // 
      // inputToUpper
      // 
      this.inputToUpper.Location = new System.Drawing.Point(7, 20);
      this.inputToUpper.Name = "inputToUpper";
      this.inputToUpper.Size = new System.Drawing.Size(72, 25);
      this.inputToUpper.TabIndex = 0;
      this.inputToUpper.Text = "ToUpper";
      this.inputToUpper.UseVisualStyleBackColor = true;
      this.inputToUpper.Click += new System.EventHandler(this.inputToUpper_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.label5);
      this.groupBox5.Controls.Add(this.inputSplitCsv);
      this.groupBox5.Controls.Add(this.inputSplitCsvBtn);
      this.groupBox5.Location = new System.Drawing.Point(68, 609);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(268, 106);
      this.groupBox5.TabIndex = 20;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Erottele pilkkulista";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(4, 24);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(65, 13);
      this.label5.TabIndex = 20;
      this.label5.Text = "Erotinmerkki";
      // 
      // inputSplitCsv
      // 
      this.inputSplitCsv.Location = new System.Drawing.Point(7, 40);
      this.inputSplitCsv.Name = "inputSplitCsv";
      this.inputSplitCsv.Size = new System.Drawing.Size(154, 20);
      this.inputSplitCsv.TabIndex = 18;
      // 
      // inputSplitCsvBtn
      // 
      this.inputSplitCsvBtn.Location = new System.Drawing.Point(6, 66);
      this.inputSplitCsvBtn.Name = "inputSplitCsvBtn";
      this.inputSplitCsvBtn.Size = new System.Drawing.Size(72, 25);
      this.inputSplitCsvBtn.TabIndex = 2;
      this.inputSplitCsvBtn.Text = "Erottele";
      this.inputSplitCsvBtn.UseVisualStyleBackColor = true;
      this.inputSplitCsvBtn.Click += new System.EventHandler(this.inputSplitCsvBtn_Click);
      // 
      // inputStartAndEndRadioButton
      // 
      this.inputStartAndEndRadioButton.AutoSize = true;
      this.inputStartAndEndRadioButton.Location = new System.Drawing.Point(195, 75);
      this.inputStartAndEndRadioButton.Name = "inputStartAndEndRadioButton";
      this.inputStartAndEndRadioButton.Size = new System.Drawing.Size(137, 17);
      this.inputStartAndEndRadioButton.TabIndex = 18;
      this.inputStartAndEndRadioButton.Text = "rivien alkuun ja loppuun";
      this.inputStartAndEndRadioButton.UseVisualStyleBackColor = true;
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.outputRemoveDuplicatesButton);
      this.groupBox6.Controls.Add(this.outputCombineEveryEachOtherRowButton);
      this.groupBox6.Controls.Add(this.outputCountRowsButton);
      this.groupBox6.Location = new System.Drawing.Point(579, 536);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(380, 80);
      this.groupBox6.TabIndex = 21;
      this.groupBox6.TabStop = false;
      // 
      // MyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1512, 761);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.inputCountRowsButton);
      this.Controls.Add(this.outputRowCountLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.resultsTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.outputTextBox);
      this.Controls.Add(this.inputTextBox);
      this.Name = "MyForm";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button inputToOutputButton;
    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.TextBox outputTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button outputRemoveDuplicatesButton;
    private System.Windows.Forms.TextBox resultsTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label outputRowCountLabel;
    private System.Windows.Forms.Button outputCombineEveryEachOtherRowButton;
    private System.Windows.Forms.Button inputCountRowsButton;
    private System.Windows.Forms.Button outputCountRowsButton;
    private System.Windows.Forms.Button inputGetUserIDsButton;
    private System.Windows.Forms.Button inputAddCommasButton;
    private System.Windows.Forms.TextBox inputAddTextTextBox;
    private System.Windows.Forms.Button inputAddTextButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton inputEndRadioButton;
    private System.Windows.Forms.RadioButton inputStartRadioButton;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button inputSearchFromFilePath;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox inputFilePath;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.Button inputToUpper;
    private System.Windows.Forms.Button inputToLower;
    private System.Windows.Forms.GroupBox groupBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox inputSplitCsv;
    private System.Windows.Forms.Button inputSplitCsvBtn;
    private System.Windows.Forms.RadioButton inputStartAndEndRadioButton;
    private System.Windows.Forms.GroupBox groupBox6;
  }
}

