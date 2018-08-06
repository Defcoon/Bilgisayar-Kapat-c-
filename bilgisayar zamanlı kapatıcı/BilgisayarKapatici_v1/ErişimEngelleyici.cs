using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace BilgisayarKapatici_v1
{
    public partial class ErişimEngelleyici : Form
    {
        public ErişimEngelleyici()
        {
            InitializeComponent();
        }

        private void ErişimEngelleyici_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(this.Handle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
