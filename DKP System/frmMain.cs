using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;


namespace DKP_System
{
    internal partial class frmMain : Form
    {
        private SQL sql;

        internal Dictionary<int, string> Content;
        internal Dictionary<int, string> RaidStatus;
        internal Dictionary<int, string> Raids;
        internal Dictionary<int, string> BossList;

        string configFilePath = Application.StartupPath + "\\config.xml";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            sql.Refresh(SQL.LISTNAMES.RaidStatus);
            sql.Refresh(SQL.LISTNAMES.Content);

            sql.Refresh(SQL.LISTNAMES.Raider);
            sql.Refresh(SQL.LISTNAMES.Raids);
            sql.Refresh(SQL.LISTNAMES.BossList);

            sql.Refresh(SQL.LISTNAMES.RaidPlaner);
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.sql = new SQL(this);
            Content = new Dictionary<int, string>();
            RaidStatus = new Dictionary<int, string>();
            BossList = new Dictionary<int, string>();
            Raids = new Dictionary<int, string>();

            ConfigLoad();
            sql.Refresh(SQL.LISTNAMES.RaidStatus);

            AddMessage("Connection aufgebaut");
        }

        internal void AddMessage(string message) { AddMessage(message, false); }
        internal void AddMessage(string message, Boolean isError)
        {
            const int messageCount = 10;
            message = DateTime.Now.ToString() + " - " + message;
            statusMessages.Text = message;
            if (statusMessages.DropDownItems.Count >= messageCount)
            { statusMessages.DropDownItems.RemoveAt(0); }

            ToolStripItem entry = statusMessages.DropDownItems.Add(message);
            if (isError)
            { entry.BackColor = Color.IndianRed; }
            else
            { entry.BackColor = Color.LightGreen; }


        }

        internal int? GetKeyOfValue(Dictionary<int, String> dic, String value)
        {
            foreach (KeyValuePair<int, string> pair in dic)
            {
                if (pair.Value == value) return pair.Key;
            }
            return null;
        }

        private int? GetCurrentRow(DataGridView dgView)
        {
            int? currentRow = null;
            foreach (DataGridViewCell cell in dgRaids.SelectedCells)
            {
                if (currentRow == null) { currentRow = cell.RowIndex; }
                else if (currentRow != cell.RowIndex) { return null; }
            }
            return currentRow;
        }


        #region Add Something
        private void miAddRaid_Click(object sender, EventArgs e)
        {
            frmRaid raid = new frmRaid(Content);
            if (raid.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { sql.Save(SQL.LISTNAMES.Raids, raid); }
        }

        private void miAddRaider_Click(object sender, EventArgs e)
        {
            frmRaider raider = new frmRaider();

            if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                sql.Save(SQL.LISTNAMES.Raider, raider);

            }
        }
        
        private void miAddContent_Click(object sender, EventArgs e)
        {
            frmContent content = new frmContent();

            if (content.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                sql.Save(SQL.LISTNAMES.Content, content);

            }
        }

        private void miBossListAdd_Click(object sender, EventArgs e)
        {
            //frmBossList bossList = new frmBossList();
            
            //if (bossList.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { sql.Save(SQL.LISTNAMES.BossList, bossList); }
        }

