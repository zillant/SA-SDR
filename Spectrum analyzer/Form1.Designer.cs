namespace Spectrum_analyzer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spectrumAnalyzer = new SDRSharp.PanView.SpectrumAnalyzer();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdbRTLSDR = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbHackRF = new System.Windows.Forms.RadioButton();
            this.lblErr = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spectrumAnalyzer
            // 
            this.spectrumAnalyzer.Attack = 0D;
            this.spectrumAnalyzer.BandType = SDRSharp.PanView.BandType.Lower;
            this.spectrumAnalyzer.CenterFrequency = ((long)(0));
            this.spectrumAnalyzer.Decay = 0D;
            this.spectrumAnalyzer.DisplayOffset = 0;
            this.spectrumAnalyzer.DisplayRange = 130;
            this.spectrumAnalyzer.EnableFilter = true;
            this.spectrumAnalyzer.FilterBandwidth = 0;
            this.spectrumAnalyzer.FilterOffset = 0;
            this.spectrumAnalyzer.Frequency = ((long)(0));
            this.spectrumAnalyzer.Location = new System.Drawing.Point(74, 12);
            this.spectrumAnalyzer.MarkPeaks = false;
            this.spectrumAnalyzer.Name = "spectrumAnalyzer";
            this.spectrumAnalyzer.ShowMaxLine = false;
            this.spectrumAnalyzer.Size = new System.Drawing.Size(652, 297);
            this.spectrumAnalyzer.SpectrumWidth = 0;
            this.spectrumAnalyzer.StatusText = null;
            this.spectrumAnalyzer.StepSize = 1000;
            this.spectrumAnalyzer.TabIndex = 1;
            this.spectrumAnalyzer.UseSmoothing = false;
            this.spectrumAnalyzer.UseSnap = false;
            this.spectrumAnalyzer.Zoom = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(362, 315);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdbRTLSDR
            // 
            this.rdbRTLSDR.AutoSize = true;
            this.rdbRTLSDR.Checked = true;
            this.rdbRTLSDR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbRTLSDR.Location = new System.Drawing.Point(16, 19);
            this.rdbRTLSDR.Name = "rdbRTLSDR";
            this.rdbRTLSDR.Size = new System.Drawing.Size(107, 17);
            this.rdbRTLSDR.TabIndex = 3;
            this.rdbRTLSDR.TabStop = true;
            this.rdbRTLSDR.Text = "RTL-SDR dongle";
            this.rdbRTLSDR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHackRF);
            this.groupBox1.Controls.Add(this.rdbRTLSDR);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(104, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // rdbHackRF
            // 
            this.rdbHackRF.AutoSize = true;
            this.rdbHackRF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbHackRF.Location = new System.Drawing.Point(16, 42);
            this.rdbHackRF.Name = "rdbHackRF";
            this.rdbHackRF.Size = new System.Drawing.Size(65, 17);
            this.rdbHackRF.TabIndex = 4;
            this.rdbHackRF.Text = "HackRF";
            this.rdbHackRF.UseVisualStyleBackColor = true;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErr.Location = new System.Drawing.Point(104, 408);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(35, 13);
            this.lblErr.TabIndex = 5;
            this.lblErr.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.spectrumAnalyzer);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Spectrum analyzer v.0.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SDRSharp.PanView.SpectrumAnalyzer spectrumAnalyzer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdbRTLSDR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbHackRF;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.Timer timer1;
    }
}

