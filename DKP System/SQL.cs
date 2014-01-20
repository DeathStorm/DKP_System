using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace DKP_System
{
    internal class SQL
    {
        internal enum LISTNAMES { BossList, Content, RaidStatus, Raider, Raids, RaidPlaner };

        private frmMain main;

        MySqlConnection sqlConnection;
        const string sqlDatasource = "127.0.0.1";
        const string sqlDatabase = "DKP";
        const string sqlLogin = "ReadWriteUser";
        const string sqlPassword = "test";
        
        internal SQL(frmMain main)
        {
            this.main = main;
            sqlConnection = new MySqlConnection("Data Source=" + sqlDatasource + "; Database=" + sqlDatabase + "; User ID=" + sqlLogin + ";Password=" + sqlPassword);
        }

        internal void Refresh(LISTNAMES listName)
        {
            try
            {
                MySqlDataReader sqlRead = SQLSelect("Select * from " + listName.ToString());
                MySqlDataReader sqlSubRead = null;
                DataGridViewRow row;

                RefreshClearLists(listName);

                RefreshAdditionalTasksBefore(listName);

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        switch (listName)
                        {
                            case LISTNAMES.BossList:
                                main.BossList.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("BossName"));

                                row = main.dgBossList.Rows[main.dgBossList.Rows.Add()];
                                row.Cells[main.dgBossListID.Name].Value = sqlRead.GetString("ID");
                                row.Cells[main.dgBossListBoss.Name].Value = sqlRead.GetString("BossName");
                                row.Cells[main.dgBossListRaid.Name].Value = main.Raids[sqlRead.GetInt32("RaidID")];
                                row.Cells[main.dgBossListDKPTeilnehmer.Name].Value = sqlRead.GetString("DKP_Teilnehmer");
                                row.Cells[main.dgBossListDKPErsatz.Name].Value = sqlRead.GetString("DKP_Ersatz");
                                row.Cells[main.dgBossListVorgaenger.Name].Value = GetSQLStringNullSuppressed(sqlRead, "BossIDVorgaenger");
                                break;
                            case LISTNAMES.Content:
                                main.Content.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Name"));

                                row = main.dgContent.Rows[main.dgContent.Rows.Add()];
                                row.Cells[main.dgContentID.Name].Value = sqlRead.GetString("ID");
                                row.Cells[main.dgContentName.Name].Value = sqlRead.GetString("Name");
                                break;
                            case LISTNAMES.RaidStatus:
                                main.RaidStatus.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Status"));
                                break;
                            case LISTNAMES.Raider:
                                row = main.dgRaider.Rows[main.dgRaider.Rows.Add()];
                                row.Cells[main.dgRaiderID.Name].Value = sqlRead.GetString("ID");
                                row.Cells[main.dgRaiderName.Name].Value = sqlRead.GetString("Name");

                                sqlSubRead = SQLSelect("SELECT * FROM DKP_Points WHERE RaiderID = " + sqlRead.GetString("ID"), new MySqlConnection(sqlConnection.ConnectionString + ";Password=" + sqlPassword));
                                if (sqlSubRead.HasRows)
                                {
                                    while (sqlSubRead.Read())
                                    {
                                        string cellName = "dgRaider" + main.Content[sqlSubRead.GetInt32("ContentID")];
                                        if (row.Cells[cellName] != null) { row.Cells[cellName].Value = sqlSubRead.GetString("DKPPoints"); }
                                    }
                                }
                                sqlSubRead.Close();
                                break;
                            case LISTNAMES.Raids:
                                main.Raids.Add(sqlRead.GetInt32("ID"), sqlRead.GetString("Name"));

                                row = main.dgRaids.Rows[main.dgRaids.Rows.Add()];
                                row.Cells[main.dgRaidsID.Name].Value = sqlRead.GetString("ID");
                                row.Cells[main.dgRaidsName.Name].Value = sqlRead.GetString("Name");
                                row.Cells[main.dgRaidsShortcut.Name].Value = sqlRead.GetString("Shortcut");
                                if (main.Content.ContainsKey(sqlRead.GetInt32("Content")))
                                { row.Cells[main.dgRaidsContent.Name].Value = main.Content[sqlRead.GetInt32("Content")]; }//sqlRead.GetString("Content"); }
                                else
                                { row.Cells[main.dgRaidsContent.Name].Value = sqlRead.GetString("Content"); }
                                row.Cells[main.dgRaidsCommentary.Name].Value = sqlRead.GetString("Commentary");

                                break;
                            case LISTNAMES.RaidPlaner:
                                row = main.dgRaidPlaner.Rows[main.dgRaidPlaner.Rows.Add()];
                                row.Cells[main.dgRaidPlanerID.Name].Value = sqlRead.GetString("ID");
                                row.Cells[main.dgRaidPlanerDate.Name].Value = sqlRead.GetDateTime("RaidDate");//.ToString("dd.MM.yyyy");
                                row.Cells[main.dgRaidPlanerRaid.Name].Value = main.Raids[sqlRead.GetInt32("RaidID")];
                                row.Cells[main.dgRaidPlanerContent.Name].Value = "TODO";
                                row.Cells[main.dgRaidPlanerStart.Name].Value = sqlRead.GetDateTime("Start").ToString("HH:mm");
                                row.Cells[main.dgRaidPlanerInvite.Name].Value = sqlRead.GetDateTime("Invite").ToString("HH:mm");
                                row.Cells[main.dgRaidPlanerEnd.Name].Value = sqlRead.GetDateTime("End").ToString("HH:mm");
                                row.Cells[main.dgRaidPlanerStatus.Name].Value = main.RaidStatus[sqlRead.GetInt32("StatusID")];
                                row.Cells[main.dgRaidPlanerComment.Name].Value = sqlRead.GetString("Commentary");
                                break;

                        }

                    }

                }
                sqlRead.Close();
                sqlConnection.Close();

                RefreshAdditionalTasksAfter(listName);

                main.AddMessage("Liste erfolgreich aktualisiert (" + listName.ToString() + ")");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                main.AddMessage("Aktualisierung fehlgeschlagen (" + listName.ToString() + ")", true);
            }
        }

        private void RefreshClearLists(LISTNAMES listName)
        {
            switch (listName)
            {
                case LISTNAMES.BossList:
                    main.BossList.Clear();
                    main.dgBossList.Rows.Clear();
                    break;
                case LISTNAMES.Content:
                    main.Content.Clear();
                    main.dgContent.Rows.Clear();
                    break;
                case LISTNAMES.RaidStatus:
                    main.RaidStatus.Clear();
                    break;
                case LISTNAMES.Raider:
                    main.dgRaider.Rows.Clear();
                    main.dgRaider.Columns.Clear();
                    break;
                case LISTNAMES.Raids:
                    main.Raids.Clear();
                    main.dgRaids.Rows.Clear();
                    break;
                case LISTNAMES.RaidPlaner:
                    main.dgRaidPlaner.Rows.Clear();
                    break;

            }
        }

        private void RefreshAdditionalTasksBefore(LISTNAMES listName)
        {
            switch (listName)
            {
                case LISTNAMES.Raider:
                    DataGridViewColumn col = main.dgRaider.Columns[main.dgRaider.Columns.Add("dgRaiderID", "ID")];
                    col.ReadOnly = true;
                    col.Width = 20;

                    col = main.dgRaider.Columns[main.dgRaider.Columns.Add("dgRaiderName", "Raider")];
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.ReadOnly = true;
                    foreach (KeyValuePair<int, string> content in main.Content)
                    {
                        col = main.dgRaider.Columns[main.dgRaider.Columns.Add("dgRaider" + content.Value, content.Value)];
                        col.Width = 75;
                        col.ReadOnly = true;
                    }
                    break;
            }

        }

        private void RefreshAdditionalTasksAfter(LISTNAMES listName)
        {
            switch (listName)
            {
                case LISTNAMES.BossList:
                    foreach (DataGridViewRow row in main.dgBossList.Rows)
                    {
                        String rowValue = row.Cells[main.dgBossListVorgaenger.Name].Value.ToString();
                        if (rowValue != "") { row.Cells[main.dgBossListVorgaenger.Name].Value = main.BossList[int.Parse(row.Cells[main.dgBossListVorgaenger.Name].Value.ToString())]; }
                    }
                    break;
            }

        }

        internal void Save(LISTNAMES listName, Form form)
        {
            if (SaveIsFormValidate(listName, form))
            {
                try
                {
                    sqlConnection.Open();

                    String sqlCMDString = "";
                    switch (listName)
                    {
                        case LISTNAMES.Raider:
                            sqlCMDString = SaveGetSQLCMD_Raider((frmRaider)form);
                            break;
                        case LISTNAMES.Content:
                            sqlCMDString = SaveGetSQLCMD_Content((frmContent)form);
                            break;
                        case LISTNAMES.Raids:
                            sqlCMDString = SaveGetSQLCMD_Raid((frmRaid)form);
                            break;
                        case LISTNAMES.RaidPlaner:
                            sqlCMDString = SaveGetSQLCMD_RaidPlaner((frmRaidPlaner)form);
                            break;
                    }

                    Console.WriteLine("SQL String \n" + sqlCMDString);
                    MySqlCommand sqlCMD = new MySqlCommand(sqlCMDString, sqlConnection);
                    sqlCMD.ExecuteNonQuery();
                    sqlConnection.Close();

                    Refresh(listName);

                    main.AddMessage("SQL Eintrag erfolgreich gespeichert (" + listName.ToString() + ")", false);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                    main.AddMessage("SQL Eintrag nicht gespeichert (" + listName.ToString() + ")--> SQL Fehler", true);
                }
            }
        }

        private Boolean SaveIsFormValidate(LISTNAMES listName, Form form)
        {
            switch (listName)
            {
                case LISTNAMES.Raider:
                    frmRaider formRaider = (frmRaider)form;
                    if (formRaider.tbName.Text == "") return false;
                    break;
                case LISTNAMES.Content:
                    frmContent formContent = (frmContent)form;
                    if (formContent.tbName.Text == "") return false;
                    break;
                case LISTNAMES.Raids:
                    frmRaid formRaid = (frmRaid)form;
                    if (formRaid.tbName.Text == "") return false;
                    if (formRaid.tbShortcut.Text == "") return false;
                    if (formRaid.cbContent.Text == "") return false;
                    if (!main.Content.ContainsValue(formRaid.cbContent.Text)) return false;
                    break;
                case LISTNAMES.RaidPlaner:
                    frmRaidPlaner raidPlaner = (frmRaidPlaner)form;
                    if (raidPlaner.cbRaid.Text == "") return false;
                    if (raidPlaner.dtDatum.Value.ToString() == "") return false;
                    if (raidPlaner.dtStart.Value.ToString() == "") return false;
                    if (!main.Raids.ContainsValue(raidPlaner.cbRaid.Text)) return false;
                    break;
            }
            return true;
        }

        private String SaveGetSQLCMD_Raider(frmRaider raider)
        {
            if (raider.tbID.Text == "")
            {
                return "INSERT INTO Raider VALUES(0, " +
                    "'" + raider.tbName.Text + "');";
            }
            else
            {
                return "UPDATE Raider SET " +
                    "Name = '" + raider.tbName.Text + "' " +
                    "WHERE id = " + raider.tbID.Text + ";";
            }
        }

        private String SaveGetSQLCMD_Content(frmContent content)
        {
            if (content.tbID.Text == "")
            {
                return "INSERT INTO Content VALUES(0, " +
                    "'" + content.tbName.Text + "');";
            }
            else
            {
                return "UPDATE Content SET " +
                    "Name = '" + content.tbName.Text + "' " +
                    "WHERE ID = " + content.tbID.Text + ";";
            }
        }

        private String SaveGetSQLCMD_Raid(frmRaid raid)
        {
            if (raid.tbID.Text == "")
            {
                return "INSERT INTO Raids VALUES(0, " +
                    "'" + raid.tbName.Text + "', " +
                    "'" + raid.tbShortcut.Text + "', " +
                    "'" + main.GetKeyOfValue(main.Content, raid.cbContent.Text) + "', " +
                    "'" + raid.tbCommentary.Text + "');";
            }
            else
            {
                return "UPDATE Raids SET " +
                    "Name = '" + raid.tbName.Text + "', " +
                    "Shortcut = '" + raid.tbShortcut.Text + "', " +
                    "Content = '" + main.GetKeyOfValue(main.Content, raid.cbContent.Text) + "', " +
                    "Commentary = '" + raid.tbCommentary.Text + "' " +
                    "WHERE id = " + raid.tbID.Text + ";";
            }
        }

        private String SaveGetSQLCMD_RaidPlaner(frmRaidPlaner raidPlaner)
        {
            if (raidPlaner.tbID.Text == "")
            {
                return "INSERT INTO RaidPlaner VALUES(0, " +
                    "" + main.GetKeyOfValue(main.Raids, raidPlaner.cbRaid.Text) + ", " +
                    "'" + raidPlaner.dtDatum.Value.ToString("yyyy-MM-dd 00:00:00") + "', " +
                    "'" + raidPlaner.dtInvite.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "'" + raidPlaner.dtStart.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "'" + raidPlaner.dtEnde.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "1, " +
                    "'" + raidPlaner.tbCommentary.Text + "');";
            }
            else
            {
                return "UPDATE RaidPlaner SET " +
                    "RaidID = " + main.GetKeyOfValue(main.Raids, raidPlaner.cbRaid.Text) + ", " +
                    "RaidDate = '" + raidPlaner.dtDatum.Value.ToString("yyyy-MM-dd 00:00:00") + "', " +
                    "Invite = '" + raidPlaner.dtInvite.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "Start = '" + raidPlaner.dtStart.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "End = '" + raidPlaner.dtEnde.Value.ToString("2013-01-01 HH:mm:00") + "', " +
                    "StatusID = " + raidPlaner.tbStatusID.Text + ", " +
                    "Commentary = '" + raidPlaner.tbCommentary.Text + "' " +
                    "WHERE ID = " + raidPlaner.tbID.Text + ";";
            }
        }

        internal void DeleteFromTable(String tableName, String idColumn, String id,LISTNAMES listName)
        {
            try
            {
                sqlConnection.Open();

                String sqlCMDString = "Delete * from "+tableName+" where "+idColumn+" = "+id+";";

                //Console.WriteLine("SQL String \n" + sqlCMDString);
                MySqlCommand sqlCMD = new MySqlCommand(sqlCMDString, sqlConnection);
                sqlCMD.ExecuteNonQuery();
                sqlConnection.Close();

                Refresh(listName);

                main.AddMessage("SQL Eintrag erfolgreich gelöscht (" + listName.ToString() + ")", false);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (sqlConnection.State != System.Data.ConnectionState.Closed) sqlConnection.Close();
                main.AddMessage("SQL Eintrag nicht gelöscht (" + listName.ToString() + ")--> SQL Fehler", true);
            }
        }

        private MySqlDataReader SQLSelect(String sqlStatement) { return SQLSelect(sqlStatement, sqlConnection); }
        private MySqlDataReader SQLSelect(String sqlStatement, MySqlConnection connnection)
        {
            if (connnection.State != System.Data.ConnectionState.Open) connnection.Open();
            MySqlCommand sqlCmd = new MySqlCommand(sqlStatement, connnection);
            MySqlDataReader sqlRead = sqlCmd.ExecuteReader();
            return sqlRead;

        }

        private string GetSQLStringNullSuppressed(MySqlDataReader sqlRead, string columnName)
        {
            Object obj = sqlRead.GetValue(sqlRead.GetOrdinal(columnName));
            if (obj == null || obj.ToString() == "")
            { return ""; }
            else
            { return sqlRead.GetString(columnName); }
        }


    }
}