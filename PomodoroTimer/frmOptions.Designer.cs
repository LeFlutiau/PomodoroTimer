namespace Pomodoro
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.numPomodoroDuration = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numShortPauseDuration = new System.Windows.Forms.NumericUpDown();
            this.numLongPauseDuration = new System.Windows.Forms.NumericUpDown();
            this.numCountToLongPause = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPomodoroDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortPauseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongPauseDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountToLongPause)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pomodoro duration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numPomodoroDuration
            // 
            this.numPomodoroDuration.Location = new System.Drawing.Point(176, 8);
            this.numPomodoroDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numPomodoroDuration.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numPomodoroDuration.Name = "numPomodoroDuration";
            this.numPomodoroDuration.Size = new System.Drawing.Size(60, 31);
            this.numPomodoroDuration.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Short pause";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Long pause";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Long pause after";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numShortPauseDuration
            // 
            this.numShortPauseDuration.Location = new System.Drawing.Point(176, 48);
            this.numShortPauseDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numShortPauseDuration.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numShortPauseDuration.Name = "numShortPauseDuration";
            this.numShortPauseDuration.Size = new System.Drawing.Size(60, 31);
            this.numShortPauseDuration.TabIndex = 2;
            // 
            // numLongPauseDuration
            // 
            this.numLongPauseDuration.Location = new System.Drawing.Point(176, 88);
            this.numLongPauseDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numLongPauseDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numLongPauseDuration.Name = "numLongPauseDuration";
            this.numLongPauseDuration.Size = new System.Drawing.Size(60, 31);
            this.numLongPauseDuration.TabIndex = 3;
            // 
            // numCountToLongPause
            // 
            this.numCountToLongPause.Location = new System.Drawing.Point(176, 128);
            this.numCountToLongPause.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numCountToLongPause.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCountToLongPause.Name = "numCountToLongPause";
            this.numCountToLongPause.Size = new System.Drawing.Size(60, 31);
            this.numCountToLongPause.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(240, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "minutes";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(240, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "minutes";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(240, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "minutes";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(240, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "pomodoros";
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 213);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numCountToLongPause);
            this.Controls.Add(this.numLongPauseDuration);
            this.Controls.Add(this.numShortPauseDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPomodoroDuration);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numPomodoroDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShortPauseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongPauseDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountToLongPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPomodoroDuration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numShortPauseDuration;
        private System.Windows.Forms.NumericUpDown numLongPauseDuration;
        private System.Windows.Forms.NumericUpDown numCountToLongPause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}