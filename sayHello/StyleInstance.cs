using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using libSnarlStyles;
using System.Speech.Synthesis;

namespace sayHello
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    public class StyleInstance : IStyleInstance
    {
        private SpeechSynthesizer vox = new System.Speech.Synthesis.SpeechSynthesizer();
        private System.Collections.ObjectModel.ReadOnlyCollection<InstalledVoice> voices;

        public StyleInstance()
        {
            voices = vox.GetInstalledVoices();
        }

         

        #region IStyleInstance Members

        [ComVisible(true)]
        void IStyleInstance.AdjustPosition(ref int x, ref int y, ref short Alpha, ref bool Done)
        {
            return;
        }

        [ComVisible(true)]
        melon.MImage IStyleInstance.GetContent()
        {
            
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        bool IStyleInstance.Pulse()
        {
            return false;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        void IStyleInstance.Show(bool Visible)
        {
            return;
            throw new NotImplementedException();
        }

        [ComVisible(true)]
        void IStyleInstance.UpdateContent(ref notification_info NotificationInfo)
        {
            
            try
            {
                if (NotificationInfo.Scheme != string.Empty)
                {                
                    vox.SelectVoice(getVoiceName(NotificationInfo.Scheme));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string text = Properties.Settings.Default.spokenText;
                text = text.Replace("$title", NotificationInfo.Title);
                text = text.Replace("$text", NotificationInfo.Text);
                vox.Rate = Properties.Settings.Default.speechRate; 
                vox.SpeakAsync(text);
            }
            catch (Exception e)
            {
               // MessageBox.Show(e.Message, "Error in speaking this notification", MessageBoxButtons.OK);
               // MessageBox.Show(e.StackTrace, "Details", MessageBoxButtons.OK);
                Console.WriteLine(e.Message);
            }
        }

        #endregion

        private string getVoiceName(string voiceNameinLowerCharacters)
        {
            string voiceName = "";
            foreach (InstalledVoice voice in voices)
            {
                if (voiceNameinLowerCharacters.ToLower() == voice.VoiceInfo.Name.ToLower())
                {
                    voiceName = voice.VoiceInfo.Name;
                    break;
                }
            }
            return voiceName;
        }
    }
}