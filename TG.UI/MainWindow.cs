using System;
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
        private List<String> _commandList;
        private Stack<String> _commandHistory;


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
            _commandList = new List<String>();
            _commandHistory = new Stack<String>();
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
            switch (e.KeyChar)
            {
                case ( (char)Keys.Return ):
                    if (String.IsNullOrEmpty(txtInput.Text)) break;
                    if( InputHandler != null ) InputHandler(sender, e);
                    if (txtInput.Text.ToLower().Equals("play vuv")) vuv();
                    
                    /* Set the event handled to avoid beep */
                    e.Handled = true;

                    /* Save the command and rebind textbox */
                    _commandHistory.Push(txtInput.Text);
                    _commandList.Add(txtInput.Text);
                    txtCommandHist.Text = String.Join(Environment.NewLine, _commandList);
                    txtCommandHist.SelectionStart = txtCommandHist.Text.Length;
                    txtCommandHist.ScrollToCaret();
                    txtInput.Clear();
                    break;
            }

        }
        /// <summary>
        /// The Keydown event is called when any combination of keys is pressed.
        /// I.E. ctrl+s will call this event.  This will be useful in the future if we want
        /// ctrl+s to save the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtInput_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (_commandHistory.Count > 0)
                    {
                        //GMH - TODO: maybe do something smarter instead of popping, so we dont lose the history
                        txtInput.Text = _commandHistory.Pop();
                        txtInput.SelectionStart = ( txtInput.Text.Length + 1 );
                    }
                    break;
            }
        }

        /// <summary>
        /// The latest command entered in the interface
        /// </summary>
        public String CurrentCommand
        {
            get
            {
                return _commandList[_commandList.Count - 1];
            }
        }

    }
}
