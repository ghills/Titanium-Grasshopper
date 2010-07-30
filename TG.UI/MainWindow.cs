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
        private Vuv _myVuv;
        private String _oldText;
        private const String _vuvText = "BBBBBBBBBBBBZZZZZZZZZZZZZZZZZZBBBBBBBBBBBBBBBBBBBBBBZZZZZZZZZZZZZZZZZZZZZ" +
                                      "BBBBBBBBBBBBBBBBBBBBBBBBBBBBZZZZZZZZZZZZZZZZZZZZZZZBBBBBBBBBBBBBBBBBBBBBBBBZZZZZZZZZZZZZZZZ";
        
        public MainWindow()
        {
            InitializeComponent();
            _myVuv = new Vuv();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playing = _myVuv.TogglePlaying();
            if (!playing)
            {
                picMain.Image = PictureFactory.GetPicture(PictureFactory.PicTypes.SAD_PIC);
                txtDescription.Text = _oldText;
            }
            else
            {
                _oldText = txtDescription.Text;
                picMain.Image = PictureFactory.GetPicture(PictureFactory.PicTypes.VUV_PIC);
                txtDescription.Text = _vuvText;
            }
        }
    }
}
