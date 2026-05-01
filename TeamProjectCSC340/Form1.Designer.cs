namespace TeamProjectCSC340
{
    partial class Form1
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
            this.editEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.addEventButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.upcomingEventsListBox = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addMeetingBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editEventButton
            // 
            this.editEventButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.editEventButton.Location = new System.Drawing.Point(539, 211);
            this.editEventButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(162, 72);
            this.editEventButton.TabIndex = 1;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = false;
            this.editEventButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.deleteEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEventButton.Location = new System.Drawing.Point(539, 301);
            this.deleteEventButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(162, 72);
            this.deleteEventButton.TabIndex = 2;
            this.deleteEventButton.Text = "Delete Event";
            this.deleteEventButton.UseVisualStyleBackColor = false;
            this.deleteEventButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Location = new System.Drawing.Point(79, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 348);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(274, 242);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 48);
            this.button4.TabIndex = 5;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(274, 175);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(235, 26);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(239, 120);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(270, 26);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(159, 47);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(350, 39);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Welcome to Calendar";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addEventButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addEventButton.Location = new System.Drawing.Point(539, 114);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(162, 72);
            this.addEventButton.TabIndex = 4;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addMeetingBtn);
            this.panel2.Controls.Add(this.upcomingEventsListBox);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.welcomeLabel);
            this.panel2.Controls.Add(this.addEventButton);
            this.panel2.Controls.Add(this.editEventButton);
            this.panel2.Controls.Add(this.deleteEventButton);
            this.panel2.Location = new System.Drawing.Point(27, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 398);
            this.panel2.TabIndex = 5;
            // 
            // upcomingEventsListBox
            // 
            this.upcomingEventsListBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.upcomingEventsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.upcomingEventsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEventsListBox.FormattingEnabled = true;
            this.upcomingEventsListBox.ItemHeight = 21;
            this.upcomingEventsListBox.Location = new System.Drawing.Point(3, 99);
            this.upcomingEventsListBox.Name = "upcomingEventsListBox";
            this.upcomingEventsListBox.Size = new System.Drawing.Size(491, 231);
            this.upcomingEventsListBox.TabIndex = 19;
            this.upcomingEventsListBox.SelectedIndexChanged += new System.EventHandler(this.upcomingEventsListBox_SelectedIndexChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logoutButton.Font = new System.Drawing.Font("Copperplate Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 50);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.welcomeLabel.Location = new System.Drawing.Point(2, 366);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(196, 32);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcome, John!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addMeetingBtn
            // 
            this.addMeetingBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addMeetingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.addMeetingBtn.Location = new System.Drawing.Point(539, 20);
            this.addMeetingBtn.Name = "addMeetingBtn";
            this.addMeetingBtn.Size = new System.Drawing.Size(162, 72);
            this.addMeetingBtn.TabIndex = 20;
            this.addMeetingBtn.Text = "Add Meeting";
            this.addMeetingBtn.UseVisualStyleBackColor = false;
            this.addMeetingBtn.Visible = false;
            this.addMeetingBtn.Click += new System.EventHandler(this.addMeetingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox upcomingEventsListBox;
        private System.Windows.Forms.Button addMeetingBtn;
    }
}
