using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace appSSI
{
    static class Program
    {
        public static string ExeDir;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmLogin.Close();
                ExeDir = (new FileInfo(System.Reflection.Assembly.GetEntryAssembly().Location)).Directory.ToString();
                Application.Run(new frmMenu(frmLogin.objUsuario));
            }
            frmLogin.Close();
        }
    }
}
