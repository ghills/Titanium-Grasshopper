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

        
        static void Main()
        {
            Program.RunGUI(onLoad);
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
    }
}