using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using libSnarlStyles;

using SpeechLib;

namespace sayHello
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    public class StyleInstance : IStyleInstance
    {
        private Dictionary<string, string> availableVoices = new Dictionary<string, string>();
        private SpVoice vox = new SpVoice();

        public StyleInstance()
        {
            foreach (ISpeechObjectToken voice in vox.GetVoices("", ""))
            {
                availableVoices.Add(voice.GetDescription(0), voice.Id);
            }
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
                if (NotificationInfo.Scheme != string.Empty && availableVoices.Count > 0)
                {
                    int i=0;
                    foreach (ISpeechObjectToken voice in vox.GetVoices("", ""))
                    {
                        if (NotificationInfo.Scheme.ToLower() == voice.GetDescription(0).ToLower())
                        {
                            vox.Voice = vox.GetVoices("", "").Item(i);
                            break;
                        }
                        i++;
                    }
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
                vox.WaitUntilDone(-1);
                vox.Speak(text, SpeechVoiceSpeakFlags.SVSFlagsAsync);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error in speaking this notification", MessageBoxButtons.OK);
                MessageBox.Show(e.StackTrace, "Details", MessageBoxButtons.OK);
            }
        }

        #endregion
    }
}