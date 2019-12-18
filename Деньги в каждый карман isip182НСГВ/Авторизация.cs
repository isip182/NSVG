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

namespace Деньги_в_каждый_карман_isip182НСГВ
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {

            string user_Login = textBox1.Text.Trim();
            string user_Password = textBox2.Text.Trim();


            SqlConnection ERDConnectionString = new SqlConnection(@"Data Source=DESKTOP-N8P7NHQ\SQLEXPRESS;Initial Catalog=Isip182;Integrated Security=True");
            string query = "Select * FROM User1 WHERE Login='"+ textBox1.Text+"' and Password='"+ textBox2.Text+"'";
            ERDConnectionString.Open();
            SqlCommand cmd = new SqlCommand(query, ERDConnectionString);
            SqlDataReader reader = cmd.ExecuteReader();

          
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                  
                }
                reader.Close();
                ERDConnectionString.Close();


        
                {
                    Form5 f5 = new Form5();

                    f5.Show();
                    
                }
                
                
            }
        }

          

        }

        
    }
                            
                        
                    

                  
        
    
        
  
