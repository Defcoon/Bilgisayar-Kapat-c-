using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BilgisayarKapatici_v1
{
    public partial class Performans_İzleyici : Form
    {
        public Performans_İzleyici()
        {
            InitializeComponent();
        }

        private void Performans_İzleyici_Load(object sender, EventArgs e)
        {
            tmrDeger.Enabled = true;
        }
        

        private void chkTopMost_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TopMost = chkTopMost.Checked;
        }

        private void tmrDeger_Tick(object sender, EventArgs e)
        {
            float cpuYuzde = islemci.NextValue();
            lblCPU.Text = "% " + cpuYuzde.ToString("N2");
            pbCPU.Value = (int)cpuYuzde;

            float ramYuzde = ram.NextValue();
            lblRAM.Text = "% " + ramYuzde.ToString("N2");
            pbRAM.Value = (int)ramYuzde;
        }

       
    }
}
