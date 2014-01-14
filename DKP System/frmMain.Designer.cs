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
            this.components = new System.ComponentModel.Container();
            this.dgRaider = new System.Windows.Forms.DataGridView();
            this.dgRaiderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaiderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRaider = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddRaider = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteRaider = new System.Windows.Forms.ToolStripMenuItem();
            this.dgRaids = new System.Windows.Forms.DataGridView();
            this.dgRaidsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsShortcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsCommentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRaid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddRaid = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteRaid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMessages = new System.Windows.Forms.ToolStripSplitButton();
            this.dgContent = new System.Windows.Forms.DataGridView();
            this.cmContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddContent = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteContent = new System.Windows.Forms.ToolStripMenuItem();
            this.dgContentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgContentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).BeginInit();
            this.cmRaider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).BeginInit();
            this.cmRaid.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).BeginInit();
            this.cmContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRaider
            // 
            this.dgRaider.AllowUserToAddRows = false;
            this.dgRaider.AllowUserToDeleteRows = false;
            this.dgRaider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRaiderID,
            this.dgRaiderName});
            this.dgRaider.ContextMenuStrip = this.cmRaider;
            this.dgRaider.Location = new System.Drawing.Point(12, 12);
            this.dgRaider.Name = "dgRaider";
            this.dgRaider.ReadOnly = true;
            this.dgRaider.RowHeadersVisible = false;
            this.dgRaider.ShowEditingIcon = false;
            this.dgRaider.Size = new System.Drawing.Size(300, 537);
            this.dgRaider.TabIndex = 0;
            this.dgRaider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaider_CellDoubleClick);
            // 
            // dgRaiderID
            // 
            this.dgRaiderID.HeaderText = "ID";
            this.dgRaiderID.Name = "dgRaiderID";
            this.dgRaiderID.ReadOnly = true;
            this.dgRaiderID.Width = 20;
            // 
            // dgRaiderName
            // 
            this.dgRaiderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRaiderName.HeaderText = "Raider";
            this.dgRaiderName.Name = "dgRaiderName";
            this.dgRaiderName.ReadOnly = true;
            // 
            // cmRaider
            // 
            this.cmRaider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddRaider,
            this.miDeleteRaider});
            this.cmRaider.Name = "cmRaid";
            this.cmRaider.Size = new System.Drawing.Size(144, 48);
            // 
            // miAddRaider
            // 
            this.miAddRaider.Name = "miAddRaider";
            this.miAddRaider.Size = new System.Drawing.Size(143, 22);
            this.miAddRaider.Text = "Add Raider";
            this.miAddRaider.Click += new System.EventHandler(this.miAddRaider_Click);
            // 
            // miDeleteRaider
            // 
            this.miDeleteRaider.Name = "miDeleteRaider";
            this.miDeleteRaider.Size = new System.Drawing.Size(143, 22);
            this.miDeleteRaider.Text = "Delete Raider";
            this.miDeleteRaider.Click += new System.EventHandler(this.miDeleteRaider_Click);
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
            this.dgRaids.ContextMenuStrip = this.cmRaid;
            this.dgRaids.Location = new System.Drawing.Point(12, 555);
            this.dgRaids.Name = "dgRaids";
            this.dgRaids.ReadOnly = true;
            this.dgRaids.RowHeadersVisible = false;
            this.dgRaids.ShowEditingIcon = false;
            this.dgRaids.Size = new System.Drawing.Size(800, 150);
            this.dgRaids.TabIndex = 4;
            this.dgRaids.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaids_CellDoubleClick);
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
            this.dgRaidsShortcut.Width = 75;
            // 
            // dgRaidsContent
            // 
            this.dgRaidsContent.HeaderText = "Content";
            this.dgRaidsContent.Name = "dgRaidsContent";
            this.dgRaidsContent.ReadOnly = true;
            this.dgRaidsContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRaidsContent.Width = 50;
            // 
            // dgRaidsCommentary
            // 
            this.dgRaidsCommentary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRaidsCommentary.HeaderText = "Comment";
            this.dgRaidsCommentary.Name = "dgRaidsCommentary";
            this.dgRaidsCommentary.ReadOnly = true;
            // 
            // cmRaid
            // 
            this.cmRaid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddRaid,
            this.miDeleteRaid});
            this.cmRaid.Name = "cmRaid";
            this.cmRaid.Size = new System.Drawing.Size(134, 48);
            // 
            // miAddRaid
            // 
            this.miAddRaid.Name = "miAddRaid";
            this.miAddRaid.Size = new System.Drawing.Size(133, 22);
            this.miAddRaid.Text = "Add Raid";
            this.miAddRaid.Click += new System.EventHandler(this.miAddRaid_Click);
            // 
            // miDeleteRaid
            // 
            this.miDeleteRaid.Name = "miDeleteRaid";
            this.miDeleteRaid.Size = new System.Drawing.Size(133, 22);
            this.miDeleteRaid.Text = "Delete Raid";
            this.miDeleteRaid.Click += new System.EventHandler(this.miDeleteRaid_Click);
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(818, 555);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(100, 23);
            this.btnRefreshAll.TabIndex = 7;
            this.btnRefreshAll.Text = "Refresh All";
            this.btnRefreshAll.UseVisualStyleBackColor = true;
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessages});
            this.statusBar.Location = new System.Drawing.Point(0, 708);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBar.Size = new System.Drawing.Size(1008, 22);
            this.statusBar.TabIndex = 8;
            this.statusBar.Text = "statusBar";
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
            // dgContent
            // 
            this.dgContent.AllowUserToAddRows = false;
            this.dgContent.AllowUserToDeleteRows = false;
            this.dgContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgContentID,
            this.dgContentName});
            this.dgContent.ContextMenuStrip = this.cmContent;
            this.dgContent.Location = new System.Drawing.Point(318, 404);
            this.dgContent.Name = "dgContent";
            this.dgContent.ReadOnly = true;
            this.dgContent.RowHeadersVisible = false;
            this.dgContent.ShowEditingIcon = false;
            this.dgContent.Size = new System.Drawing.Size(158, 145);
            this.dgContent.TabIndex = 9;
            this.dgContent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContent_CellDoubleClick);
            // 
            // cmContent
            // 
            this.cmContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddContent,
            this.miDeleteContent});
            this.cmContent.Name = "cmRaid";
            this.cmContent.Size = new System.Drawing.Size(154, 48);
            // 
            // miAddContent
            // 
            this.miAddContent.Name = "miAddContent";
            this.miAddContent.Size = new System.Drawing.Size(153, 22);
            this.miAddContent.Text = "Add Content";
            this.miAddContent.Click += new System.EventHandler(this.miAddContent_Click);
            // 
            // miDeleteContent
            // 
            this.miDeleteContent.Name = "miDeleteContent";
            this.miDeleteContent.Size = new System.Drawing.Size(153, 22);
            this.miDeleteContent.Text = "Delete Content";
            this.miDeleteContent.Click += new System.EventHandler(this.miDeleteContent_Click);
            // 
            // dgContentID
            // 
            this.dgContentID.HeaderText = "ID";
            this.dgContentID.Name = "dgContentID";
            this.dgContentID.ReadOnly = true;
            this.dgContentID.Width = 20;
            // 
            // dgContentName
            // 
            this.dgContentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgContentName.HeaderText = "Content";
            this.dgContentName.Name = "dgContentName";
            this.dgContentName.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.dgContent);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnRefreshAll);
            this.Controls.Add(this.dgRaids);
            this.Controls.Add(this.dgRaider);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).EndInit();
            this.cmRaider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).EndInit();
            this.cmRaid.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).EndInit();
            this.cmContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRaider;
        private System.Windows.Forms.DataGridView dgRaids;
        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripSplitButton statusMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsShortcut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsCommentary;
        private System.Windows.Forms.ContextMenuStrip cmRaid;
        private System.Windows.Forms.ToolStripMenuItem miAddRaid;
        private System.Windows.Forms.ToolStripMenuItem miDeleteRaid;
        private System.Windows.Forms.ContextMenuStrip cmRaider;
        private System.Windows.Forms.ToolStripMenuItem miAddRaider;
        private System.Windows.Forms.ToolStripMenuItem miDeleteRaider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderName;
        private System.Windows.Forms.DataGridView dgContent;
        private System.Windows.Forms.ContextMenuStrip cmContent;
        private System.Windows.Forms.ToolStripMenuItem miAddContent;
        private System.Windows.Forms.ToolStripMenuItem miDeleteContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContentName;
    }
}

