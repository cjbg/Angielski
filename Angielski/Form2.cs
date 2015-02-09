using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Angielski.Properties;

namespace Angielski
{
  public partial class Form2 : Form
  {
    private Dictionary<string, Word> _words;
    private Random _random;

    private string _currentAskedWord;
    private string _currentAnswerWord;
    private int _currentRepetitionNumber;
    private int _answeredQuestions;

    public Form2(Dictionary<string, Word> wordsDictionary, int repetitionNumber)
    {
      InitializeComponent();
      _words = wordsDictionary;
      progressBar1.Minimum = 0;
      progressBar1.Maximum = _words.Count;
      _random = new Random();
      _currentRepetitionNumber = repetitionNumber;

      SelectWord();
      AssignWord();
    }    

    private void AssignWord()
    {
      textBoxAskedWord.Text = _currentAskedWord;      
      labelRepetitionNumber.Text = _currentRepetitionNumber.ToString();
      labelMatchedLetterCount.Text = @"0/" + _currentAnswerWord.Count();
      labelLearnedQuestions.Text = _answeredQuestions.ToString();
    }

    private void SelectWord()
    {
      int randomWordNumber;

      do
      {
        randomWordNumber = _random.Next(0, _words.Count);
      }
      while (_words.Values.ElementAt(randomWordNumber).RepetitionNumber == 0);
      
      _currentAskedWord = _words.Keys.ElementAt(randomWordNumber);
      _currentAnswerWord = _words[_currentAskedWord].WordName;
      _currentRepetitionNumber = _words[_currentAskedWord].RepetitionNumber;
    }

    private void buttonShowAnswer_Click(object sender, EventArgs e)
    {
      textBoxAnswerWord.Text = _currentAnswerWord;
    }

    private void Form2_Load(object sender, EventArgs e)
    {

    }

    private void buttonLearned_Click(object sender, EventArgs e)
    {
      _words[_currentAskedWord].RepetitionNumber--;

      if (_words[_currentAskedWord].RepetitionNumber == 0)
      {
        _answeredQuestions++;
        progressBar1.Value++;
        _words.Remove(_currentAskedWord);
      }

      LoadWord();
    }

    private void LoadWord()
    {
      if (_words.Count == 0)
      {
        MessageBox.Show("Brawo myszko :), wszystkie pytania masz już w małym palcu ;*");
        Close();
      }
      else
      {
        textBoxAnswerWord.Text = string.Empty;
        textBoxTypedWord.Text = string.Empty;
        SelectWord();
        AssignWord();
      }      
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
      LoadWord();
    }

    private void buttonCheck_Click(object sender, EventArgs e)
    {
      if (textBoxTypedWord.Text.Count() > _currentAnswerWord.Count())
      {
        labelMatchedLetterCount.Text = Resources.Form2_buttonCheck_Click_Za_dużo_liter;
      }
      else
      {
        int matchLetterNumber = CompareWords(textBoxTypedWord.Text.Trim().ToLower(), _currentAnswerWord.ToLower());
        labelMatchedLetterCount.Text = matchLetterNumber + @"/" + _currentAnswerWord.Count();
      }
    }

    private int CompareWords(string typedWord, string answerWord)
    {
      char[] typedLetters = typedWord.ToCharArray();
      char[] answerLetters = answerWord.ToCharArray();

      int matchedLetterCount = 0;

      for (int i = 0; i < answerLetters.Count(); i++)
      {
        if (i == typedLetters.Count())
        {
          break;
        }

        if (answerLetters[i] == typedLetters[i])
        {
          matchedLetterCount++;
        }
      }

      return matchedLetterCount;
    }
  }
}
