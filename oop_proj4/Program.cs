using System;
using System.Windows.Forms;


namespace oop_proj4
{
    static class Program
    {
        private static LoginForm loginForm;
        private static MainForm mainForm;

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            mainForm = new MainForm();

            Application.Run(mainForm);
        }

        public static void ShowMainForm(){ mainForm.Show(); }
        public static void End() { Application.Exit(); }
    }
}
