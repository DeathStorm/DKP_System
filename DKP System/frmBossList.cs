using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKP_System
{
    internal partial class frmBossList : Form
    {
        frmMain main;

        internal frmBossList(frmMain main)
        {
            this.main = main;

            InitializeComponent();

            cbRaid.Items.Clear();
            foreach (string raid in main.Raids.Values) { this.cbRaid.Items.Add(raid); }
            RefreshBossItems();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbRaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBossItems();
        }

        private void RefreshBossItems()
        {
            cbVorgaenger.Items.Clear();
            if (cbRaid.Text != "")
            {
                int? raidID = main.GetKeyOfValue(main.Raids, cbRaid.Text);
                if (raidID != null)
                {
                    foreach (KeyValuePair<int, int> BossToRaid in main.BossListToRaidID)
                    {
                        if (BossToRaid.Value == raidID)
                        {
                            cbVorgaenger.Items.Add(main.BossList[BossToRaid.Key]);
                        }
                    }
                }

            }
        }

        
    }
}
