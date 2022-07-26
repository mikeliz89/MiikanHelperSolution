namespace MiikanHelperSolution {
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
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
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
      this.outputTextBox.Size = new System.Drawing.Size(380, 120);
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
      this.outputRemoveDuplicatesButton.Location = new System.Drawing.Point(579, 465);
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
      this.resultsTextBox.Size = new System.Drawing.Size(380, 120);
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
      this.outputRowCountLabel.Location = new System.Drawing.Point(924, 308);
      this.outputRowCountLabel.Name = "outputRowCountLabel";
      this.outputRowCountLabel.Size = new System.Drawing.Size(0, 13);
      this.outputRowCountLabel.TabIndex = 8;
      // 
      // outputCombineEveryEachOtherRowButton
      // 
      this.outputCombineEveryEachOtherRowButton.Location = new System.Drawing.Point(579, 494);
      this.outputCombineEveryEachOtherRowButton.Name = "outputCombineEveryEachOtherRowButton";
      this.outputCombineEveryEachOtherRowButton.Size = new System.Drawing.Size(129, 23);
      this.outputCombineEveryEachOtherRowButton.TabIndex = 9;
      this.outputCombineEveryEachOtherRowButton.Text = "Yhdistä joka toinen rivi";
      this.outputCombineEveryEachOtherRowButton.UseVisualStyleBackColor = true;
      this.outputCombineEveryEachOtherRowButton.Click += new System.EventHandler(this.outputCombineEveryEachRowButton_Click);
      // 
      // inputCountRowsButton
      // 
      this.inputCountRowsButton.Location = new System.Drawing.Point(355, 181);
      this.inputCountRowsButton.Name = "inputCountRowsButton";
      this.inputCountRowsButton.Size = new System.Drawing.Size(93, 23);
      this.inputCountRowsButton.TabIndex = 10;
      this.inputCountRowsButton.Text = "Laske rivit";
      this.inputCountRowsButton.UseVisualStyleBackColor = true;
      this.inputCountRowsButton.Click += new System.EventHandler(this.inputCountRowsButton_Click);
      // 
      // outputCountRowsButton
      // 
      this.outputCountRowsButton.Location = new System.Drawing.Point(866, 465);
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
      this.inputGetUserIDsButton.Size = new System.Drawing.Size(125, 23);
      this.inputGetUserIDsButton.TabIndex = 12;
      this.inputGetUserIDsButton.Text = "Hanki riveiltä userID";
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
      this.inputAddTextButton.Location = new System.Drawing.Point(7, 45);
      this.inputAddTextButton.Name = "inputAddTextButton";
      this.inputAddTextButton.Size = new System.Drawing.Size(118, 23);
      this.inputAddTextButton.TabIndex = 15;
      this.inputAddTextButton.Text = "Lisää annettu teksti";
      this.inputAddTextButton.UseVisualStyleBackColor = true;
      this.inputAddTextButton.Click += new System.EventHandler(this.inputAddTextButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.inputEndRadioButton);
      this.groupBox1.Controls.Add(this.inputStartRadioButton);
      this.groupBox1.Controls.Add(this.inputAddTextTextBox);
      this.groupBox1.Controls.Add(this.inputAddTextButton);
      this.groupBox1.Location = new System.Drawing.Point(68, 181);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(268, 106);
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
      this.groupBox2.Location = new System.Drawing.Point(68, 309);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(268, 111);
      this.groupBox2.TabIndex = 17;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Lisää pilkkuja, heittomerkkejä";
      // 
      // MyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1512, 761);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.outputCountRowsButton);
      this.Controls.Add(this.inputCountRowsButton);
      this.Controls.Add(this.outputCombineEveryEachOtherRowButton);
      this.Controls.Add(this.outputRowCountLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.resultsTextBox);
      this.Controls.Add(this.outputRemoveDuplicatesButton);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.outputTextBox);
      this.Controls.Add(this.inputTextBox);
      this.Name = "MyForm";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
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
  }
}

