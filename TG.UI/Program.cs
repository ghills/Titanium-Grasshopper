using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TG.Model;

namespace TG.UI
{
    public class Program
    {
        private static MainWindow window;
        
        static void Main()
        {
            Program.RunGUI( dummyHandler );
        }

        /// <summary>
        /// Used for when this is compiled as a standalone exe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void dummyHandler(object sender, EventArgs e)
        {
            
        }

        [STAThread]
        public static void RunGUI(EventHandler onLoad)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new MainWindow();
            window.Load += onLoad;
            Application.Run(window);
            window.Load -= onLoad;
        }

        public static void SetState(GameState state)
        {
            window.State = state;
        }

        public static void SetInputHandler(EventHandler handler)
        {
            window.InputHandler = handler;
        }
    }
}