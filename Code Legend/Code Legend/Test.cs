using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Legend
{
    internal class Test
    {
        public void SetQuestions(int num, string[] question, Label label)
        {
            try
            {
                label.Text = question[num];
            }catch
            {

            }
        }

        public void SetAnswers(int num, string[] ans1, string[] ans2, string[] ans3, Label answer1, Label answer2, Label answer3)
        {
            try
            {
                answer1.Text = ans1[num];
                answer2.Text = ans2[num];
                answer3.Text = ans3[num];
            }
            catch
            {

            }

        }

        public void CheckAnswers(int num, CheckBox ch1, CheckBox ch2, CheckBox ch3, int score)
        {
            try
            {
                string correct = "correct";

                if (ch1.ClassId == correct && ch1.IsChecked == true)
                {
                    score++;
                }
                else if (ch1.ClassId != correct && ch1.IsChecked == true)
                {
                    score--;
                }
                else if (ch1.ClassId == correct && ch1.IsChecked == false)
                {
                    score--;
                }

                if (ch2.ClassId == correct && ch2.IsChecked == true)
                {
                    score++;
                }
                else if (ch2.ClassId != correct && ch2.IsChecked == true)
                {
                    score--;
                }
                else if (ch2.ClassId == correct && ch2.IsChecked == false)
                {
                    score--;
                }

                if (ch3.ClassId == correct && ch3.IsChecked == true)
                {
                    score++;
                }
                else if (ch3.ClassId != correct && ch3.IsChecked == true)
                {
                    score--;
                }
                else if (ch3.ClassId == correct && ch3.IsChecked == false)
                {
                    score--;
                }
            }
            catch
            {

            }

        }
    }
}
