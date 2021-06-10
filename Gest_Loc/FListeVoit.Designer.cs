
namespace Gest_Loc
{
    partial class FListeVoit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListeVoit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtmodele = new MetroFramework.Controls.MetroTextBox();
            this.Rech_Voit = new System.Windows.Forms.PictureBox();
            this.combomarque = new MetroFramework.Controls.MetroComboBox();
            this.Dg_Voit = new MetroFramework.Controls.MetroGrid();
            this.Immatriculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modèle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilométrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(32, 106);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Marque";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(360, 106);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Modèle";
            // 
            // txtmodele
            // 
            // 
            // 
            // 
            this.txtmodele.CustomButton.Image = null;
            this.txtmodele.CustomButton.Location = new System.Drawing.Point(237, 2);
            this.txtmodele.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmodele.CustomButton.Name = "";
            this.txtmodele.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.txtmodele.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmodele.CustomButton.TabIndex = 1;
            this.txtmodele.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmodele.CustomButton.UseSelectable = true;
            this.txtmodele.CustomButton.Visible = false;
            this.txtmodele.Lines = new string[0];
            this.txtmodele.Location = new System.Drawing.Point(464, 103);
            this.txtmodele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmodele.MaxLength = 32767;
            this.txtmodele.Name = "txtmodele";
            this.txtmodele.PasswordChar = '\0';
            this.txtmodele.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmodele.SelectedText = "";
            this.txtmodele.SelectionLength = 0;
            this.txtmodele.SelectionStart = 0;
            this.txtmodele.ShortcutsEnabled = true;
            this.txtmodele.Size = new System.Drawing.Size(204, 28);
            this.txtmodele.TabIndex = 2;
            this.txtmodele.UseSelectable = true;
            this.txtmodele.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmodele.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Rech_Voit
            // 
            this.Rech_Voit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rech_Voit.BackgroundImage")));
            this.Rech_Voit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rech_Voit.Location = new System.Drawing.Point(697, 98);
            this.Rech_Voit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rech_Voit.Name = "Rech_Voit";
            this.Rech_Voit.Size = new System.Drawing.Size(57, 37);
            this.Rech_Voit.TabIndex = 3;
            this.Rech_Voit.TabStop = false;
            this.Rech_Voit.Click += new System.EventHandler(this.Rech_Voit_Click);
            // 
            // combomarque
            // 
            this.combomarque.DisplayMember = "marq_v";
            this.combomarque.FormattingEnabled = true;
            this.combomarque.ItemHeight = 24;
            this.combomarque.Location = new System.Drawing.Point(121, 100);
            this.combomarque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combomarque.Name = "combomarque";
            this.combomarque.Size = new System.Drawing.Size(193, 30);
            this.combomarque.TabIndex = 4;
            this.combomarque.UseSelectable = true;
            // 
            // Dg_Voit
            // 
            this.Dg_Voit.AllowUserToResizeRows = false;
            this.Dg_Voit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dg_Voit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Dg_Voit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dg_Voit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Voit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Immatriculation,
            this.Marque,
            this.Modèle,
            this.Kilométrage,
            this.PrixLocation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dg_Voit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dg_Voit.EnableHeadersVisualStyles = false;
            this.Dg_Voit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Dg_Voit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Dg_Voit.Location = new System.Drawing.Point(32, 170);
            this.Dg_Voit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dg_Voit.Name = "Dg_Voit";
            this.Dg_Voit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dg_Voit.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dg_Voit.RowHeadersWidth = 51;
            this.Dg_Voit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dg_Voit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dg_Voit.Size = new System.Drawing.Size(723, 276);
            this.Dg_Voit.Style = MetroFramework.MetroColorStyle.Silver;
            this.Dg_Voit.TabIndex = 5;
            this.Dg_Voit.DoubleClick += new System.EventHandler(this.Dg_Voit_DoubleClick);
            // 
            // Immatriculation
            // 
            this.Immatriculation.HeaderText = "Immatriculation";
            this.Immatriculation.MinimumWidth = 6;
            this.Immatriculation.Name = "Immatriculation";
            this.Immatriculation.Width = 125;
            // 
            // Marque
            // 
            this.Marque.HeaderText = "Marque";
            this.Marque.MinimumWidth = 6;
            this.Marque.Name = "Marque";
            this.Marque.Width = 125;
            // 
            // Modèle
            // 
            this.Modèle.HeaderText = "Modèle";
            this.Modèle.MinimumWidth = 6;
            this.Modèle.Name = "Modèle";
            this.Modèle.Width = 125;
            // 
            // Kilométrage
            // 
            this.Kilométrage.HeaderText = "Kilométrage";
            this.Kilométrage.MinimumWidth = 6;
            this.Kilométrage.Name = "Kilométrage";
            this.Kilométrage.Width = 125;
            // 
            // PrixLocation
            // 
            this.PrixLocation.HeaderText = "Prix Location";
            this.PrixLocation.MinimumWidth = 6;
            this.PrixLocation.Name = "PrixLocation";
            this.PrixLocation.Width = 125;
            // 
            // FListeVoit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 484);
            this.Controls.Add(this.Dg_Voit);
            this.Controls.Add(this.combomarque);
            this.Controls.Add(this.Rech_Voit);
            this.Controls.Add(this.txtmodele);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FListeVoit";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Liste des voitures disponibles";
            this.Load += new System.EventHandler(this.FListeVoit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rech_Voit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Voit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtmodele;
        private System.Windows.Forms.PictureBox Rech_Voit;
        private MetroFramework.Controls.MetroComboBox combomarque;
        private MetroFramework.Controls.MetroGrid Dg_Voit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Immatriculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modèle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilométrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixLocation;
    }
}