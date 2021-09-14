namespace AutoClicker
{
    partial class MainForm
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
            this.mButtonTest = new System.Windows.Forms.Button();
            this.mPanelTest = new System.Windows.Forms.Panel();
            this.mButtonClose = new System.Windows.Forms.Button();
            this.mNUDTicksDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mLabelNumOfClicks = new System.Windows.Forms.Label();
            this.mLabelSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mNUDTicksDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // mButtonTest
            // 
            this.mButtonTest.Location = new System.Drawing.Point(91, 68);
            this.mButtonTest.Margin = new System.Windows.Forms.Padding(1);
            this.mButtonTest.Name = "mButtonTest";
            this.mButtonTest.Size = new System.Drawing.Size(119, 29);
            this.mButtonTest.TabIndex = 0;
            this.mButtonTest.Text = "Test";
            this.mButtonTest.UseVisualStyleBackColor = true;
            this.mButtonTest.Click += new System.EventHandler(this.mButtonTest_Click);
            // 
            // mPanelTest
            // 
            this.mPanelTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanelTest.Location = new System.Drawing.Point(10, 99);
            this.mPanelTest.Margin = new System.Windows.Forms.Padding(1);
            this.mPanelTest.Name = "mPanelTest";
            this.mPanelTest.Size = new System.Drawing.Size(280, 53);
            this.mPanelTest.TabIndex = 1;
            // 
            // mButtonClose
            // 
            this.mButtonClose.Location = new System.Drawing.Point(113, 156);
            this.mButtonClose.Name = "mButtonClose";
            this.mButtonClose.Size = new System.Drawing.Size(75, 23);
            this.mButtonClose.TabIndex = 2;
            this.mButtonClose.Text = "Close";
            this.mButtonClose.UseVisualStyleBackColor = true;
            this.mButtonClose.Click += new System.EventHandler(this.mButtonClose_Click);
            // 
            // mNUDTicksDelay
            // 
            this.mNUDTicksDelay.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AutoClicker.Properties.Settings.Default, "TicksDelayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mNUDTicksDelay.Location = new System.Drawing.Point(93, 12);
            this.mNUDTicksDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mNUDTicksDelay.Name = "mNUDTicksDelay";
            this.mNUDTicksDelay.Size = new System.Drawing.Size(46, 20);
            this.mNUDTicksDelay.TabIndex = 3;
            this.mNUDTicksDelay.Value = global::AutoClicker.Properties.Settings.Default.TicksDelayValue;
            this.mNUDTicksDelay.ValueChanged += new System.EventHandler(this.mNUDTicksDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticks delay";
            // 
            // mLabelNumOfClicks
            // 
            this.mLabelNumOfClicks.Location = new System.Drawing.Point(145, 39);
            this.mLabelNumOfClicks.Name = "mLabelNumOfClicks";
            this.mLabelNumOfClicks.Size = new System.Drawing.Size(145, 23);
            this.mLabelNumOfClicks.TabIndex = 5;
            this.mLabelNumOfClicks.Text = "0.00 click/sec";
            this.mLabelNumOfClicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabelSeconds
            // 
            this.mLabelSeconds.Location = new System.Drawing.Point(12, 39);
            this.mLabelSeconds.Name = "mLabelSeconds";
            this.mLabelSeconds.Size = new System.Drawing.Size(127, 23);
            this.mLabelSeconds.TabIndex = 5;
            this.mLabelSeconds.Text = "0.00 sec";
            this.mLabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.mLabelSeconds);
            this.Controls.Add(this.mLabelNumOfClicks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mNUDTicksDelay);
            this.Controls.Add(this.mButtonClose);
            this.Controls.Add(this.mPanelTest);
            this.Controls.Add(this.mButtonTest);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::AutoClicker.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = global::AutoClicker.Properties.Settings.Default.Location;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "AutoClick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mNUDTicksDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mButtonTest;
        private System.Windows.Forms.Panel mPanelTest;
        private System.Windows.Forms.Button mButtonClose;
        private System.Windows.Forms.NumericUpDown mNUDTicksDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mLabelNumOfClicks;
        private System.Windows.Forms.Label mLabelSeconds;
    }
}

