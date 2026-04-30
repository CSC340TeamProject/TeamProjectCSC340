namespace TeamProjectCSC340
{
    partial class EventDetailsForm
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
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.eventDetailsLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventTitleLabel
            // 
            this.eventTitleLabel.AutoSize = true;
            this.eventTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitleLabel.Location = new System.Drawing.Point(10, 15);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Size = new System.Drawing.Size(91, 21);
            this.eventTitleLabel.TabIndex = 0;
            this.eventTitleLabel.Text = "Event Title";
            this.eventTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventDetailsLabel
            // 
            this.eventDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDetailsLabel.Location = new System.Drawing.Point(10, 62);
            this.eventDetailsLabel.Name = "eventDetailsLabel";
            this.eventDetailsLabel.Size = new System.Drawing.Size(262, 277);
            this.eventDetailsLabel.TabIndex = 1;
            this.eventDetailsLabel.Text = "Event Details";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(191, 362);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 37);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click_1);
            // 
            // EventDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.eventDetailsLabel);
            this.Controls.Add(this.eventTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventDetailsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EventDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventTitleLabel;
        private System.Windows.Forms.Label eventDetailsLabel;
        private System.Windows.Forms.Button okButton;
    }
}