        private void miRaidPlanerAdd_Click(object sender, EventArgs e)
        {
            frmRaidPlaner raidPlaner = new frmRaidPlaner(Raids);
            raidPlaner.dtStart.Value = dtStandardStart.Value;
            raidPlaner.dtEnde.Value = dtStandardEnde.Value;
            raidPlaner.dtInvite.Value = dtStandardInvite.Value;

            if (raidPlaner.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { sql.Save(SQL.LISTNAMES.RaidPlaner, raidPlaner); }
        }
        #endregion


        #region Delete Something
        private void miDeleteRaid_Click(object sender, EventArgs e)
        {
            int? currentRow = GetCurrentRow(dgRaids);
            if (currentRow != null)
            {
                DataGridViewRow row = dgRaids.Rows[(int)currentRow];
                sql.DeleteFromTable("Raids", "ID", row.Cells[dgRaidsID.Name].Value.ToString(), SQL.LISTNAMES.Raids);
            }            
        }

        private void miDeleteRaider_Click(object sender, EventArgs e)
        {
            int? currentRow = GetCurrentRow(dgRaider);
            if (currentRow != null)
            {
                DataGridViewRow row = dgRaider.Rows[(int)currentRow];
                sql.DeleteFromTable("Raider", "ID", row.Cells[dgRaiderID.Name].Value.ToString(), SQL.LISTNAMES.Raider);
            }   
        }

        private void miDeleteContent_Click(object sender, EventArgs e)
        {
            int? currentRow = GetCurrentRow(dgContent);
            if (currentRow != null)
            {
                DataGridViewRow row = dgContent.Rows[(int)currentRow];
                sql.DeleteFromTable("Content", "ID", row.Cells[dgContentID.Name].Value.ToString(), SQL.LISTNAMES.Content);
            }   
        }

        private void miDeleteBossList_Click(object sender, EventArgs e)
        {
            int? currentRow = GetCurrentRow(dgBossList);
            if (currentRow != null)
            {
                DataGridViewRow row = dgBossList.Rows[(int)currentRow];
                sql.DeleteFromTable("BossList", "ID", row.Cells[dgBossListID.Name].Value.ToString(), SQL.LISTNAMES.BossList);
            }
        }

        private void miDeleteRaidPlaner_Click(object sender, EventArgs e)
        {
            int? currentRow = GetCurrentRow(dgRaidPlaner);
            if (currentRow != null)
            {
                DataGridViewRow row = dgRaidPlaner.Rows[(int)currentRow];
                sql.DeleteFromTable("RaidPlaner", "ID", row.Cells[dgRaidPlanerID.Name].Value.ToString(), SQL.LISTNAMES.RaidPlaner);
            }
        }
        #endregion

        
        #region Config Stuff
        private void ConfigSave()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode xmlDocNode = xmlDoc.CreateElement("DKP_System");

            XmlNode xmlRoot;

            xmlRoot = xmlDoc.CreateElement("Standard");
            ConfigXMLAddNode(xmlRoot, "InviteZeit", dtStandardInvite.Value.ToString());
            ConfigXMLAddNode(xmlRoot, "StartZeit", dtStandardStart.Value.ToString());
            ConfigXMLAddNode(xmlRoot, "EndeZeit", dtStandardEnde.Value.ToString());
            xmlDocNode.AppendChild(xmlRoot);

            xmlDoc.AppendChild(xmlDocNode);
            Console.WriteLine("ConfigFilePath = " + configFilePath);
            xmlDoc.Save(configFilePath);

        }

        private void ConfigLoad()
        {
            if (System.IO.File.Exists(configFilePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNode xmlDocNode = xmlDoc.GetElementsByTagName("DKP_System")[0];

                foreach (XmlNode xmlRoot in xmlDocNode.ChildNodes)
                {
                    foreach (XmlNode xmlChild in xmlRoot.ChildNodes)
                    {
                        switch (xmlRoot.Name + "." + xmlChild.Name)
                        {
                            //15.01.2014 12:27:26 Format = dd.MM.yyyy hh:mm:ss
                            case "Standard.InviteZeit":
                                dtStandardInvite.Value = DateTime.ParseExact(xmlChild.InnerText, "dd.MM.yyyy HH:mm:ss", null);
                                break;
                            case "Standard.StartZeit":
                                dtStandardStart.Value = DateTime.ParseExact(xmlChild.InnerText, "dd.MM.yyyy HH:mm:ss", null);
                                break;
                            case "Standard.EndeZeit":
                                dtStandardEnde.Value = DateTime.ParseExact(xmlChild.InnerText, "dd.MM.yyyy HH:mm:ss", null);
                                break;

                        }
                    }
                }

            }
        }

        private void ConfigXMLAddNode(XmlNode rootNode, String name, String innerText)
        {
            XmlDocument xmlDoc = rootNode.OwnerDocument;
            XmlNode xmlChild = xmlDoc.CreateElement(name);
            xmlChild.InnerText = innerText;
            rootNode.AppendChild(xmlChild);
        }
        #endregion


        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigSave();

        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            ConfigLoad();
        }
        
        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;

