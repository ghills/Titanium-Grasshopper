using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TG.Model;

namespace TG.UI
{
    public class Program
    {
        private static MainWindow window;

        [STAThread]
        static void Main()
        {
            Program.RunGUI();
        }

        public static void RunGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            window = new MainWindow();
            Application.Run(window);
        }

        public static void SetState(GameState state)
        {
            window.State = state;
        }
    }
}