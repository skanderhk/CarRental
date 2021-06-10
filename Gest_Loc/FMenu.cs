using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest_Loc
{
    public partial class FMenu : MetroFramework.Forms.MetroForm
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void TS_Btn_Vot_Click(object sender, EventArgs e)
        {
            FVoiture fv = new FVoiture();
            fv.MdiParent = this;
            fv.Show();
        }

        private void TS_Btn_Loc_Click(object sender, EventArgs e)
        {
            FLocation fl = new FLocation();
            fl.MdiParent = this;
            fl.Show();

        }

        private void TS_Btn_RerLoc_Click(object sender, EventArgs e)
        {
            FRetLoc fRLoc = new FRetLoc();
            fRLoc.MdiParent = this;
            fRLoc.Show();

        }

        private void TS_Btn_Cl_Click(object sender, EventArgs e)
        {
            FClient fcl = new FClient();
            fcl.MdiParent = this;
            fcl.Show();
        }
    }
}