                if (dgv.Name == dgRaider.Name)
                {
                    frmRaider raider = new frmRaider();
                    DataGridViewRow row = dgRaider.Rows[e.RowIndex];
                    raider.tbID.Text = row.Cells[dgRaiderID.Name].Value.ToString();
                    raider.tbName.Text = row.Cells[dgRaiderName.Name].Value.ToString();
                    if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        sql.Save(SQL.LISTNAMES.Raider, raider);

                    }
                }
                else if (dgv.Name == dgRaids.Name)
                {
                    frmRaid raid = new frmRaid(Content);
                    DataGridViewRow row = dgRaids.Rows[e.RowIndex];
                    raid.tbID.Text = row.Cells[dgRaidsID.Name].Value.ToString();
                    raid.tbName.Text = row.Cells[dgRaidsName.Name].Value.ToString();
                    raid.tbShortcut.Text = row.Cells[dgRaidsShortcut.Name].Value.ToString();
                    raid.cbContent.Text = row.Cells[dgRaidsContent.Name].Value.ToString();
                    raid.tbCommentary.Text = row.Cells[dgRaidsCommentary.Name].Value.ToString();
                    if (raid.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { sql.Save(SQL.LISTNAMES.Raids, raid); }
                }
                else if (dgv.Name == dgContent.Name)
                {
                    frmContent content = new frmContent();
                    DataGridViewRow row = dgContent.Rows[e.RowIndex];
                    content.tbID.Text = row.Cells[dgContentID.Name].Value.ToString();
                    content.tbName.Text = row.Cells[dgContentName.Name].Value.ToString();
                    if (content.ShowDialog(this) == System.Windows.Forms.DialogResult.OK){sql.Save(SQL.LISTNAMES.Content, content);}                    
                }
                else if (dgv.Name == dgBossList.Name)
                {
                    frmRaider raider = new frmRaider();
                }
                else if (dgv.Name == dgRaidPlaner.Name)
                {
                    frmRaidPlaner raidPlaner = new frmRaidPlaner(Raids);
                    DataGridViewRow row = dgRaidPlaner.Rows[e.RowIndex];
                    raidPlaner.tbID.Text = row.Cells[dgRaidPlanerID.Name].Value.ToString();
                    raidPlaner.tbStatus.Text = row.Cells[dgRaidPlanerStatus.Name].Value.ToString();
                    raidPlaner.tbStatusID.Text = GetKeyOfValue(RaidStatus,row.Cells[dgRaidPlanerStatus.Name].Value.ToString()).ToString();
                    raidPlaner.cbRaid.Text = row.Cells[dgRaidPlanerRaid.Name].Value.ToString();

                    raidPlaner.dtDatum.Value = DateTime.Parse(row.Cells[dgRaidPlanerDate.Name].Value.ToString());
                    raidPlaner.dtInvite.Value = DateTime.Parse(row.Cells[dgRaidPlanerInvite.Name].Value.ToString());
                    raidPlaner.dtStart.Value = DateTime.Parse(row.Cells[dgRaidPlanerStart.Name].Value.ToString());
                    raidPlaner.dtEnde.Value = DateTime.Parse(row.Cells[dgRaidPlanerEnd.Name].Value.ToString());

                    raidPlaner.tbCommentary.Text = row.Cells[dgRaidPlanerComment.Name].Value.ToString();

                    if (raidPlaner.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) { sql.Save(SQL.LISTNAMES.RaidPlaner, raidPlaner); }                    

                    //"'" + raidPlaner.dtDatum.Value.ToString("yyyy-MM-dd 00:00:00") + "', " +
                    //"'" + raidPlaner.dtInvite.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    //"'" + raidPlaner.dtStart.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    //"'" + raidPlaner.dtEnde.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                }
            }
        }

        private void DataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.Button != MouseButtons.Right) return;
            dgv.ClearSelection();
            DataGridView.HitTestInfo hti = dgv.HitTest(e.X, e.Y);
            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgv.Rows[dgv[hti.ColumnIndex, hti.RowIndex].RowIndex].Selected = true;
            }
        }


    }
}
