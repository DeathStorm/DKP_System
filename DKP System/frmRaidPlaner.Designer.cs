namespace DKP_System
{
    partial class frmRaidPlaner
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
            this.tbCommentary = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStartEnde = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblRaid = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbRaid = new System.Windows.Forms.ComboBox();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.dtEnde = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtInvite = new System.Windows.Forms.DateTimePicker();
            this.lblInvite = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCommentary
            // 
            this.tbCommentary.Location = new System.Drawing.Point(85, 140);
            this.tbCommentary.Multiline = true;
            this.tbCommentary.Name = "tbCommentary";
            this.tbCommentary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCommentary.Size = new System.Drawing.Size(259, 80);
            this.tbCommentary.TabIndex = 30;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 143);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 112;
            this.lblComment.Text = "Comment";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(83, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStartEnde
            // 
            this.lblStartEnde.AutoSize = true;
            this.lblStartEnde.Location = new System.Drawing.Point(12, 121);
            this.lblStartEnde.Name = "lblStartEnde";
            this.lblStartEnde.Size = new System.Drawing.Size(65, 13);
            this.lblStartEnde.TabIndex = 105;
            this.lblStartEnde.Text = "Start / Ende";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 70);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 103;
            this.lblDatum.Text = "Datum";
            // 
            // lblRaid
            // 
            this.lblRaid.AutoSize = true;
            this.lblRaid.Location = new System.Drawing.Point(12, 44);
            this.lblRaid.Name = "lblRaid";
            this.lblRaid.Size = new System.Drawing.Size(29, 13);
            this.lblRaid.TabIndex = 102;
            this.lblRaid.Text = "Raid";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 101;
            this.lblID.Text = "ID / Status";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(83, 11);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(125, 20);
            this.tbID.TabIndex = 111;
            // 
            // cbRaid
            // 
            this.cbRaid.FormattingEnabled = true;
            this.cbRaid.Location = new System.Drawing.Point(83, 36);
            this.cbRaid.Name = "cbRaid";
            this.cbRaid.Size = new System.Drawing.Size(260, 21);
            this.cbRaid.Sorted = true;
            this.cbRaid.TabIndex = 5;
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(83, 63);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(260, 20);
            this.dtDatum.TabIndex = 10;
            // 
            // dtEnde
            // 
            this.dtEnde.CustomFormat = "HH:mm";
            this.dtEnde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnde.Location = new System.Drawing.Point(217, 114);
            this.dtEnde.Name = "dtEnde";
            this.dtEnde.ShowUpDown = true;
            this.dtEnde.Size = new System.Drawing.Size(125, 20);
            this.dtEnde.TabIndex = 25;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(83, 115);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(125, 20);
            this.dtStart.TabIndex = 20;
            // 
            // dtInvite
            // 
            this.dtInvite.CustomFormat = "HH:mm";
            this.dtInvite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvite.Location = new System.Drawing.Point(83, 89);
            this.dtInvite.Name = "dtInvite";
            this.dtInvite.ShowUpDown = true;
            this.dtInvite.Size = new System.Drawing.Size(259, 20);
            this.dtInvite.TabIndex = 15;
            // 
            // lblInvite
            // 
            this.lblInvite.AutoSize = true;
            this.lblInvite.Location = new System.Drawing.Point(12, 95);
            this.lblInvite.Name = "lblInvite";
            this.lblInvite.Size = new System.Drawing.Size(33, 13);
            this.lblInvite.TabIndex = 118;
            this.lblInvite.Text = "Invite";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(217, 10);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(125, 20);
            this.tbStatus.TabIndex = 121;
            // 
            // frmRaidPlaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 256);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.dtInvite);
            this.Controls.Add(this.lblInvite);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnde);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.cbRaid);
            this.Controls.Add(this.tbCommentary);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStartEnde);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblRaid);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "frmRaidPlaner";
            this.Text = "frmRaidPlaner";
            this.Load += new System.EventHandler(this.frmRaidPlaner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbCommentary;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStartEnde;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblRaid;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.ComboBox cbRaid;
        private System.Windows.Forms.Label lblInvite;
        public System.Windows.Forms.TextBox tbStatus;
        public System.Windows.Forms.DateTimePicker dtDatum;
        public System.Windows.Forms.DateTimePicker dtEnde;
        public System.Windows.Forms.DateTimePicker dtStart;
        public System.Windows.Forms.DateTimePicker dtInvite;
    }
}