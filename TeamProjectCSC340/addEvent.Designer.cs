namespace TeamProjectCSC340
{
    partial class addEvent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.startTimeCbb = new System.Windows.Forms.ComboBox();
            this.endTimeCbb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notes:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(208, 218);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 141);
            this.textBox1.TabIndex = 8;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(369, 67);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(243, 20);
            this.titleTextBox.TabIndex = 9;
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addEventButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.Location = new System.Drawing.Point(186, 284);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(222, 76);
            this.addEventButton.TabIndex = 11;
            this.addEventButton.Text = "add event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "End Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date:";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.returnButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(12, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(115, 50);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // startTimeCbb
            // 
            this.startTimeCbb.BackColor = System.Drawing.SystemColors.Window;
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
            this.startTimeCbb.Location = new System.Drawing.Point(201, 125);
            this.startTimeCbb.Name = "startTimeCbb";
            this.startTimeCbb.Size = new System.Drawing.Size(179, 28);
            this.startTimeCbb.TabIndex = 24;
            // 
            // endTimeCbb
            // 
            this.endTimeCbb.BackColor = System.Drawing.SystemColors.Window;
            this.endTimeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.endTimeCbb.Location = new System.Drawing.Point(501, 126);
            this.endTimeCbb.Name = "endTimeCbb";
            this.endTimeCbb.Size = new System.Drawing.Size(179, 28);
            this.endTimeCbb.TabIndex = 26;
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.endTimeCbb);
            this.Controls.Add(this.startTimeCbb);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "addEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox startTimeCbb;
        private System.Windows.Forms.ComboBox endTimeCbb;
    }
}