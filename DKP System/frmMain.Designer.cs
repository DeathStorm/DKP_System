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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmRaider = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddRaider = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteRaider = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRaid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddRaid = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteRaid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshAll = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMessages = new System.Windows.Forms.ToolStripSplitButton();
            this.cmContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddContent = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRaidplaner = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStandardEnde = new System.Windows.Forms.Label();
            this.dtStandardEnde = new System.Windows.Forms.DateTimePicker();
            this.dtStandardStart = new System.Windows.Forms.DateTimePicker();
            this.dtStandardInvite = new System.Windows.Forms.DateTimePicker();
            this.lblStandardInvite = new System.Windows.Forms.Label();
            this.lblStandardStart = new System.Windows.Forms.Label();
            this.dgRaidPlaner = new System.Windows.Forms.DataGridView();
            this.dgRaidPlanerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerRaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerInvite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidPlanerComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmRaidPlaner = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miRaidPlanerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miRaidplanerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miRaidPlanerCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.rbShowClosed = new System.Windows.Forms.RadioButton();
            this.rbShowOpen = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.tabBasicSettings = new System.Windows.Forms.TabPage();
            this.dgContent = new System.Windows.Forms.DataGridView();
            this.dgContentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgContentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaids = new System.Windows.Forms.DataGridView();
            this.dgRaidsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsShortcut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaidsCommentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaider = new System.Windows.Forms.DataGridView();
            this.dgRaiderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRaiderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.dgBossList = new System.Windows.Forms.DataGridView();
            this.dgBossListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBossListBoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBossListRaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBossListDKPTeilnehmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBossListDKPErsatz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBossListVorgaenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmBossList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.miDeleteBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.cmRaider.SuspendLayout();
            this.cmRaid.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.cmContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRaidplaner.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaidPlaner)).BeginInit();
            this.cmRaidPlaner.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            this.tabBasicSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBossList)).BeginInit();
            this.cmBossList.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRefreshAll.Location = new System.Drawing.Point(844, 471);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRaidplaner);
            this.tabControl1.Controls.Add(this.tabBasicSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 693);
            this.tabControl1.TabIndex = 10;
            // 
            // tabRaidplaner
            // 
            this.tabRaidplaner.Controls.Add(this.groupBox1);
            this.tabRaidplaner.Controls.Add(this.dgRaidPlaner);
            this.tabRaidplaner.Controls.Add(this.groupBoxShow);
            this.tabRaidplaner.Location = new System.Drawing.Point(4, 22);
            this.tabRaidplaner.Name = "tabRaidplaner";
            this.tabRaidplaner.Padding = new System.Windows.Forms.Padding(3);
            this.tabRaidplaner.Size = new System.Drawing.Size(789, 667);
            this.tabRaidplaner.TabIndex = 0;
            this.tabRaidplaner.Text = "Raidplaner";
            this.tabRaidplaner.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStandardEnde);
            this.groupBox1.Controls.Add(this.dtStandardEnde);
            this.groupBox1.Controls.Add(this.dtStandardStart);
            this.groupBox1.Controls.Add(this.dtStandardInvite);
            this.groupBox1.Controls.Add(this.lblStandardInvite);
            this.groupBox1.Controls.Add(this.lblStandardStart);
            this.groupBox1.Location = new System.Drawing.Point(109, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 100);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StandardWerte";
            // 
            // lblStandardEnde
            // 
            this.lblStandardEnde.AutoSize = true;
            this.lblStandardEnde.Location = new System.Drawing.Point(6, 71);
            this.lblStandardEnde.Name = "lblStandardEnde";
            this.lblStandardEnde.Size = new System.Drawing.Size(32, 13);
            this.lblStandardEnde.TabIndex = 122;
            this.lblStandardEnde.Text = "Ende";
            // 
            // dtStandardEnde
            // 
            this.dtStandardEnde.CustomFormat = "HH:mm";
            this.dtStandardEnde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStandardEnde.Location = new System.Drawing.Point(45, 71);
            this.dtStandardEnde.Name = "dtStandardEnde";
            this.dtStandardEnde.ShowUpDown = true;
            this.dtStandardEnde.Size = new System.Drawing.Size(100, 20);
            this.dtStandardEnde.TabIndex = 29;
            // 
            // dtStandardStart
            // 
            this.dtStandardStart.CustomFormat = "HH:mm";
            this.dtStandardStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStandardStart.Location = new System.Drawing.Point(45, 45);
            this.dtStandardStart.Name = "dtStandardStart";
            this.dtStandardStart.ShowUpDown = true;
            this.dtStandardStart.Size = new System.Drawing.Size(100, 20);
            this.dtStandardStart.TabIndex = 28;
            // 
            // dtStandardInvite
            // 
            this.dtStandardInvite.CustomFormat = "HH:mm";
            this.dtStandardInvite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStandardInvite.Location = new System.Drawing.Point(45, 19);
            this.dtStandardInvite.Name = "dtStandardInvite";
            this.dtStandardInvite.ShowUpDown = true;
            this.dtStandardInvite.Size = new System.Drawing.Size(100, 20);
            this.dtStandardInvite.TabIndex = 27;
            this.dtStandardInvite.Value = new System.DateTime(2014, 1, 15, 12, 9, 0, 0);
            // 
            // lblStandardInvite
            // 
            this.lblStandardInvite.AutoSize = true;
            this.lblStandardInvite.Location = new System.Drawing.Point(6, 19);
            this.lblStandardInvite.Name = "lblStandardInvite";
            this.lblStandardInvite.Size = new System.Drawing.Size(33, 13);
            this.lblStandardInvite.TabIndex = 121;
            this.lblStandardInvite.Text = "Invite";
            // 
            // lblStandardStart
            // 
            this.lblStandardStart.AutoSize = true;
            this.lblStandardStart.Location = new System.Drawing.Point(6, 45);
            this.lblStandardStart.Name = "lblStandardStart";
            this.lblStandardStart.Size = new System.Drawing.Size(29, 13);
            this.lblStandardStart.TabIndex = 120;
            this.lblStandardStart.Text = "Start";
            // 
            // dgRaidPlaner
            // 
            this.dgRaidPlaner.AllowUserToAddRows = false;
            this.dgRaidPlaner.AllowUserToDeleteRows = false;
            this.dgRaidPlaner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaidPlaner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRaidPlanerID,
            this.dgRaidPlanerDate,
            this.dgRaidPlanerRaid,
            this.dgRaidPlanerContent,
            this.dgRaidPlanerStart,
            this.dgRaidPlanerInvite,
            this.dgRaidPlanerEnd,
            this.dgRaidPlanerStatus,
            this.dgRaidPlanerComment});
            this.dgRaidPlaner.ContextMenuStrip = this.cmRaidPlaner;
            this.dgRaidPlaner.Location = new System.Drawing.Point(6, 191);
            this.dgRaidPlaner.Name = "dgRaidPlaner";
            this.dgRaidPlaner.ReadOnly = true;
            this.dgRaidPlaner.RowHeadersVisible = false;
            this.dgRaidPlaner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRaidPlaner.ShowEditingIcon = false;
            this.dgRaidPlaner.Size = new System.Drawing.Size(777, 150);
            this.dgRaidPlaner.TabIndex = 12;
            this.dgRaidPlaner.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaidPlaner_CellDoubleClick);
            this.dgRaidPlaner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgRaider_MouseDown);
            // 
            // dgRaidPlanerID
            // 
            this.dgRaidPlanerID.HeaderText = "ID";
            this.dgRaidPlanerID.Name = "dgRaidPlanerID";
            this.dgRaidPlanerID.ReadOnly = true;
            this.dgRaidPlanerID.Width = 20;
            // 
            // dgRaidPlanerDate
            // 
            dataGridViewCellStyle3.Format = "dd.MM.yyyy";
            this.dgRaidPlanerDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRaidPlanerDate.HeaderText = "Datum";
            this.dgRaidPlanerDate.Name = "dgRaidPlanerDate";
            this.dgRaidPlanerDate.ReadOnly = true;
            this.dgRaidPlanerDate.Width = 75;
            // 
            // dgRaidPlanerRaid
            // 
            this.dgRaidPlanerRaid.HeaderText = "Raid";
            this.dgRaidPlanerRaid.Name = "dgRaidPlanerRaid";
            this.dgRaidPlanerRaid.ReadOnly = true;
            // 
            // dgRaidPlanerContent
            // 
            this.dgRaidPlanerContent.HeaderText = "Content";
            this.dgRaidPlanerContent.Name = "dgRaidPlanerContent";
            this.dgRaidPlanerContent.ReadOnly = true;
            this.dgRaidPlanerContent.Width = 50;
            // 
            // dgRaidPlanerStart
            // 
            this.dgRaidPlanerStart.HeaderText = "Start";
            this.dgRaidPlanerStart.Name = "dgRaidPlanerStart";
            this.dgRaidPlanerStart.ReadOnly = true;
            this.dgRaidPlanerStart.Width = 40;
            // 
            // dgRaidPlanerInvite
            // 
            dataGridViewCellStyle4.Format = "HH:mm";
            this.dgRaidPlanerInvite.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgRaidPlanerInvite.HeaderText = "Invite";
            this.dgRaidPlanerInvite.Name = "dgRaidPlanerInvite";
            this.dgRaidPlanerInvite.ReadOnly = true;
            this.dgRaidPlanerInvite.Width = 40;
            // 
            // dgRaidPlanerEnd
            // 
            this.dgRaidPlanerEnd.HeaderText = "Ende";
            this.dgRaidPlanerEnd.Name = "dgRaidPlanerEnd";
            this.dgRaidPlanerEnd.ReadOnly = true;
            this.dgRaidPlanerEnd.Width = 40;
            // 
            // dgRaidPlanerStatus
            // 
            this.dgRaidPlanerStatus.HeaderText = "Status";
            this.dgRaidPlanerStatus.Name = "dgRaidPlanerStatus";
            this.dgRaidPlanerStatus.ReadOnly = true;
            this.dgRaidPlanerStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRaidPlanerStatus.Width = 50;
            // 
            // dgRaidPlanerComment
            // 
            this.dgRaidPlanerComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRaidPlanerComment.HeaderText = "Comment";
            this.dgRaidPlanerComment.Name = "dgRaidPlanerComment";
            this.dgRaidPlanerComment.ReadOnly = true;
            // 
            // cmRaidPlaner
            // 
            this.cmRaidPlaner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRaidPlanerAdd,
            this.miRaidplanerDelete,
            this.miRaidPlanerCopy});
            this.cmRaidPlaner.Name = "cmRaid";
            this.cmRaidPlaner.Size = new System.Drawing.Size(134, 70);
            // 
            // miRaidPlanerAdd
            // 
            this.miRaidPlanerAdd.Name = "miRaidPlanerAdd";
            this.miRaidPlanerAdd.Size = new System.Drawing.Size(133, 22);
            this.miRaidPlanerAdd.Text = "Add Raid";
            this.miRaidPlanerAdd.Click += new System.EventHandler(this.miRaidPlanerAdd_Click);
            // 
            // miRaidplanerDelete
            // 
            this.miRaidplanerDelete.Name = "miRaidplanerDelete";
            this.miRaidplanerDelete.Size = new System.Drawing.Size(133, 22);
            this.miRaidplanerDelete.Text = "Delete Raid";
            // 
            // miRaidPlanerCopy
            // 
            this.miRaidPlanerCopy.Name = "miRaidPlanerCopy";
            this.miRaidPlanerCopy.Size = new System.Drawing.Size(133, 22);
            this.miRaidPlanerCopy.Text = "Copy Raid";
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.rbShowClosed);
            this.groupBoxShow.Controls.Add(this.rbShowOpen);
            this.groupBoxShow.Controls.Add(this.rbShowAll);
            this.groupBoxShow.Location = new System.Drawing.Point(6, 6);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(97, 100);
            this.groupBoxShow.TabIndex = 0;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Filter";
            // 
            // rbShowClosed
            // 
            this.rbShowClosed.AutoSize = true;
            this.rbShowClosed.Location = new System.Drawing.Point(7, 71);
            this.rbShowClosed.Name = "rbShowClosed";
            this.rbShowClosed.Size = new System.Drawing.Size(87, 17);
            this.rbShowClosed.TabIndex = 2;
            this.rbShowClosed.TabStop = true;
            this.rbShowClosed.Text = "Show Closed";
            this.rbShowClosed.UseVisualStyleBackColor = true;
            // 
            // rbShowOpen
            // 
            this.rbShowOpen.AutoSize = true;
            this.rbShowOpen.Location = new System.Drawing.Point(6, 45);
            this.rbShowOpen.Name = "rbShowOpen";
            this.rbShowOpen.Size = new System.Drawing.Size(81, 17);
            this.rbShowOpen.TabIndex = 1;
            this.rbShowOpen.TabStop = true;
            this.rbShowOpen.Text = "Show Open";
            this.rbShowOpen.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(6, 19);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(66, 17);
            this.rbShowAll.TabIndex = 0;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show All";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // tabBasicSettings
            // 
            this.tabBasicSettings.Controls.Add(this.dgBossList);
            this.tabBasicSettings.Controls.Add(this.dgContent);
            this.tabBasicSettings.Controls.Add(this.dgRaids);
            this.tabBasicSettings.Controls.Add(this.dgRaider);
            this.tabBasicSettings.Location = new System.Drawing.Point(4, 22);
            this.tabBasicSettings.Name = "tabBasicSettings";
            this.tabBasicSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicSettings.Size = new System.Drawing.Size(789, 667);
            this.tabBasicSettings.TabIndex = 1;
            this.tabBasicSettings.Text = "Basic Settings";
            this.tabBasicSettings.UseVisualStyleBackColor = true;
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
            this.dgContent.Location = new System.Drawing.Point(312, 361);
            this.dgContent.Name = "dgContent";
            this.dgContent.ReadOnly = true;
            this.dgContent.RowHeadersVisible = false;
            this.dgContent.ShowEditingIcon = false;
            this.dgContent.Size = new System.Drawing.Size(158, 145);
            this.dgContent.TabIndex = 12;
            this.dgContent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContent_CellDoubleClick_1);
            this.dgContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgRaider_MouseDown);
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
            this.dgRaids.Location = new System.Drawing.Point(3, 511);
            this.dgRaids.Name = "dgRaids";
            this.dgRaids.ReadOnly = true;
            this.dgRaids.RowHeadersVisible = false;
            this.dgRaids.ShowEditingIcon = false;
            this.dgRaids.Size = new System.Drawing.Size(780, 150);
            this.dgRaids.TabIndex = 11;
            this.dgRaids.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaids_CellDoubleClick_1);
            this.dgRaids.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgRaider_MouseDown);
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
            // dgRaider
            // 
            this.dgRaider.AllowUserToAddRows = false;
            this.dgRaider.AllowUserToDeleteRows = false;
            this.dgRaider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRaiderID,
            this.dgRaiderName});
            this.dgRaider.ContextMenuStrip = this.cmRaider;
            this.dgRaider.Location = new System.Drawing.Point(6, 6);
            this.dgRaider.Name = "dgRaider";
            this.dgRaider.ReadOnly = true;
            this.dgRaider.RowHeadersVisible = false;
            this.dgRaider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRaider.ShowEditingIcon = false;
            this.dgRaider.Size = new System.Drawing.Size(300, 500);
            this.dgRaider.TabIndex = 10;
            this.dgRaider.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRaider_CellDoubleClick_1);
            this.dgRaider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgRaider_MouseDown);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(821, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(821, 208);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(175, 23);
            this.btnSaveConfig.TabIndex = 123;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(821, 237);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(175, 23);
            this.btnLoadConfig.TabIndex = 124;
            this.btnLoadConfig.Text = "Load Config";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // dgBossList
            // 
            this.dgBossList.AllowUserToAddRows = false;
            this.dgBossList.AllowUserToDeleteRows = false;
            this.dgBossList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBossList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgBossListID,
            this.dgBossListBoss,
            this.dgBossListRaid,
            this.dgBossListDKPTeilnehmer,
            this.dgBossListDKPErsatz,
            this.dgBossListVorgaenger});
            this.dgBossList.ContextMenuStrip = this.cmBossList;
            this.dgBossList.Location = new System.Drawing.Point(312, 6);
            this.dgBossList.Name = "dgBossList";
            this.dgBossList.ReadOnly = true;
            this.dgBossList.RowHeadersVisible = false;
            this.dgBossList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBossList.ShowEditingIcon = false;
            this.dgBossList.Size = new System.Drawing.Size(471, 171);
            this.dgBossList.TabIndex = 13;
            // 
            // dgBossListID
            // 
            this.dgBossListID.HeaderText = "ID";
            this.dgBossListID.Name = "dgBossListID";
            this.dgBossListID.ReadOnly = true;
            this.dgBossListID.Width = 20;
            // 
            // dgBossListBoss
            // 
            this.dgBossListBoss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgBossListBoss.HeaderText = "Boss";
            this.dgBossListBoss.Name = "dgBossListBoss";
            this.dgBossListBoss.ReadOnly = true;
            // 
            // dgBossListRaid
            // 
            this.dgBossListRaid.HeaderText = "Raid";
            this.dgBossListRaid.Name = "dgBossListRaid";
            this.dgBossListRaid.ReadOnly = true;
            // 
            // dgBossListDKPTeilnehmer
            // 
            this.dgBossListDKPTeilnehmer.HeaderText = "DKP Teilnehmer";
            this.dgBossListDKPTeilnehmer.Name = "dgBossListDKPTeilnehmer";
            this.dgBossListDKPTeilnehmer.ReadOnly = true;
            // 
            // dgBossListDKPErsatz
            // 
            this.dgBossListDKPErsatz.HeaderText = "DKP Ersatz";
            this.dgBossListDKPErsatz.Name = "dgBossListDKPErsatz";
            this.dgBossListDKPErsatz.ReadOnly = true;
            // 
            // dgBossListVorgaenger
            // 
            this.dgBossListVorgaenger.HeaderText = "Vorgänger";
            this.dgBossListVorgaenger.Name = "dgBossListVorgaenger";
            this.dgBossListVorgaenger.ReadOnly = true;
            // 
            // cmBossList
            // 
            this.cmBossList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddBoss,
            this.miDeleteBoss});
            this.cmBossList.Name = "cmRaid";
            this.cmBossList.Size = new System.Drawing.Size(135, 48);
            // 
            // miAddBoss
            // 
            this.miAddBoss.Name = "miAddBoss";
            this.miAddBoss.Size = new System.Drawing.Size(134, 22);
            this.miAddBoss.Text = "Add Boss";
            // 
            // miDeleteBoss
            // 
            this.miDeleteBoss.Name = "miDeleteBoss";
            this.miDeleteBoss.Size = new System.Drawing.Size(134, 22);
            this.miDeleteBoss.Text = "Delete Boss";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnRefreshAll);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmRaider.ResumeLayout(false);
            this.cmRaid.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.cmContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabRaidplaner.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaidPlaner)).EndInit();
            this.cmRaidPlaner.ResumeLayout(false);
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            this.tabBasicSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBossList)).EndInit();
            this.cmBossList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshAll;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripSplitButton statusMessages;
        private System.Windows.Forms.ContextMenuStrip cmRaid;
        private System.Windows.Forms.ToolStripMenuItem miAddRaid;
        private System.Windows.Forms.ToolStripMenuItem miDeleteRaid;
        private System.Windows.Forms.ContextMenuStrip cmRaider;
        private System.Windows.Forms.ToolStripMenuItem miAddRaider;
        private System.Windows.Forms.ToolStripMenuItem miDeleteRaider;
        private System.Windows.Forms.ContextMenuStrip cmContent;
        private System.Windows.Forms.ToolStripMenuItem miAddContent;
        private System.Windows.Forms.ToolStripMenuItem miDeleteContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRaidplaner;
        private System.Windows.Forms.TabPage tabBasicSettings;
        private System.Windows.Forms.DataGridView dgContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContentName;
        private System.Windows.Forms.DataGridView dgRaids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsShortcut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidsCommentary;
        private System.Windows.Forms.DataGridView dgRaider;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaiderName;
        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.RadioButton rbShowOpen;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgRaidPlaner;
        private System.Windows.Forms.RadioButton rbShowClosed;
        private System.Windows.Forms.ContextMenuStrip cmRaidPlaner;
        private System.Windows.Forms.ToolStripMenuItem miRaidPlanerAdd;
        private System.Windows.Forms.ToolStripMenuItem miRaidplanerDelete;
        private System.Windows.Forms.ToolStripMenuItem miRaidPlanerCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtStandardInvite;
        private System.Windows.Forms.DateTimePicker dtStandardStart;
        private System.Windows.Forms.DateTimePicker dtStandardEnde;
        private System.Windows.Forms.Label lblStandardEnde;
        private System.Windows.Forms.Label lblStandardInvite;
        private System.Windows.Forms.Label lblStandardStart;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerRaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerInvite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRaidPlanerComment;
        private System.Windows.Forms.DataGridView dgBossList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListBoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListRaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListDKPTeilnehmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListDKPErsatz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBossListVorgaenger;
        private System.Windows.Forms.ContextMenuStrip cmBossList;
        private System.Windows.Forms.ToolStripMenuItem miAddBoss;
        private System.Windows.Forms.ToolStripMenuItem miDeleteBoss;
    }
}

