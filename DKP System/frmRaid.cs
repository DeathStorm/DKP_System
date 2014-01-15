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
    public partial class frmRaid : Form
    {
        private Dictionary<int, String> Content;

        public frmRaid(Dictionary<int,String> Content)
        {
            InitializeComponent();
            this.Content = new Dictionary<int, string>(Content);

            this.cbContent.Items.Clear();
            foreach (String value in Content.Values)
            {
                this.cbContent.Items.Add(value);
            }
        }

        private void frmRaid_Load(object sender, EventArgs e)
        {

        }
    }
}
