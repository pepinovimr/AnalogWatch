namespace AnalogWatch
{
    partial class Form1
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
            this.WatchPB = new System.Windows.Forms.PictureBox();
            this.SecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WatchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // WatchPB
            // 
            this.WatchPB.Location = new System.Drawing.Point(0, 0);
            this.WatchPB.Name = "WatchPB";
            this.WatchPB.Size = new System.Drawing.Size(400, 400);
            this.WatchPB.TabIndex = 0;
            this.WatchPB.TabStop = false;
            this.WatchPB.Click += new System.EventHandler(this.Form1_Click);
            // 
            // SecondsTimer
            // 
            this.SecondsTimer.Interval = 1000;
            this.SecondsTimer.Tick += new System.EventHandler(this.SecondsTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WatchPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_SetNoneHandle);
            this.VisibleChanged += new System.EventHandler(this.Form1_SetNoneHandle);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Enter += new System.EventHandler(this.Form1_SetNoneHandle);
            this.Leave += new System.EventHandler(this.Form1_SetNoneHandle);
            ((System.ComponentModel.ISupportInitialize)(this.WatchPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WatchPB;
        private System.Windows.Forms.Timer SecondsTimer;
        private System.Windows.Forms.Label label1;
    }
}

