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
      this.SuspendLayout();
      // 
      // inputToOutputButton
      // 
      this.inputToOutputButton.Location = new System.Drawing.Point(195, 181);
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
      this.inputTextBox.Multiline = true;
      this.inputTextBox.Name = "inputTextBox";
      this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.inputTextBox.Size = new System.Drawing.Size(380, 120);
      this.inputTextBox.TabIndex = 1;
      // 
      // outputTextBox
      // 
      this.outputTextBox.Location = new System.Drawing.Point(555, 46);
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
      this.label2.Location = new System.Drawing.Point(552, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Output lista";
      // 
      // outputRemoveDuplicatesButton
      // 
      this.outputRemoveDuplicatesButton.Location = new System.Drawing.Point(555, 181);
      this.outputRemoveDuplicatesButton.Name = "outputRemoveDuplicatesButton";
      this.outputRemoveDuplicatesButton.Size = new System.Drawing.Size(108, 23);
      this.outputRemoveDuplicatesButton.TabIndex = 5;
      this.outputRemoveDuplicatesButton.Text = "Poista duplikaatit";
      this.outputRemoveDuplicatesButton.UseVisualStyleBackColor = true;
      this.outputRemoveDuplicatesButton.Click += new System.EventHandler(this.outputRemoveDuplicates_Click);
      // 
      // resultsTextBox
      // 
      this.resultsTextBox.Location = new System.Drawing.Point(1024, 46);
      this.resultsTextBox.Multiline = true;
      this.resultsTextBox.Name = "resultsTextBox";
      this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.resultsTextBox.Size = new System.Drawing.Size(380, 120);
      this.resultsTextBox.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(1021, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Results";
      // 
      // outputRowCountLabel
      // 
      this.outputRowCountLabel.AutoSize = true;
      this.outputRowCountLabel.Location = new System.Drawing.Point(900, 24);
      this.outputRowCountLabel.Name = "outputRowCountLabel";
      this.outputRowCountLabel.Size = new System.Drawing.Size(0, 13);
      this.outputRowCountLabel.TabIndex = 8;
      // 
      // outputCombineEveryEachOtherRowButton
      // 
      this.outputCombineEveryEachOtherRowButton.Location = new System.Drawing.Point(669, 181);
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
      this.outputCountRowsButton.Location = new System.Drawing.Point(804, 181);
      this.outputCountRowsButton.Name = "outputCountRowsButton";
      this.outputCountRowsButton.Size = new System.Drawing.Size(93, 23);
      this.outputCountRowsButton.TabIndex = 11;
      this.outputCountRowsButton.Text = "Laske rivit";
      this.outputCountRowsButton.UseVisualStyleBackColor = true;
      this.outputCountRowsButton.Click += new System.EventHandler(this.outputCountRowsButton_Click);
      // 
      // MyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1512, 761);
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
      this.Controls.Add(this.inputToOutputButton);
      this.Name = "MyForm";
      this.Text = "Form1";
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
  }
}

