using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TG.UI
{
    public partial class MainWindow : Form
    {
        Vuv myVuv;
        
        public MainWindow()
        {
            InitializeComponent();
            myVuv = new Vuv();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myVuv.TogglePlaying();
        }
    }
}
