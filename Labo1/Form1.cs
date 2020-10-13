using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo1
{
    /// <summary>
    /// La classe du Form1
    /// </summary>
    public partial class Form1 : Form
    {

        /// <summary>
        /// Initialisation du Form1, et ajoute les composants
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            ComboBox1.SelectedIndex = 0;
        }


        /// <summary>
        /// Méthode pour le bouton Aide du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oussama Lourhmati \n4 février 2019 ", "À propos");
        }

        private void BtnTheme_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ColorDialog Clr = new System.Windows.Forms.ColorDialog();
            if (Clr.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = Clr.Color;
            }
        }



        /// <summary>
        /// Méthode pour le bouton d'ajout dans le panel du ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAj2_Click(object sender, EventArgs e)
        {
            List<string> selectedList = new List<string>();
            foreach (var item in ListBox1.SelectedItems)
            {
                selectedList.Add(item.ToString());
            }


            foreach (var item in selectedList)
            {
                if (!CheckedListBox1.Items.Contains(item))
                {
                    CheckedListBox1.Items.Add(item);
                }

            }
        }


        /// <summary>
        /// Méthode pour le bouton d'ajout dans le panel du ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAj3_Click(object sender, EventArgs e)
        {
            if (!CheckedListBox1.Items.Contains(ComboBox1.SelectedItem))
            {
                CheckedListBox1.Items.Add(ComboBox1.SelectedItem);
            }

        }

        /// <summary>
        /// Méthode pour le bouton Supprimer, supprimer les élements de la CheckBoxListed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupp_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection toDelete = CheckedListBox1.CheckedItems;
            for (int i = toDelete.Count; i > 0; i--)
            {
                CheckedListBox1.Items.Remove(toDelete[i - 1]);
            }

            if (CheckedListBox1.CheckedItems.Count == 0)
            {
                BtnSupp.Enabled = false;
            }

            if (CheckedListBox1.CheckedItems.Count >= 1)
            {
                BtnSupp.Enabled = true;
            }
            else
            {
                BtnSupp.Enabled = false;
            }
        }


        /// <summary>
        /// Méthode pour le bouton d'ajout dans le panel de TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAj1_Click(object sender, EventArgs e)
        {
            List<TextBox> TxtListe = new List<TextBox>() { TxtBox1, TxtBox2, TxtBox3, TxtBox4 };

            foreach (var item in TxtListe)
            {
                item.Text = item.Text.Trim();
                if (item.Text != "" && !CheckedListBox1.Items.Contains(item.Text))
                {
                    CheckedListBox1.Items.Add(item.Text);
                }

            }

        }


        /// <summary>
        /// Méthode pour le bouton Commander.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre commande sera traitée. Merci et bonne journée !", "Commande terminée");
            //Appeler la méthode MenuItem1_Click() qui correspond à la rénitialisation
            Reinitialiser();
        }


        /// <summary>
        /// Méthode dans laquelle Reinitialiser est appel, il s'agit du bouton Rénitialiser du Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            Reinitialiser();
        }


        /// <summary>
        /// Méthode pour la rénitialisation de toute les composants
        /// </summary>
        private void Reinitialiser()
        {
            CheckedListBox1.Items.Clear();
            BackColor = DefaultBackColor;
            ComboBox1.SelectedItem = null;
            ListBox1.SelectedItem = null;

            List<TextBox> TxtListe = new List<TextBox>() { TxtBox1, TxtBox2, TxtBox3, TxtBox4 };
            foreach (var item in TxtListe)
            {
                item.Clear();
            }

        }


        /// <summary>
        /// Méthode pour le bouton Quitter du Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }


        /// <summary>
        /// Méthode dans laquelle BtnSupp_Enabled() est appelé lorsqu'il y a modification dans le CheckedListBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSupp_Enabled();
        }


        /// <summary>
        /// Méthode dans laquelle BtnSupp_Enabled() est appelé lorsque le clavier est utilisé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnSupp_Enabled();
        }


        /// <summary>
        /// Méthode pour activer ou désactiver le bouton Supprimer   
        /// </summary>
        private void BtnSupp_Enabled()
        {
            if (CheckedListBox1.CheckedItems.Count >= 1)
            {
                BtnSupp.Enabled = true;
            }
            else
            {
                BtnSupp.Enabled = false;
            }
        }
    }
}
