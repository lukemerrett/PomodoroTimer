namespace PomodoroTimer
{
    partial class Timer
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
            this.SuspendLayout();
            // 
            // btnStartToggle
            // 
            this.btnStartToggle.Location = new System.Drawing.Point(12, 201);
            this.btnStartToggle.Name = "btnStartToggle";
            this.btnStartToggle.Size = new System.Drawing.Size(149, 46);
            this.btnStartToggle.TabIndex = 0;
            this.btnStartToggle.Text = "Start Timer";
            this.btnStartToggle.UseVisualStyleBackColor = true;
            this.btnStartToggle.Click += new System.EventHandler(this.btnStartToggle_Click);
            // 
            // btnResetButton
            // 
            this.btnResetButton.Location = new System.Drawing.Point(167, 201);
            this.btnResetButton.Name = "btnResetButton";
            this.btnResetButton.Size = new System.Drawing.Size(149, 46);
            this.btnResetButton.TabIndex = 1;
            this.btnResetButton.Text = "Reset Timer";
            this.btnResetButton.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 259);
            this.Controls.Add(this.btnResetButton);
            this.Controls.Add(this.btnStartToggle);
            this.Name = "Timer";
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartToggle;
        private System.Windows.Forms.Button btnResetButton;
    }
}

