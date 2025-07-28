using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookAddress
{
    public partial class FormAB : Form
    {
        DataTable dt = new DataTable();
        int cur = 0;
        public FormAB()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void formload(object sender, EventArgs e)
        {
            string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True;";
            string query = "select * from AddressBookTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlConnection conn = new SqlConnection(con);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (dt.Rows.Count > 0)
            {
                cur = dt.Rows.Count;
            }
        }
        private void Display(int cur)
        {
            tname.Text = dt.Rows[cur]["Name"].ToString();
            taddress.Text = dt.Rows[cur]["Address"].ToString();
            tphone.Text = dt.Rows[cur]["PhoneNumber"].ToString();
        }

        private void bpre_Click(object sender, EventArgs e)
        {
            
            cur--;
            
            if (cur < 0)
            {
                cur = 0;
            }
            else
            {
                MessageBox.Show("No Record");
            }
                Display(cur);
        }

        private void badd_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(con);
            string name = tname.Text;
            string address = taddress.Text;
            string phone = tphone.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tphone.Focus();
                return;
            }
            try
            {
                conn.Open();
                string query = "INSERT INTO AddressBookTable (Name, Address, PhoneNUmber) VALUES (@Name, @Address, @PhoneNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            tname.Clear();
            taddress.Clear();
            tphone.Clear();
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            DisplayForm displayForm = new DisplayForm();
            displayForm.ShowDialog();
        }
    }
}