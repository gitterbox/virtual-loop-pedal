﻿namespace VirtualLoopPedal
{
    partial class Looper
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_record = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_StopRecording = new System.Windows.Forms.Button();
            this.button_StopPlayback = new System.Windows.Forms.Button();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coloredProgressBar_record = new VirtualLoopPedal.ColoredProgressBar();
            this.label_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_start = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_length = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).BeginInit();
            this.SuspendLayout();
            // 
            // button_record
            // 
            this.button_record.Location = new System.Drawing.Point(9, 101);
            this.button_record.Name = "button_record";
            this.button_record.Size = new System.Drawing.Size(100, 50);
            this.button_record.TabIndex = 0;
            this.button_record.Text = "Record";
            this.button_record.UseVisualStyleBackColor = true;
            this.button_record.Click += new System.EventHandler(this.button_record_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(9, 157);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 50);
            this.button_play.TabIndex = 1;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_StopRecording
            // 
            this.button_StopRecording.Enabled = false;
            this.button_StopRecording.Location = new System.Drawing.Point(115, 101);
            this.button_StopRecording.Name = "button_StopRecording";
            this.button_StopRecording.Size = new System.Drawing.Size(100, 50);
            this.button_StopRecording.TabIndex = 2;
            this.button_StopRecording.Text = "Stop";
            this.button_StopRecording.UseVisualStyleBackColor = true;
            this.button_StopRecording.Click += new System.EventHandler(this.button_StopRecording_Click);
            // 
            // button_StopPlayback
            // 
            this.button_StopPlayback.Enabled = false;
            this.button_StopPlayback.Location = new System.Drawing.Point(115, 157);
            this.button_StopPlayback.Name = "button_StopPlayback";
            this.button_StopPlayback.Size = new System.Drawing.Size(100, 50);
            this.button_StopPlayback.TabIndex = 3;
            this.button_StopPlayback.Text = "Pause";
            this.button_StopPlayback.UseVisualStyleBackColor = true;
            this.button_StopPlayback.Click += new System.EventHandler(this.button_StopPlayback_Click);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.LargeChange = 10;
            this.trackBar_Volume.Location = new System.Drawing.Point(228, 24);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Volume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_Volume.Size = new System.Drawing.Size(45, 165);
            this.trackBar_Volume.TabIndex = 4;
            this.trackBar_Volume.TickFrequency = 10;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Volume.Value = 50;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(221, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.coloredProgressBar_record);
            this.groupBox1.Controls.Add(this.label_state);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_start);
            this.groupBox1.Controls.Add(this.numericUpDown_length);
            this.groupBox1.Controls.Add(this.button_record);
            this.groupBox1.Controls.Add(this.button_StopRecording);
            this.groupBox1.Controls.Add(this.trackBar_Volume);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_play);
            this.groupBox1.Controls.Add(this.button_StopPlayback);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 267);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // coloredProgressBar_record
            // 
            this.coloredProgressBar_record.ForeColor = System.Drawing.Color.Lime;
            this.coloredProgressBar_record.Location = new System.Drawing.Point(9, 213);
            this.coloredProgressBar_record.Name = "coloredProgressBar_record";
            this.coloredProgressBar_record.Size = new System.Drawing.Size(264, 23);
            this.coloredProgressBar_record.TabIndex = 12;
            // 
            // label_state
            // 
            this.label_state.Location = new System.Drawing.Point(9, 239);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(264, 20);
            this.label_state.TabIndex = 11;
            this.label_state.Text = "ready";
            this.label_state.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Align on bars";
            this.toolTip1.SetToolTip(this.label3, "Recording and playing will wait to start unitil a bar which is a multiple of this" +
        " number.\r\nSet to 0 to start immediately.\r\nIt\'s recommended to set this to a milt" +
        "iple of the length.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length of recording (bars)";
            // 
            // numericUpDown_start
            // 
            this.numericUpDown_start.Location = new System.Drawing.Point(140, 54);
            this.numericUpDown_start.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_start.Name = "numericUpDown_start";
            this.numericUpDown_start.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_start.TabIndex = 8;
            this.numericUpDown_start.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown_length
            // 
            this.numericUpDown_length.Location = new System.Drawing.Point(140, 24);
            this.numericUpDown_length.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_length.Name = "numericUpDown_length";
            this.numericUpDown_length.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_length.TabIndex = 8;
            this.numericUpDown_length.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Looper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.MaximumSize = new System.Drawing.Size(286, 267);
            this.MinimumSize = new System.Drawing.Size(286, 267);
            this.Name = "Looper";
            this.Size = new System.Drawing.Size(286, 267);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_length)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_record;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_StopRecording;
        private System.Windows.Forms.Button button_StopPlayback;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_start;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label_state;
        private ColoredProgressBar coloredProgressBar_record;
    }
}
