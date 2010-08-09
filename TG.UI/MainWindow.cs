﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TG.Model;


namespace TG.UI
{
    public partial class MainWindow : Form
    {
        private Vuv _myVuv;
        private String _oldText;
        private const String _vuvText =  "BBBBBBBBBBBBZZZZZZZZZZZZZZZZZZBBBBBBBBBBBBBBBBBBBBBBZZZZZZZZZZZZZZZZZZZZZ" +
                                         "BBBBBBBBBBBBBBBBBBBBBBBBBBBBZZZZZZZZZZZZZZZZZZZZZZZBBBBBBBBBBBBBBBBBBBBBB" +
                                         "BBZZZZZZZZZZZZZZZZ";
        private List<String> _commandHistory;


        public EventHandler InputHandler { get; set; }

        public GameState State
        {
            set
            {
                this.lblHPValue.Text = Convert.ToString( value.HitPoints );
                this.lblDamageValue.Text = Convert.ToString( value.Damage );
                this.txtChrName.Text = value.CharacterName;
                this.txtDescription.Text = value.GameText;
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            _myVuv = new Vuv();
            _commandHistory = new List<String>();
            //this.State = new GameState();
        }

        /// <summary>
        /// Close the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Did you click vuv? Play the song of my people
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuv();
        }

        /// <summary>
        /// The most critical function in this project. Toggles the vuvuzela state!!
        /// </summary>
        private void vuv()
        {
            var playing = _myVuv.TogglePlaying();
            if (!playing)
            {
                picMain.Image = PictureFactory.GetPicture(PictureFactory.PicTypes.SAD_PIC);
                txtDescription.Text = _oldText;
                txtStatus.Text = "Running";
            }
            else
            {
                _oldText = txtDescription.Text;
                picMain.Image = PictureFactory.GetPicture(PictureFactory.PicTypes.VUV_PIC);
                txtDescription.Text = _vuvText;
                txtStatus.Text = "Playing the song of my people";
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && !String.IsNullOrEmpty(txtInput.Text))
            {
                if( InputHandler != null )
                    InputHandler(sender, e);

                if (txtInput.Text.ToLower().Equals("play vuv"))
                {
                    vuv();
                }
                
                /* Set the event handled to avoid beep */
                e.Handled = true;

                /* Save the command and rebind textbox */
                _commandHistory.Add(txtInput.Text);
                txtCommandHist.Text = String.Join(Environment.NewLine, _commandHistory);
                txtCommandHist.SelectionStart = txtCommandHist.Text.Length;
                txtCommandHist.ScrollToCaret();
                txtInput.Clear();
            }
        }

        /// <summary>
        /// The latest command entered in the interface
        /// </summary>
        public String CurrentCommand
        {
            get
            {
                return _commandHistory[_commandHistory.Count - 1];
            }
        }

    }
}
