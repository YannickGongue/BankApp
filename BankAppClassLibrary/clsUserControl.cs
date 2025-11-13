using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppClassLibrary
{
    public class clsUserControl
    {
        public static Control ShowUserControl(Control ctrlControl, Panel pnlUserControl)
        {
            // Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
            pnlUserControl.Controls.Add(ctrlControl);
            // die Position und Methode zum Andocken eines Steuerelements angeben.
            ctrlControl.Dock = DockStyle.Fill;
            // Steuerelement am Anfang der Reihenfolge anzeigen.
            ctrlControl.BringToFront();
            return ctrlControl;
        }

        public static void ClearUserControl(Control ctrlControl, Panel pnlUserControl)
        {
            pnlUserControl.Visible = false;
        }
    }
}
