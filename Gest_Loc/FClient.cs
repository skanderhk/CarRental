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
    public partial class FClient : MetroFramework.Forms.MetroForm
    {
        public FClient()
        {
            InitializeComponent();
        }

        public List<Client> LC;
        public Client Cl;
        private void FClient_Load(object sender, EventArgs e)
        {
            Afficher_Client();
        }

        private void Afficher_Client()
        {
            LC = ClientADO.List_Client();
            Dg_Cl.Rows.Clear();
            if (LC != null)
            {
                foreach (Client C in LC)
                    Dg_Cl.Rows.Add(C.Id_Cl, C.Nom_Cl, C.Num_CIN, C.Adr_Cl, C.Tel_Cl);
            }
        }
        private void Dg_Cl_DoubleClick(object sender, EventArgs e)
        {
            int ind = Dg_Cl.CurrentRow.Index;
            Cl = new Client()
            {
                Id_Cl = int.Parse(Dg_Cl[0, ind].Value.ToString()),
                Nom_Cl = Dg_Cl[1, ind].Value.ToString(),
                Num_CIN = Dg_Cl[2, ind].Value.ToString(),
                Adr_Cl = Dg_Cl[3, ind].Value.ToString(),
                Tel_Cl = Dg_Cl[4, ind].Value.ToString()
            };
            setFields(Cl);
        }

        private void Ajout_Click(object sender, EventArgs e)
        {
            if (Txt_Nom.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Nom client invalid");
            else if (Txt_Cin.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "CIN client invalid");
            else if (Txt_Adr.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Adresse client invalid");
            else if (Txt_Tel.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Téléphone client invalid");
            else
            {
                Client cl = new Client
                {
                    Nom_Cl = Txt_Nom.Text,
                    Num_CIN = Txt_Cin.Text,
                    Adr_Cl = Txt_Adr.Text,
                    Tel_Cl = Txt_Tel.Text
                };
                ClientADO.Ajouter(cl);
                clearFields();
                Afficher_Client();
                MessageBox.Show("Client ajouté avec succès");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (Cl != null)
            {
                if (Txt_Nom.Text == "")
                    MetroFramework.MetroMessageBox.Show(this, "Nom client invalid");
                else if (Txt_Cin.Text == "")
                    MetroFramework.MetroMessageBox.Show(this, "CIN client invalid");
                else if (Txt_Adr.Text == "")
                    MetroFramework.MetroMessageBox.Show(this, "Adresse client invalid");
                else if (Txt_Tel.Text == "")
                    MetroFramework.MetroMessageBox.Show(this, "Téléphone client invalid");
                else
                {
                    Client cl = new Client
                    {
                        Id_Cl = Cl.Id_Cl,
                        Nom_Cl = Txt_Nom.Text,
                        Num_CIN = Txt_Cin.Text,
                        Adr_Cl = Txt_Adr.Text,
                        Tel_Cl = Txt_Tel.Text
                    };
                    ClientADO.Modifier(cl);
                    clearFields();
                    Afficher_Client();
                    MessageBox.Show("Client modifié avec succès");
                }
            } else
            {
                MessageBox.Show("Sélectionner un client");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (Cl != null)
            {
                ClientADO.Supprimer(Cl.Id_Cl);
                clearFields();
                Afficher_Client();
                MessageBox.Show("Client supprimé avec succès");
            }
            else
            {
                MessageBox.Show("Sélectionner un client");
            }

        }

        private void clearFields()
        {
            Txt_Nom.Clear();
            Txt_Cin.Clear();
            Txt_Adr.Clear();
            Txt_Tel.Clear();
        }

        private void setFields(Client cl)
        {
            Txt_Nom.Text = cl.Nom_Cl;
            Txt_Cin.Text = cl.Num_CIN;
            Txt_Adr.Text = cl.Adr_Cl;
            Txt_Tel.Text = cl.Tel_Cl;
        }
    }
}
