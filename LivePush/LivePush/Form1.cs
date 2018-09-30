using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePush
{
    public partial class MainForm : Form
    {
        public string CmdFile;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height - 35);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CmdFile = dialog.SelectedPath + "\\update.cmd";
                StreamWriter w = File.CreateText(CmdFile);
                w.AutoFlush = true;
                w.Write(Data.Code(CmdFile));
                w.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(CmdFile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
