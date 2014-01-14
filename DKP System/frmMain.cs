using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            RefreshRaider();
            RefreshRaids();

        }

        private void RefreshRaider()
        {
            try
            {
                MySqlCommand sqlCmd = new MySqlCommand("Select * from Raider", sqlConnection);
                sqlConnection.Open();
                MySqlDataReader sqlRead = sqlCmd.ExecuteReader();

                dgRaider.Rows.Clear();

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        DataGridViewRow row = dgRaider.Rows[dgRaider.Rows.Add()];
                        row.Cells[dgRaiderID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgRaiderName.Name].Value = sqlRead.GetString("Name");
                        row.Cells[dgRaiderDKP_T1.Name].Value = sqlRead.GetString("DKP_T1");
                        row.Cells[dgRaiderDKP_T2.Name].Value = sqlRead.GetString("DKP_T2");
                    }

                }
                sqlRead.Close();
                sqlConnection.Close();
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

                if (sqlRead.HasRows)
                {
                    while (sqlRead.Read())
                    {
                        DataGridViewRow row = dgRaids.Rows[dgRaids.Rows.Add()];
                        row.Cells[dgRaidsID.Name].Value = sqlRead.GetString("ID");
                        row.Cells[dgRaidsName.Name].Value = sqlRead.GetString("Name");
                        row.Cells[dgRaidsShortcut.Name].Value = sqlRead.GetString("Shortcut");
                        row.Cells[dgRaidsContent.Name].Value = sqlRead.GetString("Content");
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            sqlConnection = new MySqlConnection("Data Source=" + sqlDatasource + "; Database=" + sqlDatabase + "; User ID=" + sqlLogin + ";Password=" + sqlPassword);
            AddMessage("Connection aufgebaut");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void btnAddRaider_Click(object sender, EventArgs e)
        {

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
                if (raider.tbDKP_T1.Text == "") raider.tbDKP_T1.Text = "0";
                if (raider.tbDKP_T2.Text == "") raider.tbDKP_T2.Text = "0";

                try
                {
                    if (raider.tbID.Text == "")
                    {
                        cmdString =
                            "INSERT INTO Raider VALUES(0, " +
                            "'" + raider.tbName.Text + "', " +
                            raider.tbDKP_T1.Text + ", " +
                            raider.tbDKP_T2.Text + ");";
                        messageSuccess = "Raider erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE Raider SET " +
                            "Name = '" + raider.tbName.Text + "', " +
                            "DKP_T1 = " + raider.tbDKP_T1.Text + ", " +
                            "DKP_T2 = " + raider.tbDKP_T2.Text + " " +
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

        private void btnAddRaid_Click(object sender, EventArgs e)
        {

        }

        private void SQLSaveRaid(frmRaid raid)
        {
            if (raid.tbName.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Name", true); }
            else if (raid.tbShortcut.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Shortcut", true); }
            else if (raid.cbContent.Text == "") { AddMessage("Raid nicht gespeichert --> Kein Content", true); }
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
                            "'" + raid.cbContent.Text + "', " +
                            "'" + raid.tbCommentary.Text + "');";
                        messageSuccess = "Raid erfolgreich erstellt";
                    }
                    else
                    {
                        cmdString =
                            "UPDATE Raids SET " +
                            "Name = '" + raid.tbName.Text + "', " +
                            "Shortcut = '" + raid.tbShortcut.Text + "', " +
                            "Content = '" + raid.cbContent.Text + "', " +
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
                frmRaid raid = new frmRaid();
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
            frmRaid raid = new frmRaid();

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
                raider.tbDKP_T1.Text = row.Cells[dgRaiderDKP_T1.Name].Value.ToString();
                raider.tbDKP_T2.Text = row.Cells[dgRaiderDKP_T2.Name].Value.ToString();
                if (raider.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    SQLSaveRaider(raider);

                }
            }
        }
    }
}
