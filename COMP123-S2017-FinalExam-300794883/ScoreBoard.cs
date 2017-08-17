using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300794883
{
    /*
 * Name: Zilang Liang
 * Date: August 17, 2017
 * Description: This is the ScoreBoard class
 * Version: 0.2 - ScoreBoard Class
 */
    public class ScoreBoard
    {
        //Private instance variables
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._score;
            }
            set
            {
                double c = Convert.ToInt32(_score);
                c = value;
            }
        }
        public int Score
        {
            get
            {
                double b = Convert.ToInt32(ScoreTextBox.Text);
                return b;
            }
            set
            {
                double a = Convert.ToInt32(ScoreTextBox.Text);
                a = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                double a = Convert.ToInt32(TimeTextBox.Text);
                a = this._time;
            }
        }
        public TextBox TimeTextBox { get; set; }
        public TextBox ScoreTextBox { get; set; }

        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextbox)
        {
            ScoreTextBox = scoreTextBox;
            TimeTextBox = timeTextBox;
            FinalScoreTextBox = finalScoreTextbox;
        }
        public static void UpdateTime()
        {
            double a = Convert.ToInt32(TimeTextBox.Text);
            a -= 1;
        }

    }
}