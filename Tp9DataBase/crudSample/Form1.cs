using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dao;
using System.Data.Linq;

namespace crudSample
{
    public partial class Form1 : Form
    {
        DAOPersonImpl DAOPerson;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=sample;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            DAOPerson = new DAOPersonImpl("sample");
            DisplayData();
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            var bindingList = new BindingList<Person>(DAOPerson.getAllPerson());
            var source = new BindingSource(bindingList, null);
            var context = new DataContext("");
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<Person>(p => p.Id_filiere);
            dataGridView1.DataSource = source;
            chart1.Series["Name"].Points.Clear();
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            foreach (Person person in DAOPerson.getAllPerson())
            {
                int x=chart1.Series["Name"].Points.AddXY(person.Name, person.Id + 10);
                int nb = person.Id + 10;
                chart1.Series["Name"].Points[x].Label = nb+"";
            }
        }

        //Clear Data  
        private void ClearData()
        {
            txt_name.Text = "";
            txt_state.Text = "";
            ID = 0;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_state.Text != "")
            {
                Person person = new Person(txt_name.Text, txt_state.Text, 1);
                if (DAOPerson.addPerson(person))
                {
                    MessageBox.Show("Record Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_state.Text != "")
            {
                Person person = new Person(ID, txt_name.Text, txt_state.Text, 1);
                if (DAOPerson.updatePerson(person))
                {
                    MessageBox.Show("Record Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(ID!=0)  
            {
                if (DAOPerson.deletePerson(ID))
                {
                    MessageBox.Show("Record Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Error");
                }  
                DisplayData();  
                ClearData();  
            }  
            else  
            {  
                MessageBox.Show("Please Select Record to Delete");  
            } 
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_state.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Vous selectionnez une ligne vide");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
