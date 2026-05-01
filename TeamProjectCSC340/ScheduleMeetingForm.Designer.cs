namespace TeamProjectCSC340
{
    partial class ScheduleMeetingForm
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
            this.endTimeCbb = new System.Windows.Forms.ComboBox();
            this.startTimeCbb = new System.Windows.Forms.ComboBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addMeetingBtn = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.meetingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endTimeCbb
            // 
            this.endTimeCbb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.endTimeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.endTimeCbb.Enabled = false;
            this.endTimeCbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endTimeCbb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeCbb.FormattingEnabled = true;
            this.endTimeCbb.Items.AddRange(new object[] {
            "06:00 AM",
            "06:30 AM ",
            "07:00 AM ",
            "07:30 AM ",
            "08:00 AM ",
            "08:30 AM ",
            "09:00 AM ",
            "09:30 AM ",
            "10:00 AM ",
            "10:30 AM ",
            "11:00 AM ",
            "11:30 AM ",
            "12:00 PM ",
            "12:30 PM ",
            "01:00 PM ",
            "01:30 PM ",
            "02:00 PM ",
            "02:30 PM ",
            "03:00 PM ",
            "03:30 PM ",
            "04:00 PM ",
            "04:30 PM ",
            "05:00 PM ",
            "05:30 PM ",
            "06:00 PM ",
            "06:30 PM ",
            "07:00 PM ",
            "07:30 PM ",
            "08:00 PM ",
            "08:30 PM ",
            "09:00 PM ",
            "09:30 PM ",
            "10:00 PM"});
            this.endTimeCbb.Location = new System.Drawing.Point(580, 214);
            this.endTimeCbb.Name = "endTimeCbb";
            this.endTimeCbb.Size = new System.Drawing.Size(163, 28);
            this.endTimeCbb.TabIndex = 41;
            // 
            // startTimeCbb
            // 
            this.startTimeCbb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.startTimeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startTimeCbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTimeCbb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeCbb.FormattingEnabled = true;
            this.startTimeCbb.Items.AddRange(new object[] {
            "06:00 AM",
            "06:30 AM ",
            "07:00 AM ",
            "07:30 AM ",
            "08:00 AM ",
            "08:30 AM ",
            "09:00 AM ",
            "09:30 AM ",
            "10:00 AM ",
            "10:30 AM ",
            "11:00 AM ",
            "11:30 AM ",
            "12:00 PM ",
            "12:30 PM ",
            "01:00 PM ",
            "01:30 PM ",
            "02:00 PM ",
            "02:30 PM ",
            "03:00 PM ",
            "03:30 PM ",
            "04:00 PM ",
            "04:30 PM ",
            "05:00 PM ",
            "05:30 PM ",
            "06:00 PM ",
            "06:30 PM ",
            "07:00 PM ",
            "07:30 PM ",
            "08:00 PM ",
            "08:30 PM ",
            "09:00 PM ",
            "09:30 PM ",
            "10:00 PM"});
            this.startTimeCbb.Location = new System.Drawing.Point(580, 170);
            this.startTimeCbb.Name = "startTimeCbb";
            this.startTimeCbb.Size = new System.Drawing.Size(179, 28);
            this.startTimeCbb.TabIndex = 40;
            this.startTimeCbb.SelectedIndexChanged += new System.EventHandler(this.startTimeCbb_SelectedIndexChanged);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.returnButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(19, 28);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(115, 50);
            this.returnButton.TabIndex = 36;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "End Time:";
            // 
            // addMeetingBtn
            // 
            this.addMeetingBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addMeetingBtn.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMeetingBtn.Location = new System.Drawing.Point(498, 267);
            this.addMeetingBtn.Name = "addMeetingBtn";
            this.addMeetingBtn.Size = new System.Drawing.Size(222, 76);
            this.addMeetingBtn.TabIndex = 33;
            this.addMeetingBtn.Text = "add meeting";
            this.addMeetingBtn.UseVisualStyleBackColor = false;
            this.addMeetingBtn.Click += new System.EventHandler(this.addMeetingBtn_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(166, 98);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(243, 28);
            this.titleTextBox.TabIndex = 32;
            // 
            // meetingDatePicker
            // 
            this.meetingDatePicker.Location = new System.Drawing.Point(85, 146);
            this.meetingDatePicker.Name = "meetingDatePicker";
            this.meetingDatePicker.Size = new System.Drawing.Size(200, 20);
            this.meetingDatePicker.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Meeting Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "Find Available Times";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endTimeCbb);
            this.Controls.Add(this.startTimeCbb);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addMeetingBtn);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.meetingDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ScheduleMeetingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleMeetingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox endTimeCbb;
        private System.Windows.Forms.ComboBox startTimeCbb;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addMeetingBtn;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker meetingDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}