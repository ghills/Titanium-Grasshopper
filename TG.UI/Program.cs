using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TG.Model;

namespace TG.UI
{
    public class Program
    {
        private static MainWindow window;
        private static EventHandler onLoad;

        [STAThread]
        static void Main()
        {
            Program.RunGUI(onLoad);
        }

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
    }
}