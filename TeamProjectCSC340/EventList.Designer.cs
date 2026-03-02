namespace TeamProjectCSC340
{
    partial class EventList
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MeetingList = new System.Windows.Forms.ListBox();
            this.ConferenceList = new System.Windows.Forms.ListBox();
            this.MixerList = new System.Windows.Forms.ListBox();
            this.SeminarList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // MeetingList
            // 
            this.MeetingList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MeetingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeetingList.FormattingEnabled = true;
            this.MeetingList.ItemHeight = 38;
            this.MeetingList.Items.AddRange(new object[] {
            "Friday Meeting"});
            this.MeetingList.Location = new System.Drawing.Point(12, 12);
            this.MeetingList.Name = "MeetingList";
            this.MeetingList.Size = new System.Drawing.Size(333, 118);
            this.MeetingList.TabIndex = 3;
            this.MeetingList.SelectedIndexChanged += new System.EventHandler(this.EventsLists_SelectedIndexChanged);
            // 
            // ConferenceList
            // 
            this.ConferenceList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ConferenceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConferenceList.FormattingEnabled = true;
            this.ConferenceList.ItemHeight = 38;
            this.ConferenceList.Items.AddRange(new object[] {
            "Tuesday Conference"});
            this.ConferenceList.Location = new System.Drawing.Point(351, 12);
            this.ConferenceList.Name = "ConferenceList";
            this.ConferenceList.Size = new System.Drawing.Size(364, 118);
            this.ConferenceList.TabIndex = 4;
            this.ConferenceList.SelectedIndexChanged += new System.EventHandler(this.ConferenceList_SelectedIndexChanged);
            // 
            // MixerList
            // 
            this.MixerList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MixerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MixerList.FormattingEnabled = true;
            this.MixerList.ItemHeight = 38;
            this.MixerList.Items.AddRange(new object[] {
            "Wednesday Mixer"});
            this.MixerList.Location = new System.Drawing.Point(12, 136);
            this.MixerList.Name = "MixerList";
            this.MixerList.Size = new System.Drawing.Size(333, 118);
            this.MixerList.TabIndex = 5;
            this.MixerList.SelectedIndexChanged += new System.EventHandler(this.MixerList_SelectedIndexChanged);
            // 
            // SeminarList
            // 
            this.SeminarList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SeminarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeminarList.FormattingEnabled = true;
            this.SeminarList.ItemHeight = 38;
            this.SeminarList.Items.AddRange(new object[] {
            "Monday Seminar",
            "(Delayed)"});
            this.SeminarList.Location = new System.Drawing.Point(351, 136);
            this.SeminarList.Name = "SeminarList";
            this.SeminarList.Size = new System.Drawing.Size(364, 118);
            this.SeminarList.TabIndex = 6;
            this.SeminarList.SelectedIndexChanged += new System.EventHandler(this.SeminarList_SelectedIndexChanged);
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 302);
            this.Controls.Add(this.SeminarList);
            this.Controls.Add(this.MixerList);
            this.Controls.Add(this.ConferenceList);
            this.Controls.Add(this.MeetingList);
            this.Name = "EventList";
            this.Text = "Events List";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ListBox MeetingList;
        private System.Windows.Forms.ListBox ConferenceList;
        private System.Windows.Forms.ListBox MixerList;
        private System.Windows.Forms.ListBox SeminarList;
    }
}