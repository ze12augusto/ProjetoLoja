using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProjetoLojaDesktop.Forms;
using ProjetoLojaDesktop.Views;
using ProjetoLojaDesktop;
using ProjetoLojaDesktop.Enums;
using ProjetoLojaDesktop.Views.Cliente;


namespace ProjetoLojaDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
