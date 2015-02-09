using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Angielski.Properties;

namespace Angielski
{
  public partial class Form1 : Form
  {
    private int _repetitionNumber = 2;
    private Dictionary<string, Word> _wordsAngPol;
    private Dictionary<string, Word> _wordsPolAng;

    public Form1()
    {
      InitializeComponent();
      ReadTxtFile(Resources.unit7);
    }

    private void ReadTxtFile(string resource)
    {
      string resourceData = resource;
      List<string> words =
        resourceData
        .Split(new[] { Environment.NewLine, "-" }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();

      _wordsAngPol = new Dictionary<string, Word>();
      _wordsPolAng = new Dictionary<string, Word>();

      for (int i = 0; i < words.Count - 1; i += 2)
      {
        _wordsAngPol.Add(words[i].Trim(),
          new Word { WordName = words[i + 1].Trim(), RepetitionNumber = _repetitionNumber });
        _wordsPolAng.Add(words[i + 1].Trim(),
          new Word { WordName = words[i].Trim(), RepetitionNumber = _repetitionNumber});
      }     
    }

    

    private void button1_Click(object sender, EventArgs e)
    {
      Form2 form = new Form2(_wordsAngPol, _repetitionNumber);
      form.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Form2 form = new Form2(_wordsPolAng, _repetitionNumber);
      form.ShowDialog();
    }

    private void buttonUnit7_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit7);
      labelUnit.Text = "unit 7";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit8);
      labelUnit.Text = "unit 8";
    }

    private void button4_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit9);
      labelUnit.Text = "unit 9";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit10);
      labelUnit.Text = "unit 10";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit11);
      labelUnit.Text = "unit 11";
    }

    private void textBox1_Leave(object sender, EventArgs e)
    {
      try
      {
        _repetitionNumber = Convert.ToInt32(textBox1.Text);
        foreach (KeyValuePair<string, Word> word in _wordsAngPol)
        {
          word.Value.RepetitionNumber = _repetitionNumber;
        }

        foreach (KeyValuePair<string, Word> word in _wordsPolAng)
        {
          word.Value.RepetitionNumber = _repetitionNumber;
        }
      }
      catch (Exception)
      {
        MessageBox.Show(Resources.Form1_textBox1_TextChanged_Zła_wartość);
      }
    }

    private void buttonUnit1_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit1);
      labelUnit.Text = "unit 1";
    }

    private void buttonUnit2_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit2);
      labelUnit.Text = "unit 2";
    }

    private void buttonUnit3_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit3);
      labelUnit.Text = "unit 3";
    }

    private void buttonUnit4_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit4);
      labelUnit.Text = "unit 4";

    }

    private void buttonUnit5_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit5);
      labelUnit.Text = "unit 5";
    }

    private void buttonUnit6_Click(object sender, EventArgs e)
    {
      ReadTxtFile(Resources.unit6);
      labelUnit.Text = "unit 6";
    }

    private void buttonUnit12_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Już jest kotku ;*");
      ReadTxtFile(Resources.unit12);
      labelUnit.Text = "unit 12";
    }
  }
}
