namespace DKP_System
{
    partial class frmBossList
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
            this.cbRaid = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRaid = new System.Windows.Forms.Label();
            this.lblDKPTeilnehmer = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblDKPErsatz = new System.Windows.Forms.Label();
            this.cbVorgaenger = new System.Windows.Forms.ComboBox();
            this.lblVorgaenger = new System.Windows.Forms.Label();
            this.nudDKPTeilnehmer = new System.Windows.Forms.NumericUpDown();
            this.nudDKPErsatz = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDKPTeilnehmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDKPErsatz)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRaid
            // 
            this.cbRaid.FormattingEnabled = true;
            this.cbRaid.Items.AddRange(new object[] {
            "T1",
            "T2"});
            this.cbRaid.Location = new System.Drawing.Point(99, 64);
            this.cbRaid.Name = "cbRaid";
            this.cbRaid.Size = new System.Drawing.Size(222, 21);
            this.cbRaid.Sorted = true;
            this.cbRaid.TabIndex = 107;
            this.cbRaid.SelectedIndexChanged += new System.EventHandler(this.cbRaid_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 110;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(62, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRaid
            // 
            this.lblRaid.AutoSize = true;
            this.lblRaid.Location = new System.Drawing.Point(11, 67);
            this.lblRaid.Name = "lblRaid";
            this.lblRaid.Size = new System.Drawing.Size(29, 13);
            this.lblRaid.TabIndex = 105;
            this.lblRaid.Text = "Raid";
            // 
            // lblDKPTeilnehmer
            // 
            this.lblDKPTeilnehmer.AutoSize = true;
            this.lblDKPTeilnehmer.Location = new System.Drawing.Point(10, 94);
            this.lblDKPTeilnehmer.Name = "lblDKPTeilnehmer";
            this.lblDKPTeilnehmer.Size = new System.Drawing.Size(84, 13);
            this.lblDKPTeilnehmer.TabIndex = 103;
            this.lblDKPTeilnehmer.Text = "DKP Teilnehmer";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 20);
            this.tbName.TabIndex = 104;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 102;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 101;
            this.lblID.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(100, 12);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(222, 20);
            this.tbID.TabIndex = 111;
            // 
            // lblDKPErsatz
            // 
            this.lblDKPErsatz.AutoSize = true;
            this.lblDKPErsatz.Location = new System.Drawing.Point(10, 120);
            this.lblDKPErsatz.Name = "lblDKPErsatz";
            this.lblDKPErsatz.Size = new System.Drawing.Size(61, 13);
            this.lblDKPErsatz.TabIndex = 113;
            this.lblDKPErsatz.Text = "DKP Ersatz";
            // 
            // cbVorgaenger
            // 
            this.cbVorgaenger.FormattingEnabled = true;
            this.cbVorgaenger.Items.AddRange(new object[] {
            "T1",
            "T2"});
            this.cbVorgaenger.Location = new System.Drawing.Point(100, 143);
            this.cbVorgaenger.Name = "cbVorgaenger";
            this.cbVorgaenger.Size = new System.Drawing.Size(222, 21);
            this.cbVorgaenger.Sorted = true;
            this.cbVorgaenger.TabIndex = 116;
            // 
            // lblVorgaenger
            // 
            this.lblVorgaenger.AutoSize = true;
            this.lblVorgaenger.Location = new System.Drawing.Point(12, 146);
            this.lblVorgaenger.Name = "lblVorgaenger";
            this.lblVorgaenger.Size = new System.Drawing.Size(29, 13);
            this.lblVorgaenger.TabIndex = 115;
            this.lblVorgaenger.Text = "Raid";
            // 
            // nudDKPTeilnehmer
            // 
            this.nudDKPTeilnehmer.Location = new System.Drawing.Point(101, 92);
            this.nudDKPTeilnehmer.Name = "nudDKPTeilnehmer";
            this.nudDKPTeilnehmer.Size = new System.Drawing.Size(221, 20);
            this.nudDKPTeilnehmer.TabIndex = 117;
            // 
            // nudDKPErsatz
            // 
            this.nudDKPErsatz.Location = new System.Drawing.Point(101, 118);
            this.nudDKPErsatz.Name = "nudDKPErsatz";
            this.nudDKPErsatz.Size = new System.Drawing.Size(221, 20);
            this.nudDKPErsatz.TabIndex = 118;
            // 
            // frmBossList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 200);
            this.Controls.Add(this.nudDKPErsatz);
            this.Controls.Add(this.nudDKPTeilnehmer);
            this.Controls.Add(this.cbVorgaenger);
            this.Controls.Add(this.lblVorgaenger);
            this.Controls.Add(this.lblDKPErsatz);
            this.Controls.Add(this.cbRaid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRaid);
            this.Controls.Add(this.lblDKPTeilnehmer);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "frmBossList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBossList";
            ((System.ComponentModel.ISupportInitialize)(this.nudDKPTeilnehmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDKPErsatz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRaid;
        private System.Windows.Forms.Label lblDKPTeilnehmer;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lblDKPErsatz;
        private System.Windows.Forms.Label lblVorgaenger;
        internal System.Windows.Forms.ComboBox cbRaid;
        internal System.Windows.Forms.ComboBox cbVorgaenger;
        internal System.Windows.Forms.NumericUpDown nudDKPTeilnehmer;
        internal System.Windows.Forms.NumericUpDown nudDKPErsatz;
    }
}