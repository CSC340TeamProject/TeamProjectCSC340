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
            this.newStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.newEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTitleLabel
            // 
            this.enterTitleLabel.AutoSize = true;
            this.enterTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTitleLabel.Location = new System.Drawing.Point(12, 88);
            this.enterTitleLabel.Name = "enterTitleLabel";
            this.enterTitleLabel.Size = new System.Drawing.Size(150, 25);
            this.enterTitleLabel.TabIndex = 0;
            this.enterTitleLabel.Text = "Enter New Title:";
            // 
            // newTitleTextBox
            // 
            this.newTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTitleTextBox.Location = new System.Drawing.Point(340, 87);
            this.newTitleTextBox.Name = "newTitleTextBox";
            this.newTitleTextBox.Size = new System.Drawing.Size(303, 26);
            this.newTitleTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter New Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter New Date:";
            // 
            // newStartTimeTextBox
            // 
            this.newStartTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStartTimeTextBox.Location = new System.Drawing.Point(340, 160);
            this.newStartTimeTextBox.Name = "newStartTimeTextBox";
            this.newStartTimeTextBox.Size = new System.Drawing.Size(303, 26);
            this.newStartTimeTextBox.TabIndex = 5;
            // 
            // newEndTimeTextBox
            // 
            this.newEndTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEndTimeTextBox.Location = new System.Drawing.Point(340, 239);
            this.newEndTimeTextBox.Name = "newEndTimeTextBox";
            this.newEndTimeTextBox.Size = new System.Drawing.Size(303, 26);
            this.newEndTimeTextBox.TabIndex = 6;
            // 
            // newDate
            // 
            this.newDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDate.Location = new System.Drawing.Point(340, 324);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(303, 26);
            this.newDate.TabIndex = 8;
            this.newDate.Value = new System.DateTime(2026, 2, 27, 9, 50, 14, 0);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirm Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.newEndTimeTextBox);
            this.Controls.Add(this.newStartTimeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTitleTextBox);
            this.Controls.Add(this.enterTitleLabel);
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
        private System.Windows.Forms.TextBox newStartTimeTextBox;
        private System.Windows.Forms.TextBox newEndTimeTextBox;
        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.Button button1;
    }
}