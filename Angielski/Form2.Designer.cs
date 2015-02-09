namespace Angielski
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxAskedWord = new System.Windows.Forms.TextBox();
      this.textBoxAnswerWord = new System.Windows.Forms.TextBox();
      this.buttonShowAnswer = new System.Windows.Forms.Button();
      this.buttonLearned = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxTypedWord = new System.Windows.Forms.TextBox();
      this.buttonNext = new System.Windows.Forms.Button();
      this.labelMatchedLetterCount = new System.Windows.Forms.Label();
      this.buttonCheck = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.labelRepetitionNumber = new System.Windows.Forms.Label();
      this.labelLearnedQuestions = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxAskedWord
      // 
      this.textBoxAskedWord.Enabled = false;
      this.textBoxAskedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxAskedWord.Location = new System.Drawing.Point(15, 48);
      this.textBoxAskedWord.Multiline = true;
      this.textBoxAskedWord.Name = "textBoxAskedWord";
      this.textBoxAskedWord.Size = new System.Drawing.Size(249, 146);
      this.textBoxAskedWord.TabIndex = 0;
      // 
      // textBoxAnswerWord
      // 
      this.textBoxAnswerWord.Enabled = false;
      this.textBoxAnswerWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxAnswerWord.Location = new System.Drawing.Point(587, 48);
      this.textBoxAnswerWord.Multiline = true;
      this.textBoxAnswerWord.Name = "textBoxAnswerWord";
      this.textBoxAnswerWord.Size = new System.Drawing.Size(249, 96);
      this.textBoxAnswerWord.TabIndex = 1;
      // 
      // buttonShowAnswer
      // 
      this.buttonShowAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonShowAnswer.Location = new System.Drawing.Point(587, 150);
      this.buttonShowAnswer.Name = "buttonShowAnswer";
      this.buttonShowAnswer.Size = new System.Drawing.Size(249, 44);
      this.buttonShowAnswer.TabIndex = 2;
      this.buttonShowAnswer.Text = "Pokaż odpowiedź";
      this.buttonShowAnswer.UseVisualStyleBackColor = true;
      this.buttonShowAnswer.Click += new System.EventHandler(this.buttonShowAnswer_Click);
      // 
      // buttonLearned
      // 
      this.buttonLearned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonLearned.Location = new System.Drawing.Point(290, 458);
      this.buttonLearned.Name = "buttonLearned";
      this.buttonLearned.Size = new System.Drawing.Size(249, 44);
      this.buttonLearned.TabIndex = 3;
      this.buttonLearned.Text = "Umiem";
      this.buttonLearned.UseVisualStyleBackColor = true;
      this.buttonLearned.Click += new System.EventHandler(this.buttonLearned_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label2.Location = new System.Drawing.Point(287, 244);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 18);
      this.label2.TabIndex = 5;
      this.label2.Text = "Wprowadź tekst:";
      // 
      // textBoxTypedWord
      // 
      this.textBoxTypedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxTypedWord.Location = new System.Drawing.Point(290, 265);
      this.textBoxTypedWord.Multiline = true;
      this.textBoxTypedWord.Name = "textBoxTypedWord";
      this.textBoxTypedWord.Size = new System.Drawing.Size(249, 96);
      this.textBoxTypedWord.TabIndex = 6;
      // 
      // buttonNext
      // 
      this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonNext.Location = new System.Drawing.Point(587, 458);
      this.buttonNext.Name = "buttonNext";
      this.buttonNext.Size = new System.Drawing.Size(249, 44);
      this.buttonNext.TabIndex = 7;
      this.buttonNext.Text = "Następne";
      this.buttonNext.UseVisualStyleBackColor = true;
      this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
      // 
      // labelMatchedLetterCount
      // 
      this.labelMatchedLetterCount.AutoSize = true;
      this.labelMatchedLetterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelMatchedLetterCount.Location = new System.Drawing.Point(100, 336);
      this.labelMatchedLetterCount.Name = "labelMatchedLetterCount";
      this.labelMatchedLetterCount.Size = new System.Drawing.Size(54, 25);
      this.labelMatchedLetterCount.TabIndex = 8;
      this.labelMatchedLetterCount.Text = "3/14";
      // 
      // buttonCheck
      // 
      this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.buttonCheck.Location = new System.Drawing.Point(290, 367);
      this.buttonCheck.Name = "buttonCheck";
      this.buttonCheck.Size = new System.Drawing.Size(249, 44);
      this.buttonCheck.TabIndex = 9;
      this.buttonCheck.Text = "Sprawdź";
      this.buttonCheck.UseVisualStyleBackColor = true;
      this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(15, 535);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(821, 44);
      this.progressBar1.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(629, 380);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(176, 18);
      this.label1.TabIndex = 11;
      this.label1.Text = "Liczba powtórzeń słówka";
      // 
      // labelRepetitionNumber
      // 
      this.labelRepetitionNumber.AutoSize = true;
      this.labelRepetitionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelRepetitionNumber.Location = new System.Drawing.Point(700, 336);
      this.labelRepetitionNumber.Name = "labelRepetitionNumber";
      this.labelRepetitionNumber.Size = new System.Drawing.Size(24, 25);
      this.labelRepetitionNumber.TabIndex = 12;
      this.labelRepetitionNumber.Text = "3";
      // 
      // labelLearnedQuestions
      // 
      this.labelLearnedQuestions.AutoSize = true;
      this.labelLearnedQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.labelLearnedQuestions.Location = new System.Drawing.Point(193, 514);
      this.labelLearnedQuestions.Name = "labelLearnedQuestions";
      this.labelLearnedQuestions.Size = new System.Drawing.Size(36, 18);
      this.labelLearnedQuestions.TabIndex = 14;
      this.labelLearnedQuestions.Text = "0/10";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label5.Location = new System.Drawing.Point(45, 514);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(142, 18);
      this.label5.TabIndex = 13;
      this.label5.Text = "Opanowane pytania:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label6.Location = new System.Drawing.Point(45, 380);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(162, 18);
      this.label6.TabIndex = 15;
      this.label6.Text = "Liczba poprawnych liter";
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(848, 591);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.labelLearnedQuestions);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.labelRepetitionNumber);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.buttonCheck);
      this.Controls.Add(this.labelMatchedLetterCount);
      this.Controls.Add(this.buttonNext);
      this.Controls.Add(this.textBoxTypedWord);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.buttonLearned);
      this.Controls.Add(this.buttonShowAnswer);
      this.Controls.Add(this.textBoxAnswerWord);
      this.Controls.Add(this.textBoxAskedWord);
      this.Name = "Form2";
      this.Text = "Test";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxAskedWord;
    private System.Windows.Forms.TextBox textBoxAnswerWord;
    private System.Windows.Forms.Button buttonShowAnswer;
    private System.Windows.Forms.Button buttonLearned;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxTypedWord;
    private System.Windows.Forms.Button buttonNext;
    private System.Windows.Forms.Label labelMatchedLetterCount;
    private System.Windows.Forms.Button buttonCheck;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelRepetitionNumber;
    private System.Windows.Forms.Label labelLearnedQuestions;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}