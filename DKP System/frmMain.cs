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
    public partial class frmMain : Form
    {

        const string sqlDatasource = "127.0.0.1";
        const string sqlDatabase = "DKP";
        const string sqlLogin = "ReadWriteUser";
        const string sqlPassword = "test";
        MySqlConnection sqlConnection;

        Dictionary<int, string> Content;
        Dictionary<int, string> RaidStatus;
        Dictionary<int, string> Raids;
        Dictionary<int, string> BossList;

        string configFilePath = Application.StartupPath + "\\config.xml";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            RefreshContent();
            RefreshRaider();
            RefreshRaids();
            RefreshRaidPlaner();
            RefreshBossList();
        }


        private void RefreshBossList()
        {
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand("Select * from BossList", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                BossList.Clear();
                dgBossList.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        BossList.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("BossName"));

                        DataGridViewRow row = dgBossList.Rows[dgBossList.Rows.Add()];
                        row.Cells[dgBossListID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgBossListBoss.Name].Value = sqlRead.GetString("BossName");
                        row.Cells[dgBossListRaid.Name].Value = Raids[sqlRead.GetInt32("RaidID")];
                        row.Cells[dgBossListDKPTeilnehmer.Name].Value = sqlRead.GetString("DKP_Teilnehmer");
                        row.Cells[dgBossListDKPErsatz.Name].Value = sqlRead.GetString("DKP_Ersatz");
                        row.Cells[dgBossListVorgaenger.Name].Value = GetSQLStringNullSuppressed(sqlRead, "BossIDVorgaenger");
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();

                foreach (DataGridViewRow row in dgBossList.Rows)
                {
                    String rowValue = row.Cells[dgBossListVorgaenger.Name].Value.ToString() ;

                    if (rowValue != "")
                    {
                        row.Cells[dgBossListVorgaenger.Name].Value = BossList[int.Parse(row.Cells[dgBossListVorgaenger.Name].Value.ToString())];
                    }
                }

                AddMessage("BossList erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("BossListaktualisierung fehlgeschlagen", true);
            }

        }

        private string GetSQLStringNullSuppressed(MySqlDataReader sqlRead, string columnName)
        {
            Object obj = sqlRead.GetValue(sqlRead.GetOrdinal(columnName));
            if (obj == null || obj.ToString() == "" )
            {return "";}
            else
            { return sqlRead.GetString(columnName); }
            
        }

        private void RefreshContent()
        {
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand("Select * from Content", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                Content.Clear();
                dgContent.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        Content.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Name"));

                        DataGridViewRow row = dgContent.Rows[dgContent.Rows.Add()];
                        row.Cells[dgContentID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgContentName.Name].Value = sqlRead.GetString("Name");
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();
                AddMessage("Content erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("Contentaktualisierung fehlgeschlagen", true);
            }

        }

        private MySqlDataReader SQLSelect(String sqlStatement) { return SQLSelect(sqlStatement, sqlConnection); }

        private MySqlDataReader SQLSelect(String sqlStatement, MySqlConnection connnection)
        {
            connnection.Open();
            MySqlCommand sqlCmd = new MySqlCommand(sqlStatement, connnection);
            MySqlDataReader sqlRead = sqlCmd.ExecuteReader();
            return sqlRead;

        }

        private void RefreshRaidStatus()
        {
            try
            {
                MySqlDataReader sqlRead = SQLSelect("Select * from RaidStatus", sqlConnection);
                RaidStatus.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        RaidStatus.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Status"));
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();
                AddMessage("RaidStatus erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("RaidStatusaktualisierung fehlgeschlagen", true);
            }

        }

        private void RefreshRaider()
        {
            try
            {

                MySqlCommand sqlCmd = new MySqlCommand("Select * from Raider", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                MySqlConnection sqlSubConnection = new MySqlConnection(sqlConnection.ConnectionString + ";Password=" + sqlPassword);
                sqlSubConnection.Open();
                MySqlCommand sqlSubCommand;
                MySqlDataReader sqlSubReader;

                dgRaider.Rows.Clear();
                dgRaider.Columns.Clear();
                DataGridViewColumn col = dgRaider.Columns[dgRaider.Columns.Add("dgRaiderID", "ID")];
                col.ReadOnly = true;
                col.Width = 20;

                col = dgRaider.Columns[dgRaider.Columns.Add("dgRaiderName", "Raider")];
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;


                foreach (KeyValuePair<int, string> content in Content)
                {
                    col = dgRaider.Columns[dgRaider.Columns.Add("dgRaider" + content.Value, content.Value)];
                    col.Width = 75;
                    col.ReadOnly = true;
                }

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        DataGridViewRow row = dgRaider.Rows[dgRaider.Rows.Add()];
                        row.Cells[dgRaiderID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgRaiderName.Name].Value = sqlRead.GetString("Name");

                        sqlSubCommand = new MySqlCommand("SELECT * FROM DKP_Points WHERE RaiderID = " + sqlRead.GetString("ID"), sqlSubConnection);
                        Console.WriteLine(sqlSubCommand.CommandText);
                        sqlSubReader = sqlSubCommand.ExecuteReader();
                        if (sqlSubReader.HasRows)
                        {
                            while (sqlSubReader.Read())
                            {
                                string cellName = "dgRaider" + Content[sqlSubReader.GetInt32("ContentID")];
                                if (row.Cells[cellName] != null)
                                {
                                    row.Cells[cellName].Value = sqlSubReader.GetString("DKPPoints");
                                }
                            }
                        }
                        sqlSubReader.Close();
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();
                sqlSubConnection.Close();
                AddMessage("Raider erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("Raideraktualisierung fehlgeschlagen", true);
            }

        }

        private void RefreshRaids()
        {
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand("Select * from Raids", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                dgRaids.Rows.Clear();
                Raids = new Dictionary<int, string>();
                Raids.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        Raids.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Name"));

                        DataGridViewRow row = dgRaids.Rows[dgRaids.Rows.Add()];
                        row.Cells[dgRaidsID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgRaidsName.Name].Value = sqlRead.GetString("Name");
                        row.Cells[dgRaidsShortcut.Name].Value = sqlRead.GetString("Shortcut");
                        if (Content.ContainsKey(sqlRead.GetInt32("Content")))
                        { row.Cells[dgRaidsContent.Name].Value = Content[sqlRead.GetInt32("Content")]; }//sqlRead.GetString("Content"); }
                        else
                        { row.Cells[dgRaidsContent.Name].Value = sqlRead.GetString("Content"); }


                        row.Cells[dgRaidsCommentary.Name].Value = sqlRead.GetString("Commentary");
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();

                AddMessage("Raids erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("Raidaktualisierung fehlgeschlagen", true);
            }
        }

        private void RefreshRaidPlaner()
        {
            //return;
            try
            {
                //MySqlCommand sqlCmd = new MySqlCommand("Select * from RaidPlaner ", sqlConnection);
                //sqlConnection.Open();
                MySqlDataReader sqlRead = SQLSelect("Select * from RaidPlaner");

                dgRaidPlaner.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        DataGridViewRow row = dgRaidPlaner.Rows[dgRaidPlaner.Rows.Add()];
                        row.Cells[dgRaidPlanerID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgRaidPlanerDate.Name].Value = sqlRead.GetDateTime("RaidDate");//.ToString("dd.MM.yyyy");
                        row.Cells[dgRaidPlanerRaid.Name].Value = Raids[sqlRead.GetInt32("RaidID")];
                        row.Cells[dgRaidPlanerContent.Name].Value = "TODO";
                        row.Cells[dgRaidPlanerStart.Name].Value = sqlRead.GetDateTime("Start").ToString("HH:mm");
                        row.Cells[dgRaidPlanerInvite.Name].Value = sqlRead.GetDateTime("Invite").ToString("HH:mm");
                        row.Cells[dgRaidPlanerEnd.Name].Value = sqlRead.GetDateTime("End").ToString("HH:mm");
                        row.Cells[dgRaidPlanerStatus.Name].Value = RaidStatus[sqlRead.GetInt32("StatusID")];
                        row.Cells[dgRaidPlanerComment.Name].Value = sqlRead.GetString("Commentary");
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();

                AddMessage("Raidplaner erfolgreich aktualisiert");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                AddMessage("Raidplaneraktualisierung fehlgeschlagen", true);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Content = new Dictionary<int, string>();
            RaidStatus = new Dictionary<int, string>();
            BossList = new Dictionary<int, string>();
            sqlConnection = new MySqlConnection("Data Source=" + sqlDatasource + "; Database=" + sqlDatabase + "; User ID=" + sqlLogin + ";Password=" + sqlPassword);
            ConfigLoad();
            RefreshRaidStatus();

            AddMessage("Connection aufgebaut");
        }

        private void AddMessage(string message) { AddMessage(message, false); }

        private void AddMessage(string message, Boolean isError)
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


        private void SQLSaveRaider(frmRaider raider)
        {
            if (raider.tbName.Text == "")
            {
                AddMessage("Raider nicht gespeichert --> Kein Name", true);
            }
            else
            {
                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";
                //if (raider.tbDKP_T1.Text == "") raider.tbDKP_T1.Text = "0";
                //if (raider.tbDKP_T2.Text == "") raider.tbDKP_T2.Text = "0";

                try
                {
                    if (raider.tbID.Text == "")
                    {
                        cmdString =
                            "INSERT INTO Raider VALUES(0, " +
                            "'" + raider.tbName.Text + "');";//, " +
                            //raider.tbDKP_T1.Text + ", " +
                            //raider.tbDKP_T2.Text + ");";
                        messageSuccess = "Raider erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE Raider SET " +
                            "Name = '" + raider.tbName.Text + "' " +
                            //"DKP_T1 = " + raider.tbDKP_T1.Text + ", " +
                            //"DKP_T2 = " + raider.tbDKP_T2.Text + " " +
                            "WHERE id = " + raider.tbID.Text + ";";
                        messageSuccess = "Raider erfolgreich upgedatet";
                    }
                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Raider nicht gespeichert --> SQL Fehler", true);
                }
                RefreshRaider();
            }
        }


        private void SQLSaveContent(frmContent content)
        {
            if (content.tbName.Text == "")
            {
                AddMessage("Content nicht gespeichert --> Kein Name", true);
            }
            else
            {
                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";

                try
                {
                    if (content.tbID.Text == "")
                    {
                        cmdString =
                            "INSERT INTO Content VALUES(0, " +
                            "'" + content.tbName.Text + "');";
                        messageSuccess = "Content erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE Content SET " +
                            "Name = '" + content.tbName.Text + "' " +
                            "WHERE ID = " + content.tbID.Text + ";";
                        messageSuccess = "Content erfolgreich upgedatet";
                    }
                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Content nicht gespeichert --> SQL Fehler", true);
                }
                RefreshContent();
            }
        }

        private int? GetKeyOfValue(Dictionary<int, String> dic, String value)
        {
            foreach (KeyValuePair<int, string> pair in dic)
            {
                if (pair.Value == value) return pair.Key;
            }
            return null;
        }

        private void SQLSaveRaid(frmRaid raid)
        {
            if (raid.tbName.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Name", true); }
            else if (raid.tbShortcut.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Shortcut", true); }
            else if (raid.cbContent.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Content", true); }
            else if (!Content.ContainsValue(raid.cbContent.Text)) { AddMessage("Raid nicht gespeichert --> Kein valider Content", true); }
            else
            {
                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";

                try
                {
                    if (raid.tbID.Text == "")
                    {
                        cmdString =
                            "INSERT INTO Raids VALUES(0, " +
                            "'" + raid.tbName.Text + "', " +
                            "'" + raid.tbShortcut.Text + "', " +
                            "'" + GetKeyOfValue(Content, raid.cbContent.Text) + "', " +
                            "'" + raid.tbCommentary.Text + "');";
                        messageSuccess = "Raid erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE Raids SET " +
                            "Name = '" + raid.tbName.Text + "', " +
                            "Shortcut = '" + raid.tbShortcut.Text + "', " +
                            "Content = '" + GetKeyOfValue(Content, raid.cbContent.Text) + "', " +
                            "Commentary = '" + raid.tbCommentary.Text + "' " +
                            "WHERE id = " + raid.tbID.Text + ";";
                        messageSuccess = "Raid erfolgreich upgedatet";
                    }
                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Raid nicht gespeichert --> SQL Fehler", true);
                }
                RefreshRaids();
            }
        }

        private void dgRaids_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRaid raid = new frmRaid(Content);
                DataGridViewRow row = dgRaids.Rows[e.RowIndex];
                raid.tbID.Text = row.Cells[dgRaidsID.Name].Value.ToString();
                raid.tbName.Text = row.Cells[dgRaidsName.Name].Value.ToString();
                raid.tbShortcut.Text = row.Cells[dgRaidsShortcut.Name].Value.ToString();
                raid.cbContent.Text = row.Cells[dgRaidsContent.Name].Value.ToString();
                raid.tbCommentary.Text = row.Cells[dgRaidsCommentary.Name].Value.ToString();
                if (raid.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveRaid(raid);

                }
            }
        }

        private void miAddRaid_Click(object sender, EventArgs e)
        {
            frmRaid raid = new frmRaid(Content);

            if (raid.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SQLSaveRaid(raid);

            }
        }

        private void miDeleteRaid_Click(object sender, EventArgs e)
        {
            int? currentRow = null;
            foreach (DataGridViewCell cell in dgRaids.SelectedCells)
            {
                if (currentRow == null) { currentRow = cell.RowIndex; }
                else if (currentRow != cell.RowIndex)
                {
                    AddMessage("Löschung abgebrochen --> Es kann nur eine Zeile auf einmal gelöscht werden.", true);
                    return;
                }
            }
            if (currentRow != null)
            {
                DataGridViewRow row = dgRaids.Rows[(int)currentRow];

                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";
                try
                {
                    cmdString =
                             "DELETE FROM Raids WHERE " +
                             "ID = " + row.Cells[dgRaidsID.Name].Value.ToString();
                    messageSuccess = "Raid erfolgreich gelöscht";

                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Raid nicht gelöscht --> SQL Fehler", true);
                }
                RefreshRaids();
            }

        }

        private void miAddRaider_Click(object sender, EventArgs e)
        {
            frmRaider raider = new frmRaider();

            if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SQLSaveRaider(raider);

            }
        }

        private void miDeleteRaider_Click(object sender, EventArgs e)
        {
            int? currentRow = null;
            foreach (DataGridViewCell cell in dgRaider.SelectedCells)
            {
                if (currentRow == null) { currentRow = cell.RowIndex; }
                else if (currentRow != cell.RowIndex)
                {
                    AddMessage("Löschung abgebrochen --> Es kann nur eine Zeile auf einmal gelöscht werden.", true);
                    return;
                }
            }
            if (currentRow != null)
            {
                DataGridViewRow row = dgRaider.Rows[(int)currentRow];

                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";
                try
                {
                    cmdString =
                             "DELETE FROM Raider WHERE " +
                             "ID = " + row.Cells[dgRaiderID.Name].Value.ToString();
                    messageSuccess = "Raider erfolgreich gelöscht";

                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Raider nicht gelöscht --> SQL Fehler", true);
                }
                RefreshRaider();
            }
        }

        private void dgRaider_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRaider raider = new frmRaider();
                DataGridViewRow row = dgRaider.Rows[e.RowIndex];
                raider.tbID.Text = row.Cells[dgRaiderID.Name].Value.ToString();
                raider.tbName.Text = row.Cells[dgRaiderName.Name].Value.ToString();
                //raider.tbDKP_T1.Text = row.Cells[dgRaiderDKP_T1.Name].Value.ToString();
                //raider.tbDKP_T2.Text = row.Cells[dgRaiderDKP_T2.Name].Value.ToString();
                if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveRaider(raider);

                }
            }
        }

        private void miAddContent_Click(object sender, EventArgs e)
        {
            frmContent content = new frmContent();

            if (content.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SQLSaveContent(content);

            }
        }

        private void miDeleteContent_Click(object sender, EventArgs e)
        {
            int? currentRow = null;
            foreach (DataGridViewCell cell in dgContent.SelectedCells)
            {
                if (currentRow == null) { currentRow = cell.RowIndex; }
                else if (currentRow != cell.RowIndex)
                {
                    AddMessage("Löschung abgebrochen --> Es kann nur eine Zeile auf einmal gelöscht werden.", true);
                    return;
                }
            }
            if (currentRow != null)
            {
                DataGridViewRow row = dgContent.Rows[(int)currentRow];

                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";
                try
                {
                    cmdString =
                             "DELETE FROM Content WHERE " +
                             "ID = " + row.Cells[dgContentID.Name].Value.ToString();
                    messageSuccess = "Content erfolgreich gelöscht";

                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Content nicht gelöscht --> SQL Fehler", true);
                }
                RefreshContent();
            }
        }

        private void dgContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                frmContent content = new frmContent();
                DataGridViewRow row = dgContent.Rows[e.RowIndex];
                content.tbID.Text = row.Cells[dgContentID.Name].Value.ToString();
                content.tbName.Text = row.Cells[dgContentName.Name].Value.ToString();
                //raider.tbDKP_T1.Text = row.Cells[dgRaiderDKP_T1.Name].Value.ToString();
                //raider.tbDKP_T2.Text = row.Cells[dgRaiderDKP_T2.Name].Value.ToString();
                if (content.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveContent(content);

                }
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            ConfigSave();

        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            ConfigLoad();
        }

        private void XMLAddNode(XmlNode rootNode, String name, String innerText)
        {
            XmlDocument xmlDoc = rootNode.OwnerDocument;
            XmlNode xmlChild = xmlDoc.CreateElement(name);
            xmlChild.InnerText = innerText;
            rootNode.AppendChild(xmlChild);
        }

        private void ConfigSave()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode xmlDocNode = xmlDoc.CreateElement("DKP_System");

            XmlNode xmlRoot;
            
            xmlRoot = xmlDoc.CreateElement("Standard");
            XMLAddNode(xmlRoot, "InviteZeit", dtStandardInvite.Value.ToString());
            XMLAddNode(xmlRoot, "StartZeit", dtStandardStart.Value.ToString());
            XMLAddNode(xmlRoot, "EndeZeit", dtStandardEnde.Value.ToString());
            xmlDocNode.AppendChild(xmlRoot);

            

            //xmlChild = xmlDoc.CreateElement("InviteZeit");
            //xmlChild.InnerText = dtStandardInvite.Value.ToString();
            //xmlRoot.AppendChild(xmlChild);

            //xmlChild = xmlDoc.CreateElement("StartZeit");
            //xmlChild.InnerText = dtStandardStart.Value.ToString();
            //xmlRoot.AppendChild(xmlChild);

            //xmlChild = xmlDoc.CreateElement("EndeZeit");
            //xmlChild.InnerText = dtStandardEnde.Value.ToString();
            //xmlRoot.AppendChild(xmlChild);


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

        private void miRaidPlanerAdd_Click(object sender, EventArgs e)
        {
            frmRaidPlaner raidPlaner = new frmRaidPlaner(Raids);


            raidPlaner.dtStart.Value = dtStandardStart.Value;
            raidPlaner.dtEnde.Value = dtStandardEnde.Value;
            raidPlaner.dtInvite.Value = dtStandardInvite.Value;


            if (raidPlaner.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SQLSaveRaidPlaner(raidPlaner);

            }
        }

        private void SQLSaveRaidPlaner(frmRaidPlaner raidPlaner)
        {
            if (raidPlaner.cbRaid.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Raid ausgewählt", true); }
            else if (raidPlaner.dtDatum.Value.ToString() == "") { AddMessage("Raid nicht gespeichert --> Kein Datum", true); }
            else if (raidPlaner.dtStart.Value.ToString() == "") { AddMessage("Raid nicht gespeichert --> Keine Startzeit", true); }
            else if (!Raids.ContainsValue(raidPlaner.cbRaid.Text)) { AddMessage("Raid nicht gespeichert --> Kein valider Raid", true); }
            else
            {
                MySqlCommand sqlCmd;
                string cmdString = "";
                sqlConnection.Open();
                string messageSuccess = "";

                try
                {
                    if (raidPlaner.tbID.Text == "")
                    {
                        cmdString =
                            "INSERT INTO RaidPlaner VALUES(0, " +
                            "" + GetKeyOfValue(Raids, raidPlaner.cbRaid.Text) + ", " +
                            "'" + raidPlaner.dtDatum.Value.ToString("yyyy-MM-dd 00:00:00") + "', " +
                            "'" + raidPlaner.dtInvite.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                            "'" + raidPlaner.dtStart.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                            "'" + raidPlaner.dtEnde.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                            "1, " +
                            "'" + raidPlaner.tbCommentary.Text + "');";
                        messageSuccess = "Raidplan erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE RaidPlaner SET " +
                            "RaidID = " + GetKeyOfValue(Raids, raidPlaner.cbRaid.Text) + ", " +
                            "RaidDate = '" + raidPlaner.dtDatum.Value.ToString("dd.MM.yyy") + "', " +
                            "Invite = '" + raidPlaner.dtDatum.Value.ToString("HH:mm") + "', " +
                            "Start = '" + raidPlaner.dtDatum.Value.ToString("HH:mm") + "', " +
                            "End = '" + raidPlaner.dtDatum.Value.ToString("HH:mm") + "', " +
                            "RaidID = " + raidPlaner.tbStatus.Text + ", " +
                            "Commentary = '" + raidPlaner.tbCommentary.Text + "' " +
                            "WHERE ID = " + raidPlaner.tbID.Text + ";";
                        messageSuccess = "Raidplan erfolgreich upgedatet";
                    }
                    Console.WriteLine(cmdString);
                    sqlCmd = new MySqlCommand(cmdString, sqlConnection);
                    sqlCmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    AddMessage(messageSuccess);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    AddMessage("Raidplan nicht gespeichert --> SQL Fehler", true);
                }
                RefreshRaids();
            }
        }

        private void dgRaider_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRaider raider = new frmRaider();
                DataGridViewRow row = dgRaider.Rows[e.RowIndex];
                raider.tbID.Text = row.Cells[dgRaiderID.Name].Value.ToString();
                raider.tbName.Text = row.Cells[dgRaiderName.Name].Value.ToString();
                //raider.tbDKP_T1.Text = row.Cells[dgRaiderDKP_T1.Name].Value.ToString();
                //raider.tbDKP_T2.Text = row.Cells[dgRaiderDKP_T2.Name].Value.ToString();
                if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveRaider(raider);

                }
            }
        }

        private void dgContent_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmContent content = new frmContent();
                DataGridViewRow row = dgContent.Rows[e.RowIndex];
                content.tbID.Text = row.Cells[dgContentID.Name].Value.ToString();
                content.tbName.Text = row.Cells[dgContentName.Name].Value.ToString();
                //raider.tbDKP_T1.Text = row.Cells[dgRaiderDKP_T1.Name].Value.ToString();
                //raider.tbDKP_T2.Text = row.Cells[dgRaiderDKP_T2.Name].Value.ToString();
                if (content.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveContent(content);

                }
            }
        }

        private void dgRaids_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmRaid raid = new frmRaid(Content);
                DataGridViewRow row = dgRaids.Rows[e.RowIndex];
                raid.tbID.Text = row.Cells[dgRaidsID.Name].Value.ToString();
                raid.tbName.Text = row.Cells[dgRaidsName.Name].Value.ToString();
                raid.tbShortcut.Text = row.Cells[dgRaidsShortcut.Name].Value.ToString();
                raid.cbContent.Text = row.Cells[dgRaidsContent.Name].Value.ToString();
                raid.tbCommentary.Text = row.Cells[dgRaidsCommentary.Name].Value.ToString();
                if (raid.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveRaid(raid);

                }
            }
        }

        private void dgRaidPlaner_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgRaider_MouseDown(object sender, MouseEventArgs e)
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
