using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
using sayHello;

namespace sayHello
{
    public partial class Options : Form
    {

        private SpVoice vox = new SpVoice();
        private int RateOfSpeech = 0;
        private SpVoice speechInterface = new SpVoice();
        private Dictionary<string, string> availableVoices = new Dictionary<string, string>();

        public Options()
        {
            InitializeComponent();

            this.textBox_NotificationContent.Text = Properties.Settings.Default.spokenText;
            this.numericUpDown_SpeechRate.Value = Properties.Settings.Default.speechRate;
            RateOfSpeech = Properties.Settings.Default.speechRate;

            foreach (ISpeechObjectToken voice in speechInterface.GetVoices("", ""))
            {
                availableVoices.Add(voice.GetDescription(0), voice.Id);
                this.comboBox_Voices.Items.Add(voice.GetDescription(0));
                this.comboBox_Voices.SelectedIndex = 0;
            }

            if (Properties.Settings.Default.voice != string.Empty && availableVoices.Count > 0)
            {
                string bla = availableVoices[Properties.Settings.Default.voice];
                vox.Voice = vox.GetVoices("","").Item(this.comboBox_Voices.SelectedIndex);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = Properties.Settings.Default.spokenText;
            text = text.Replace("$title", "Placeholder for the title");
            text = text.Replace("$text", "Placeholder for the text");
            vox.Rate = RateOfSpeech;
            vox.WaitUntilDone(1);
            vox.Speak(text, SpeechVoiceSpeakFlags.SVSFlagsAsync);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void numericUpDown_SpeechRate_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.speechRate = Convert.ToInt32(this.numericUpDown_SpeechRate.Value);
            RateOfSpeech = Convert.ToInt32(this.numericUpDown_SpeechRate.Value);
        }

        private void textBox_NotificationContent_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.spokenText = this.textBox_NotificationContent.Text;
        }

        private void comboBox_Voices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.voice = this.comboBox_Voices.SelectedItem.ToString();
            vox.Voice = vox.GetVoices("", "").Item(this.comboBox_Voices.SelectedIndex);
        }
    }
}
