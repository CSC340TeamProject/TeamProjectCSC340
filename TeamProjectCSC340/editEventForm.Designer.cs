namespace TeamProjectCSC340
{
    partial class editEventForm
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
            this.enterTitleLabel = new System.Windows.Forms.Label();
            this.newTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.nextButton1 = new System.Windows.Forms.Button();
            this.newStartTime = new System.Windows.Forms.DateTimePicker();
            this.newEndTime = new System.Windows.Forms.DateTimePicker();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTitleLabel
            // 
            this.enterTitleLabel.AutoSize = true;
            this.enterTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTitleLabel.Location = new System.Drawing.Point(75, 73);
            this.enterTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterTitleLabel.Name = "enterTitleLabel";
            this.enterTitleLabel.Size = new System.Drawing.Size(125, 21);
            this.enterTitleLabel.TabIndex = 0;
            this.enterTitleLabel.Text = "Enter New Title:";
            // 
            // newTitleTextBox
            // 
            this.newTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitleTextBox.Location = new System.Drawing.Point(255, 71);
            this.newTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newTitleTextBox.Name = "newTitleTextBox";
            this.newTitleTextBox.Size = new System.Drawing.Size(228, 23);
            this.newTitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter New Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter New Date:";
            // 
            // newDate
            // 
            this.newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDate.Location = new System.Drawing.Point(255, 263);
            this.newDate.Margin = new System.Windows.Forms.Padding(2);
            this.newDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.newDate.MinDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(228, 23);
            this.newDate.TabIndex = 8;
            this.newDate.Value = new System.DateTime(2026, 2, 27, 9, 50, 14, 0);
            // 
            // nextButton1
            // 
            this.nextButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.nextButton1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F);
            this.nextButton1.Location = new System.Drawing.Point(184, 317);
            this.nextButton1.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton1.Name = "nextButton1";
            this.nextButton1.Size = new System.Drawing.Size(224, 39);
            this.nextButton1.TabIndex = 9;
            this.nextButton1.Text = "confirm changes";
            this.nextButton1.UseVisualStyleBackColor = false;
            this.nextButton1.Click += new System.EventHandler(this.nextButton1_Click);
            // 
            // newStartTime
            // 
            this.newStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newStartTime.Location = new System.Drawing.Point(255, 133);
            this.newStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.newStartTime.Name = "newStartTime";
            this.newStartTime.Size = new System.Drawing.Size(228, 23);
            this.newStartTime.TabIndex = 10;
            // 
            // newEndTime
            // 
            this.newEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newEndTime.Location = new System.Drawing.Point(255, 197);
            this.newEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.newEndTime.Name = "newEndTime";
            this.newEndTime.Size = new System.Drawing.Size(228, 23);
            this.newEndTime.TabIndex = 11;
            this.newEndTime.Value = new System.DateTime(2026, 2, 27, 10, 23, 0, 0);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.returnButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(12, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(115, 50);
            this.returnButton.TabIndex = 17;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = false;
            // 
            // editEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.newEndTime);
            this.Controls.Add(this.newStartTime);
            this.Controls.Add(this.nextButton1);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTitleTextBox);
            this.Controls.Add(this.enterTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "editEventForm";
            this.Text = "Calendar - Edit Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterTitleLabel;
        private System.Windows.Forms.TextBox newTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.Button nextButton1;
        private System.Windows.Forms.DateTimePicker newStartTime;
        private System.Windows.Forms.DateTimePicker newEndTime;
        private System.Windows.Forms.Button returnButton;
    }
}