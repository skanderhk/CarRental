using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;

namespace Gest_Loc
{
    public partial class FVoiture : MetroFramework.Forms.MetroForm
    {
        // Collection de type List qui stocke la liste des voitures
        List<Voiture> LV = new List<Voiture>();
        public FVoiture()
        {
            InitializeComponent();
        }

        // événement de chargement du formulaire FVoiture
        private void FVoiture_Load(object sender, EventArgs e)
        {
            Affiche_Voit();
        }

        // Méthode qui affiche la liste des voitures dans le DataGridView Dg_Voit
        private void Affiche_Voit()
        {
            LV = VoitureADO.List_Voit();
            Dg_Voit.Rows.Clear();
            if (LV != null)
            {
                foreach (Voiture V in LV)
                    Dg_Voit.Rows.Add(V.Immat_V, V.Marq_V, V.Mod_V, V.Kilom_V, V.PrixLoc_V, V.Est_Disp);
            }
        }
        // Bouton pour Enregistrer une nouvelle Voiture dans la base de données
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Immat.Text))
                MessageBox.Show("saisir IMMAT Voiture");
            else
            {
                Voiture V = new Voiture
                {
                    Immat_V = Txt_Immat.Text,
                    Marq_V = Txt_marq.Text,
                    Mod_V = Txt_Mod.Text,
                    PrixLoc_V = double.Parse(Txt_Prix.Text),
                    Kilom_V = int.Parse(Txt_Kil.Text),
                    Est_Disp = Chk_Disp.Checked
                };
                Voiture v1 = VoitureADO.Recherche_Immat(Txt_Immat.Text);
                if (v1 == null)
                {
                    VoitureADO.Ajouter(V);
                    Affiche_Voit();
                }
                else
                    MessageBox.Show("Cette IMMAT de voiture existe dejà");
            }
        }
        
        // événement qui se déclenche lors d'un double click sur une ligne du DataGridView
        //(sélection d'une voiture)
        private void Dg_Voit_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Voit.CurrentRow.Index;
            Txt_Immat.Text = Dg_Voit[0, ind].Value.ToString();
            Txt_marq.Text = Dg_Voit[1, ind].Value.ToString();
            Txt_Mod.Text = Dg_Voit[2, ind].Value.ToString();
            Txt_Kil.Text = Dg_Voit[3, ind].Value.ToString();
            Txt_Prix.Text = Dg_Voit[4, ind].Value.ToString();
            Chk_Disp.Checked = bool.Parse(Dg_Voit[5, ind].Value.ToString());
        }
        // bouton pour supprimer une voiture sélectionnée
        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vous été sur de supprimer la voiture", "Supprimer voiture", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                VoitureADO.Supprimer(Txt_Immat.Text);
                Affiche_Voit();
                MessageBox.Show("Voiture supprimer avec succées!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }
        // bouton pour modifier une voiture sélectionnée
        private void Modifier_Click(object sender, EventArgs e)
        {
            Voiture V = new Voiture
            {
                Immat_V = Txt_Immat.Text,
                Marq_V = Txt_marq.Text,
                Mod_V = Txt_Mod.Text,
                PrixLoc_V = float.Parse(Txt_Prix.Text),
                Kilom_V = int.Parse(Txt_Kil.Text),
                Est_Disp = Chk_Disp.Checked
            };
            VoitureADO.Modifier(V);
            Affiche_Voit();
        }
        // Bouton Recherche de voiture par Immatriculation ou par Marque
        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Immat.Text))
            {
                Voiture v = VoitureADO.Recherche_Immat(Txt_Immat.Text);
                if (v != null)
                {
                    Txt_marq.Text = v.Marq_V;
                    Txt_Mod.Text = v.Mod_V;
                    Txt_Kil.Text = v.Kilom_V.ToString();
                    Txt_Prix.Text = v.PrixLoc_V.ToString();
                    Chk_Disp.Checked = Convert.ToBoolean(v.Est_Disp);
                    Dg_Voit.Rows.Clear();
                    Dg_Voit.Rows.Add(v.Immat_V, v.Marq_V, v.Mod_V, v.Kilom_V, v.PrixLoc_V, v.Est_Disp);

                }
                else
                    MessageBox.Show("Aucune voiture trouvée", "attention");
            }
            else
            if (!string.IsNullOrEmpty(Txt_marq.Text))
            {
                List<Voiture> l = VoitureADO.Recherche_Marque(Txt_marq.Text);
                if (l.Count > 0)
                {
                    Dg_Voit.Rows.Clear();
                    foreach (var V in l)

                        Dg_Voit.Rows.Add(V.Immat_V, V.Marq_V, V.Mod_V, V.Kilom_V, V.PrixLoc_V, V.Est_Disp);
                }
                else
                    MessageBox.Show("Aucune voiture trouvée");
            }
        }

        // bouton actualiser l'affichage dans le DataGridView
        private void Vider_Click(object sender, EventArgs e)
        {
            Affiche_Voit();
        }

    }
}
