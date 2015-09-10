namespace PomodoroTimer
{
    partial class PomodoroTimerForm
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
            this.btnStartToggle = new System.Windows.Forms.Button();
            this.btnResetButton = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartToggle
            // 
            this.btnStartToggle.Location = new System.Drawing.Point(3, 124);
            this.btnStartToggle.Name = "btnStartToggle";
            this.btnStartToggle.Size = new System.Drawing.Size(149, 46);
            this.btnStartToggle.TabIndex = 0;
            this.btnStartToggle.Text = "Start Timer";
            this.btnStartToggle.UseVisualStyleBackColor = true;
            this.btnStartToggle.Click += new System.EventHandler(this.btnStartToggle_Click);
            // 
            // btnResetButton
            // 
            this.btnResetButton.Location = new System.Drawing.Point(156, 124);
            this.btnResetButton.Name = "btnResetButton";
            this.btnResetButton.Size = new System.Drawing.Size(149, 46);
            this.btnResetButton.TabIndex = 1;
            this.btnResetButton.Text = "Reset Timer";
            this.btnResetButton.UseVisualStyleBackColor = true;
            this.btnResetButton.Click += new System.EventHandler(this.btnResetButton_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(101, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(113, 49);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "25:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.btnResetButton);
            this.panel1.Controls.Add(this.btnStartToggle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 184);
            this.panel1.TabIndex = 3;
            // 
            // PomodoroTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(332, 209);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(348, 248);
            this.MinimumSize = new System.Drawing.Size(348, 248);
            this.Name = "PomodoroTimerForm";
            this.Text = "Pomodoro Timer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartToggle;
        private System.Windows.Forms.Button btnResetButton;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel panel1;
    }
}

