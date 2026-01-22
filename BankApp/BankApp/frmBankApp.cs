using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankAppControlLibrary;
using BankAppClassLibrary;
using Microsoft.Extensions.Logging;

namespace BankApp
{
    public partial class frmBankApp : Form
    {
		private IRepository _Irepo;
		
		public frmBankApp( IRepository irepo)
        {
            InitializeComponent();
			this._Irepo = irepo;
					
		}

		/// <summary>
		///  Durch dieser Ereignis kann  der Benutzer sich registrieren.
		/// </summary>
		/// <remarks> dieser Ereignis wird durchgeführt,wenn der Button Anmelden des ToolStripMenu betätigt wird </remarks>
		private void tsmuiRegister_Click(object sender, EventArgs e)
		{
			// LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
			ucCustomer ucrigRegister;     // Benutzersteuerelement zur Registrierung des Users.

			// Steuerelement instanzieren.
			ucrigRegister = new ucCustomer(this._Irepo);
			this.pnlControl.Visible = true;
			
			// Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
			clsUserControl.ShowUserControl(ucrigRegister, pnlControl);
		}

		///<summary>
		///   Durch dieser Ereignis kann  der Benutzer sich registrieren.
		///</summary>
		///<remarks> dieser Ereignis wird durchgeführt,wenn der Button Anmelden des ToolStripMenu betätigt wird </remarks>
		private void tsmuiAccount_Click(object sender, EventArgs e)
		{
			// LOKALEN OBJEKTVARIABLEN DEKLARIEREN: 
			ucAccount UserAccount;      // Benutzersteuertelement zur Anmeldung im Generator.

			// Steuerelement instanzieren.
			UserAccount = new ucAccount();

			pnlControl.Visible = true;
			// Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
			clsUserControl.ShowUserControl(UserAccount, pnlControl);

		}

		///<summary>
		///  Durch dieser Ereignis wird die Informationen des users angezeigt.
		///</summary>
		///<remarks> Diese Ereignis wird durchgeführt, wenn der MenuItem ProfilToolstrip wird betätigt </remarks>
		private void tsmuiProfil_Click(object sender, EventArgs e)
		{
			// LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
			ucAccount ucProfil;     // Benutzersteuerelement zum Anzeigen des Profils des Users.

			// Steuerelement instanzieren.
			ucProfil = new ucAccount();
			pnlControl.Visible = true;
			//pnlProfil.Visible = true;
			// Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
			clsUserControl.ShowUserControl(ucProfil, pnlControl);
		}

		private void tsmuiTransactions_click(object sender, EventArgs e)
        {
			// LOKALEN OBJEKTVARIABLEN DEKLARIEREN:
			UserTransactions ucTransactions;     // Benutzersteuerelement zum Anzeigen des Profils des Users.

			// Steuerelement instanzieren.
			ucTransactions = new UserTransactions();
			pnlControl.Visible = true;
			//pnlProfil.Visible = true;
			// Fügt der Steuerelementauflistung das angegebene Steuerelement hinzu.
			clsUserControl.ShowUserControl(ucTransactions, pnlControl);
		}
	}
}
