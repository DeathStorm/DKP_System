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
    public partial class frmRaidPlaner : Form
    {
        public frmRaidPlaner(Dictionary<int,String> Raids)
        {
            InitializeComponent();
            foreach (String value in Raids.Values)
            {
                cbRaid.Items.Add(value);
            }
        }

        private void frmRaidPlaner_Load(object sender, EventArgs e)
        {

        }
    }
}
