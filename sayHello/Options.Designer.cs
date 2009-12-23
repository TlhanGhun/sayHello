namespace sayHello
{
    partial class Options
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_NotificationContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_SpeechRate = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_TestSettings = new System.Windows.Forms.Button();
            this.comboBox_Voices = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeechRate)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_NotificationContent
            // 
            this.textBox_NotificationContent.Location = new System.Drawing.Point(12, 52);
            this.textBox_NotificationContent.Name = "textBox_NotificationContent";
            this.textBox_NotificationContent.Size = new System.Drawing.Size(260, 20);
            this.textBox_NotificationContent.TabIndex = 1;
            this.textBox_NotificationContent.Text = "$title $text";
            this.textBox_NotificationContent.TextChanged += new System.EventHandler(this.textBox_NotificationContent_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use the placeholders $title and $text to define which text shall be spoken";
            // 
            // numericUpDown_SpeechRate
            // 
            this.numericUpDown_SpeechRate.Location = new System.Drawing.Point(56, 127);
            this.numericUpDown_SpeechRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_SpeechRate.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown_SpeechRate.Name = "numericUpDown_SpeechRate";
            this.numericUpDown_SpeechRate.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_SpeechRate.TabIndex = 3;
            this.numericUpDown_SpeechRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_SpeechRate.ValueChanged += new System.EventHandler(this.numericUpDown_SpeechRate_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 129);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 4;
            this.labelSpeed.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To be spoken text:";
            // 
            // button_TestSettings
            // 
            this.button_TestSettings.Location = new System.Drawing.Point(15, 173);
            this.button_TestSettings.Name = "button_TestSettings";
            this.button_TestSettings.Size = new System.Drawing.Size(75, 23);
            this.button_TestSettings.TabIndex = 6;
            this.button_TestSettings.Text = "Test settings";
            this.button_TestSettings.UseVisualStyleBackColor = true;
            this.button_TestSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_Voices
            // 
            this.comboBox_Voices.FormattingEnabled = true;
            this.comboBox_Voices.Location = new System.Drawing.Point(12, 12);
            this.comboBox_Voices.Name = "comboBox_Voices";
            this.comboBox_Voices.Size = new System.Drawing.Size(260, 21);
            this.comboBox_Voices.TabIndex = 8;
            this.comboBox_Voices.SelectedIndexChanged += new System.EventHandler(this.comboBox_Voices_SelectedIndexChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBox_Voices);
            this.Controls.Add(this.button_TestSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDown_SpeechRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NotificationContent);
            this.Controls.Add(this.button1);
            this.Name = "Options";
            this.Text = "Snarl Speak Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SpeechRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_NotificationContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SpeechRate;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_TestSettings;
        private System.Windows.Forms.ComboBox comboBox_Voices;
    }
}