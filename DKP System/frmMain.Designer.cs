namespace DKP_System
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRaider = new System.Windows.Forms.DataGridView();
            this.dgRaiderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaiderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaiderDKP_T1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaiderDKP_T2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRaider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgRaids = new System.Windows.Forms.DataGridView();
            this.btnAddRaid = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusMessages = new System.Windows.Forms.ToolStripSplitButton();
            this.dgRaidsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsShortcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsCommentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRaider
            // 
            this.dgRaider.AllowUserToAddRows = false;
            this.dgRaider.AllowUserToDeleteRows = false;
            this.dgRaider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRaiderID,
            this.dgRaiderName,
            this.dgRaiderDKP_T1,
            this.dgRaiderDKP_T2});
            this.dgRaider.Location = new System.Drawing.Point(12, 41);
            this.dgRaider.Name = "dgRaider";
            this.dgRaider.ShowEditingIcon = false;
            this.dgRaider.Size = new System.Drawing.Size(394, 233);
            this.dgRaider.TabIndex = 0;
            this.dgRaider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaider_CellDoubleClick);
            // 
            // dgRaiderID
            // 
            this.dgRaiderID.HeaderText = "ID";
            this.dgRaiderID.Name = "dgRaiderID";
            this.dgRaiderID.Width = 20;
            // 
            // dgRaiderName
            // 
            this.dgRaiderName.HeaderText = "Raider";
            this.dgRaiderName.Name = "dgRaiderName";
            // 
            // dgRaiderDKP_T1
            // 
            this.dgRaiderDKP_T1.HeaderText = "DKP T1";
            this.dgRaiderDKP_T1.Name = "dgRaiderDKP_T1";
            // 
            // dgRaiderDKP_T2
            // 
            this.dgRaiderDKP_T2.HeaderText = "DKP T2";
            this.dgRaiderDKP_T2.Name = "dgRaiderDKP_T2";
            // 
            // btnAddRaider
            // 
            this.btnAddRaider.Location = new System.Drawing.Point(12, 12);
            this.btnAddRaider.Name = "btnAddRaider";
            this.btnAddRaider.Size = new System.Drawing.Size(100, 23);
            this.btnAddRaider.TabIndex = 2;
            this.btnAddRaider.Text = "Add Raider";
            this.btnAddRaider.UseVisualStyleBackColor = true;
            this.btnAddRaider.Click += new System.EventHandler(this.btnAddRaider_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Raider";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgRaids
            // 
            this.dgRaids.AllowUserToAddRows = false;
            this.dgRaids.AllowUserToDeleteRows = false;
            this.dgRaids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRaidsID,
            this.dgRaidsName,
            this.dgRaidsShortcut,
            this.dgRaidsContent,
            this.dgRaidsCommentary});
            this.dgRaids.Location = new System.Drawing.Point(12, 332);
            this.dgRaids.Name = "dgRaids";
            this.dgRaids.ReadOnly = true;
            this.dgRaids.Size = new System.Drawing.Size(504, 233);
            this.dgRaids.TabIndex = 4;
            this.dgRaids.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaids_CellDoubleClick);
            // 
            // btnAddRaid
            // 
            this.btnAddRaid.Location = new System.Drawing.Point(12, 303);
            this.btnAddRaid.Name = "btnAddRaid";
            this.btnAddRaid.Size = new System.Drawing.Size(100, 23);
            this.btnAddRaid.TabIndex = 5;
            this.btnAddRaid.Text = "Add Raid";
            this.btnAddRaid.UseVisualStyleBackColor = true;
            this.btnAddRaid.Click += new System.EventHandler(this.btnAddRaid_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Remove Raider";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(685, 222);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(100, 23);
            this.btnRefreshAll.TabIndex = 7;
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessages});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusMessages
            // 
            this.statusMessages.BackColor = System.Drawing.SystemColors.Control;
            this.statusMessages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusMessages.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.statusMessages.Name = "statusMessages";
            this.statusMessages.Size = new System.Drawing.Size(105, 20);
            this.statusMessages.Text = "statusMessages";
            // 
            // dgRaidsID
            // 
            this.dgRaidsID.HeaderText = "ID";
            this.dgRaidsID.Name = "dgRaidsID";
            this.dgRaidsID.ReadOnly = true;
            this.dgRaidsID.Width = 20;
            // 
            // dgRaidsName
            // 
            this.dgRaidsName.HeaderText = "Raid";
            this.dgRaidsName.Name = "dgRaidsName";
            this.dgRaidsName.ReadOnly = true;
            // 
            // dgRaidsShortcut
            // 
            this.dgRaidsShortcut.HeaderText = "Shortcut";
            this.dgRaidsShortcut.Name = "dgRaidsShortcut";
            this.dgRaidsShortcut.ReadOnly = true;
            // 
            // dgRaidsContent
            // 
            this.dgRaidsContent.HeaderText = "Content";
            this.dgRaidsContent.Name = "dgRaidsContent";
            this.dgRaidsContent.ReadOnly = true;
            this.dgRaidsContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgRaidsCommentary
            // 
            this.dgRaidsCommentary.HeaderText = "Comment";
            this.dgRaidsCommentary.Name = "dgRaidsCommentary";
            this.dgRaidsCommentary.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 715);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddRaid);
            this.Controls.Add(this.dgRaids);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddRaider);
            this.Controls.Add(this.dgRaider);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRaider;
        private System.Windows.Forms.Button btnAddRaider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgRaids;
        private System.Windows.Forms.Button btnAddRaid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderDKP_T1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderDKP_T2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton statusMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsShortcut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsCommentary;
    }
}

