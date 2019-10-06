using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeplacerElementsDeuxList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gaucheListBox.Items.Add("Langage C");
            gaucheListBox.Items.Add("Langage JAVA");
            gaucheListBox.Items.Add("Langage C++");
        }

        private void gvdButton_Click(object sender, EventArgs e)
        {
            if (gaucheListBox.SelectedIndex != -1)
            {
                if (!droiteListBox.Items.Contains(gaucheListBox.SelectedItem))
                {
                    droiteListBox.Items.Add(gaucheListBox.SelectedItem);
                    gaucheListBox.Items.Remove(gaucheListBox.SelectedItem);
                }     
            }
        }

        private void dvgButton_Click(object sender, EventArgs e)
        {
            if (droiteListBox.SelectedIndex != -1)
            {
                if (!gaucheListBox.Items.Contains(droiteListBox.SelectedItem))
                {
                    gaucheListBox.Items.Add(droiteListBox.SelectedItem);
                    droiteListBox.Items.Remove(droiteListBox.SelectedItem);
                }
            }
        }

        private void gvdButtonAll_Click(object sender, EventArgs e)
        {

            droiteListBox.Items.AddRange(gaucheListBox.Items);
            gaucheListBox.Items.Clear();
        }

        private void dvgButtonAll_Click(object sender, EventArgs e)
        {
            gaucheListBox.Items.AddRange(droiteListBox.Items);
            droiteListBox.Items.Clear();
        }

        private void hautGaucheButton_Click(object sender, EventArgs e)
        {
            int indice = gaucheListBox.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Il faut selectioner une ligne ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gaucheListBox.SelectedIndex != 0)
            {
                String value = gaucheListBox.Items[indice].ToString();
                gaucheListBox.Items[indice] = gaucheListBox.Items[indice - 1];
                gaucheListBox.Items[indice - 1] = value;
                gaucheListBox.SelectedIndex = indice - 1;
            }
        }

        private void basGoucheButton_Click(object sender, EventArgs e)
        {
            int indice = gaucheListBox.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Il faut selectioner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gaucheListBox.SelectedIndex != gaucheListBox.Items.Count-1)
            {
                String value = gaucheListBox.Items[indice].ToString();
                gaucheListBox.Items[indice] = gaucheListBox.Items[indice + 1];
                gaucheListBox.Items[indice + 1] = value;
                gaucheListBox.SelectedIndex = indice + 1;
            }
        }

        private void azGaucheButton_Click(object sender, EventArgs e)
        {
            gaucheListBox.Sorted = false;
            gaucheListBox.Sorted = true;
        }

        private void zaGaucheButton_Click(object sender, EventArgs e)
        {
            String[] unsortedList = new String[gaucheListBox.Items.Count];
            gaucheListBox.Sorted = true;
            int j = 0;
            for(int i= unsortedList.Length-1; i>=0; i--)
            {
                unsortedList[j] = gaucheListBox.Items[i].ToString();
                j++;
            }
            gaucheListBox.Sorted = false;
            gaucheListBox.Items.Clear();
            gaucheListBox.Items.AddRange(unsortedList);
        }
    }
}
