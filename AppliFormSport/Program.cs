using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliFormSport
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FrmConnexion connexion = new FrmConnexion())
            {
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmSport());
                }
            }
        }
    }
}
