using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TG.UI
{
    public partial class MainWindow : Form
    {
        SoundPlayer     spWave;
        Boolean         isVuv       =       false;
        
        public MainWindow()
        {
            InitializeComponent();
            spWave = new SoundPlayer( "Resources\\Sounds\\vuvuzela.wav " );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isVuv) spWave.Stop();
            else spWave.PlayLooping();

            isVuv = !isVuv;
        }


    }
}
