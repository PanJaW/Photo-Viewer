namespace FizykaObrazu
{
    partial class Form2
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
            this.minDistTrackBar = new System.Windows.Forms.TrackBar();
            this.param1TrackBar = new System.Windows.Forms.TrackBar();
            this.param2TrackBar = new System.Windows.Forms.TrackBar();
            this.minRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.maxRadiusTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.houghTransfrom = new System.Windows.Forms.Button();
            this.minDistTextBox = new System.Windows.Forms.TextBox();
            this.param1TextBox = new System.Windows.Forms.TextBox();
            this.param2TextBox = new System.Windows.Forms.TextBox();
            this.minRadiusTextBox = new System.Windows.Forms.TextBox();
            this.maxRadiusTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gapTextBox = new System.Windows.Forms.TextBox();
            this.minWidthTextBox = new System.Windows.Forms.TextBox();
            this.tresholdTextBox = new System.Windows.Forms.TextBox();
            this.angleTextBox = new System.Windows.Forms.TextBox();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.tresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.distanceTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.angleTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.minWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.gapTrackBar = new System.Windows.Forms.TrackBar();
            this.Distance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minDistTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // minDistTrackBar
            // 
            this.minDistTrackBar.Location = new System.Drawing.Point(6, 25);
            this.minDistTrackBar.Maximum = 40;
            this.minDistTrackBar.Minimum = 10;
            this.minDistTrackBar.Name = "minDistTrackBar";
            this.minDistTrackBar.Size = new System.Drawing.Size(104, 45);
            this.minDistTrackBar.TabIndex = 0;
            this.minDistTrackBar.Value = 10;
            this.minDistTrackBar.Scroll += new System.EventHandler(this.minDistTrackBar_Scroll);
            // 
            // param1TrackBar
            // 
            this.param1TrackBar.Location = new System.Drawing.Point(6, 77);
            this.param1TrackBar.Maximum = 200;
            this.param1TrackBar.Minimum = 150;
            this.param1TrackBar.Name = "param1TrackBar";
            this.param1TrackBar.Size = new System.Drawing.Size(104, 45);
            this.param1TrackBar.TabIndex = 1;
            this.param1TrackBar.Value = 150;
            this.param1TrackBar.Scroll += new System.EventHandler(this.param1TrackBar_Scroll);
            // 
            // param2TrackBar
            // 
            this.param2TrackBar.Location = new System.Drawing.Point(6, 129);
            this.param2TrackBar.Maximum = 140;
            this.param2TrackBar.Minimum = 100;
            this.param2TrackBar.Name = "param2TrackBar";
            this.param2TrackBar.Size = new System.Drawing.Size(104, 45);
            this.param2TrackBar.TabIndex = 2;
            this.param2TrackBar.Value = 100;
            this.param2TrackBar.Scroll += new System.EventHandler(this.param2TrackBar_Scroll);
            // 
            // minRadiusTrackBar
            // 
            this.minRadiusTrackBar.Location = new System.Drawing.Point(6, 181);
            this.minRadiusTrackBar.Maximum = 50;
            this.minRadiusTrackBar.Name = "minRadiusTrackBar";
            this.minRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.minRadiusTrackBar.TabIndex = 3;
            this.minRadiusTrackBar.Scroll += new System.EventHandler(this.minRadiusTrackBar_Scroll);
            // 
            // maxRadiusTrackBar
            // 
            this.maxRadiusTrackBar.Location = new System.Drawing.Point(6, 233);
            this.maxRadiusTrackBar.Maximum = 100;
            this.maxRadiusTrackBar.Name = "maxRadiusTrackBar";
            this.maxRadiusTrackBar.Size = new System.Drawing.Size(104, 45);
            this.maxRadiusTrackBar.TabIndex = 4;
            this.maxRadiusTrackBar.Scroll += new System.EventHandler(this.maxRadiusTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "minDist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "param1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "param2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "minRadius";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "maxRadius";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxRadiusTextBox);
            this.groupBox1.Controls.Add(this.minRadiusTextBox);
            this.groupBox1.Controls.Add(this.param2TextBox);
            this.groupBox1.Controls.Add(this.param1TextBox);
            this.groupBox1.Controls.Add(this.minDistTextBox);
            this.groupBox1.Controls.Add(this.param2TrackBar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minDistTrackBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.param1TrackBar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.minRadiusTrackBar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maxRadiusTrackBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 288);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circle";
            // 
            // houghTransfrom
            // 
            this.houghTransfrom.Location = new System.Drawing.Point(12, 309);
            this.houghTransfrom.Name = "houghTransfrom";
            this.houghTransfrom.Size = new System.Drawing.Size(128, 23);
            this.houghTransfrom.TabIndex = 11;
            this.houghTransfrom.Text = "HoughTransfrom";
            this.houghTransfrom.UseVisualStyleBackColor = true;
            this.houghTransfrom.Click += new System.EventHandler(this.houghTransfrom_Click);
            // 
            // minDistTextBox
            // 
            this.minDistTextBox.Location = new System.Drawing.Point(179, 25);
            this.minDistTextBox.Name = "minDistTextBox";
            this.minDistTextBox.ReadOnly = true;
            this.minDistTextBox.Size = new System.Drawing.Size(61, 20);
            this.minDistTextBox.TabIndex = 10;
            // 
            // param1TextBox
            // 
            this.param1TextBox.Location = new System.Drawing.Point(179, 77);
            this.param1TextBox.Name = "param1TextBox";
            this.param1TextBox.ReadOnly = true;
            this.param1TextBox.Size = new System.Drawing.Size(61, 20);
            this.param1TextBox.TabIndex = 11;
            // 
            // param2TextBox
            // 
            this.param2TextBox.Location = new System.Drawing.Point(179, 129);
            this.param2TextBox.Name = "param2TextBox";
            this.param2TextBox.ReadOnly = true;
            this.param2TextBox.Size = new System.Drawing.Size(61, 20);
            this.param2TextBox.TabIndex = 12;
            // 
            // minRadiusTextBox
            // 
            this.minRadiusTextBox.Location = new System.Drawing.Point(179, 181);
            this.minRadiusTextBox.Name = "minRadiusTextBox";
            this.minRadiusTextBox.ReadOnly = true;
            this.minRadiusTextBox.Size = new System.Drawing.Size(61, 20);
            this.minRadiusTextBox.TabIndex = 13;
            // 
            // maxRadiusTextBox
            // 
            this.maxRadiusTextBox.Location = new System.Drawing.Point(179, 230);
            this.maxRadiusTextBox.Name = "maxRadiusTextBox";
            this.maxRadiusTextBox.ReadOnly = true;
            this.maxRadiusTextBox.Size = new System.Drawing.Size(61, 20);
            this.maxRadiusTextBox.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gapTextBox);
            this.groupBox2.Controls.Add(this.distanceTrackBar);
            this.groupBox2.Controls.Add(this.minWidthTextBox);
            this.groupBox2.Controls.Add(this.Distance);
            this.groupBox2.Controls.Add(this.tresholdTextBox);
            this.groupBox2.Controls.Add(this.gapTrackBar);
            this.groupBox2.Controls.Add(this.angleTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.distanceTextBox);
            this.groupBox2.Controls.Add(this.minWidthTrackBar);
            this.groupBox2.Controls.Add(this.tresholdTrackBar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.angleTrackBar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(265, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 288);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "lines";
            // 
            // gapTextBox
            // 
            this.gapTextBox.Location = new System.Drawing.Point(183, 229);
            this.gapTextBox.Name = "gapTextBox";
            this.gapTextBox.ReadOnly = true;
            this.gapTextBox.Size = new System.Drawing.Size(61, 20);
            this.gapTextBox.TabIndex = 29;
            // 
            // minWidthTextBox
            // 
            this.minWidthTextBox.Location = new System.Drawing.Point(183, 180);
            this.minWidthTextBox.Name = "minWidthTextBox";
            this.minWidthTextBox.ReadOnly = true;
            this.minWidthTextBox.Size = new System.Drawing.Size(61, 20);
            this.minWidthTextBox.TabIndex = 28;
            // 
            // tresholdTextBox
            // 
            this.tresholdTextBox.Location = new System.Drawing.Point(183, 128);
            this.tresholdTextBox.Name = "tresholdTextBox";
            this.tresholdTextBox.ReadOnly = true;
            this.tresholdTextBox.Size = new System.Drawing.Size(61, 20);
            this.tresholdTextBox.TabIndex = 27;
            // 
            // angleTextBox
            // 
            this.angleTextBox.Location = new System.Drawing.Point(183, 76);
            this.angleTextBox.Name = "angleTextBox";
            this.angleTextBox.ReadOnly = true;
            this.angleTextBox.Size = new System.Drawing.Size(61, 20);
            this.angleTextBox.TabIndex = 26;
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(183, 24);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.ReadOnly = true;
            this.distanceTextBox.Size = new System.Drawing.Size(61, 20);
            this.distanceTextBox.TabIndex = 25;
            // 
            // tresholdTrackBar
            // 
            this.tresholdTrackBar.Location = new System.Drawing.Point(10, 128);
            this.tresholdTrackBar.Maximum = 50;
            this.tresholdTrackBar.Minimum = 10;
            this.tresholdTrackBar.Name = "tresholdTrackBar";
            this.tresholdTrackBar.Size = new System.Drawing.Size(104, 45);
            this.tresholdTrackBar.TabIndex = 17;
            this.tresholdTrackBar.Value = 10;
            this.tresholdTrackBar.Scroll += new System.EventHandler(this.tresholdTrackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "gap";
            // 
            // distanceTrackBar
            // 
            this.distanceTrackBar.Location = new System.Drawing.Point(10, 24);
            this.distanceTrackBar.Maximum = 30;
            this.distanceTrackBar.Minimum = 10;
            this.distanceTrackBar.Name = "distanceTrackBar";
            this.distanceTrackBar.Size = new System.Drawing.Size(104, 45);
            this.distanceTrackBar.TabIndex = 15;
            this.distanceTrackBar.Value = 10;
            this.distanceTrackBar.Scroll += new System.EventHandler(this.distanceTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "minWidth";
            // 
            // angleTrackBar
            // 
            this.angleTrackBar.Location = new System.Drawing.Point(10, 76);
            this.angleTrackBar.Maximum = 90;
            this.angleTrackBar.Minimum = 30;
            this.angleTrackBar.Name = "angleTrackBar";
            this.angleTrackBar.Size = new System.Drawing.Size(104, 45);
            this.angleTrackBar.TabIndex = 16;
            this.angleTrackBar.Value = 30;
            this.angleTrackBar.Scroll += new System.EventHandler(this.angleTrackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "treshold";
            // 
            // minWidthTrackBar
            // 
            this.minWidthTrackBar.Location = new System.Drawing.Point(10, 180);
            this.minWidthTrackBar.Maximum = 50;
            this.minWidthTrackBar.Minimum = 10;
            this.minWidthTrackBar.Name = "minWidthTrackBar";
            this.minWidthTrackBar.Size = new System.Drawing.Size(104, 45);
            this.minWidthTrackBar.TabIndex = 18;
            this.minWidthTrackBar.Value = 10;
            this.minWidthTrackBar.Scroll += new System.EventHandler(this.minWidthTrackBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "angle";
            // 
            // gapTrackBar
            // 
            this.gapTrackBar.Location = new System.Drawing.Point(10, 232);
            this.gapTrackBar.Maximum = 50;
            this.gapTrackBar.Minimum = 5;
            this.gapTrackBar.Name = "gapTrackBar";
            this.gapTrackBar.Size = new System.Drawing.Size(104, 45);
            this.gapTrackBar.TabIndex = 19;
            this.gapTrackBar.Value = 5;
            this.gapTrackBar.Scroll += new System.EventHandler(this.gapTrackBar_Scroll);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(121, 24);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(49, 13);
            this.Distance.TabIndex = 20;
            this.Distance.Text = "Distance";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.houghTransfrom);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.minDistTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRadiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRadiusTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gapTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar minDistTrackBar;
        private System.Windows.Forms.TrackBar param1TrackBar;
        private System.Windows.Forms.TrackBar param2TrackBar;
        private System.Windows.Forms.TrackBar minRadiusTrackBar;
        private System.Windows.Forms.TrackBar maxRadiusTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button houghTransfrom;
        private System.Windows.Forms.TextBox maxRadiusTextBox;
        private System.Windows.Forms.TextBox minRadiusTextBox;
        private System.Windows.Forms.TextBox param2TextBox;
        private System.Windows.Forms.TextBox param1TextBox;
        private System.Windows.Forms.TextBox minDistTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox gapTextBox;
        private System.Windows.Forms.TrackBar distanceTrackBar;
        private System.Windows.Forms.TextBox minWidthTextBox;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.TextBox tresholdTextBox;
        private System.Windows.Forms.TrackBar gapTrackBar;
        private System.Windows.Forms.TextBox angleTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TrackBar minWidthTrackBar;
        private System.Windows.Forms.TrackBar tresholdTrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar angleTrackBar;
        private System.Windows.Forms.Label label7;
    }
}