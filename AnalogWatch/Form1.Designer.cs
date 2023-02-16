namespace AnalogWatch
{
    partial class Watch
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
            this.components = new System.ComponentModel.Container();
            this.SecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.DigitalWatch = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WatchPB = new System.Windows.Forms.PictureBox();
            this.VisibilityTB = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.AllwaysOnTopCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.WatchPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityTB)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.Interval = 1000;
            this.SecondsTimer.Tick += new System.EventHandler(this.SecondsTimer_Tick);
            // 
            // DigitalWatch
            // 
            this.DigitalWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DigitalWatch.Location = new System.Drawing.Point(148, 415);
            this.DigitalWatch.Name = "DigitalWatch";
            this.DigitalWatch.Size = new System.Drawing.Size(130, 30);
            this.DigitalWatch.TabIndex = 1;
            // 
            // WatchPB
            // 
            this.WatchPB.BackColor = System.Drawing.SystemColors.Window;
            this.WatchPB.BackgroundImage = global::AnalogWatch.Properties.Resources.ClockImg;
            this.WatchPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WatchPB.Location = new System.Drawing.Point(0, 0);
            this.WatchPB.Name = "WatchPB";
            this.WatchPB.Size = new System.Drawing.Size(400, 400);
            this.WatchPB.TabIndex = 0;
            this.WatchPB.TabStop = false;
            this.WatchPB.Click += new System.EventHandler(this.Form1_SetBorderFixed);
            // 
            // VisibilityTB
            // 
            this.VisibilityTB.Location = new System.Drawing.Point(12, 448);
            this.VisibilityTB.Maximum = 100;
            this.VisibilityTB.Minimum = 1;
            this.VisibilityTB.Name = "VisibilityTB";
            this.VisibilityTB.Size = new System.Drawing.Size(130, 45);
            this.VisibilityTB.TabIndex = 2;
            this.VisibilityTB.Value = 100;
            this.VisibilityTB.Visible = false;
            this.VisibilityTB.ValueChanged += new System.EventHandler(this.VisibilityTB_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Průhlednost";
            this.label1.Visible = false;
            // 
            // AllwaysOnTopCB
            // 
            this.AllwaysOnTopCB.AutoSize = true;
            this.AllwaysOnTopCB.Location = new System.Drawing.Point(294, 465);
            this.AllwaysOnTopCB.Name = "AllwaysOnTopCB";
            this.AllwaysOnTopCB.Size = new System.Drawing.Size(94, 17);
            this.AllwaysOnTopCB.TabIndex = 4;
            this.AllwaysOnTopCB.Text = "Vždy na vrchu";
            this.AllwaysOnTopCB.UseVisualStyleBackColor = true;
            this.AllwaysOnTopCB.Visible = false;
            this.AllwaysOnTopCB.CheckedChanged += new System.EventHandler(this.AllwaysOnTopCB_CheckedChanged);
            // 
            // Watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.AllwaysOnTopCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisibilityTB);
            this.Controls.Add(this.DigitalWatch);
            this.Controls.Add(this.WatchPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Watch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hodiny";
            this.Deactivate += new System.EventHandler(this.Form1_SetBorderNone);
            this.Click += new System.EventHandler(this.Form1_SetBorderFixed);
            this.Enter += new System.EventHandler(this.Form1_SetBorderFixed);
            this.Leave += new System.EventHandler(this.Form1_SetBorderNone);
            ((System.ComponentModel.ISupportInitialize)(this.WatchPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisibilityTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WatchPB;
        private System.Windows.Forms.Timer SecondsTimer;
        private System.Windows.Forms.Label DigitalWatch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar VisibilityTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AllwaysOnTopCB;
    }
}

