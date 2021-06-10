﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace Gest_Loc
{
    public partial class FRetLoc : MetroFramework.Forms.MetroForm
    {
        public FRetLoc()
        {
            InitializeComponent();
        }

        //Cette méthode affiche la liste de locations en cours passée en paramètre dans le datagridview Dg_Loc
        public void Affiche(List<Location> L)
        {
            Dg_Loc.Rows.Clear();
            foreach (Location l in L)
                Dg_Loc.Rows.Add(l.Num_Loc, l.Immat_V, l.Id_Cl, l.DDeb_Loc, l.DRet_Loc, l.Kil_Dep, l.Kil_Ret);
        }
        // bouton de recherche de locations en cours par Immat voiture ou par ID client
        private void Rech_Cl_Click(object sender, EventArgs e)
        {
            List<Location> L;
            if (Txt_Voit.Text != "")
            {
                L = LocationADO.List_Loc_Vt(Txt_Voit.Text);
                Affiche(L);
            }
            else
            if (Txt_Cl.Text != "")
            {
                L = LocationADO.List_Loc_Cl(int.Parse(Txt_Cl.Text));
                Affiche(L);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Vous devez choisir un critère");
        }
        // bouton pour enregistrer le retour location et mise à jour des
        // données de la location et de la voiture (appel à la méthode Retourner_Loc
        private void Valider_Click(object sender, EventArgs e)
        {
            int ind = Dg_Loc.CurrentRow.Index;
            int Num = int.Parse(Dg_Loc[0, ind].Value.ToString());
            string Immat = Dg_Loc[1, ind].Value.ToString();
            int Kr = int.Parse(Dg_Loc[6, ind].Value.ToString());
            LocationADO.Retourner_Loc(Num, Immat, Kr);
            MessageBox.Show("Retour Validé");
        }
        // événement click du datagridview pour afficher l'ID client et l'immat voiture
        // dans les zones de textes adéquates
        private void Dg_Loc_Click(object sender, EventArgs e)
        {
            int ind = Dg_Loc.CurrentRow.Index;
            Txt_Voit.Text = Dg_Loc[1, ind].Value.ToString();
            Txt_Cl.Text = Dg_Loc[2, ind].Value.ToString();
        }

        private void FRetLoc_Load(object sender, EventArgs e)
        {
            List<Location> L = LocationADO.list_loc();
            Affiche(L);
        }
    }
}
