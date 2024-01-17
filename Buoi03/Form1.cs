using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;
using System.Data;

namespace Buoi03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDataWithReader();
            loadDataWithReaderHomeStyle();
            loadDataWithReaderConvenice();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void loadDataWithReader()
        {
            string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-PTPMUD;Integrated Security=True";
           
            SqlConnection conn = new(constr);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Service";
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken) ;
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();

              /*  int i = 0;*/

                while (reader.Read())
                {
                    checkedListBox1.Items.Add(reader["Name"]);
                  /*  RadioButton radioButton = new RadioButton();
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(15, 26 + i * 30);
                    radioButton.Name = "rd" + reader["Id"].ToString();
                    radioButton.Size = new Size(117, 24);
                    radioButton.TabIndex = i;
                    radioButton.TabStop = true;
                    radioButton.Text = reader["Name"].ToString();
                    radioButton.UseVisualStyleBackColor = true;
                    gbLoaiPhong.Controls.Add(radioButton);
                    i++;*/
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }

            
        }

        public void loadDataWithReaderHomeStyle()
        {
            string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-PTPMUD;Integrated Security=True";

            SqlConnection conn = new(constr);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "select * from RoomType";
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken) ;
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();

                int i = 0;

                while (reader.Read())
                {
                    /*gbLoaiPhong.Items.Add(reader["Name"]);*/
                    RadioButton radioButton = new RadioButton();
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(15, 26 + i * 30);
                    radioButton.Name = "rd" + reader["Id"].ToString();
                    radioButton.Size = new Size(117, 24);
                    radioButton.TabIndex = i;
                    radioButton.TabStop = true;
                    radioButton.Text = reader["Name"].ToString();
                    radioButton.UseVisualStyleBackColor = true;
                    gbLoaiPhong.Controls.Add(radioButton);
                    i++;
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void loadDataWithReaderConvenice()
        {
            string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB-PTPMUD;Integrated Security=True";

            SqlConnection conn = new(constr);
            SqlCommand cmd = new();
            cmd.Connection = conn;
            cmd.CommandText = "select * from convenience";
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken) ;
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();

               /* int i = 0;*/

                while (reader.Read())
                {
                    checkedListBox2.Items.Add(reader["Name"]);
                   /* RadioButton radioButton = new RadioButton();
                    radioButton.AutoSize = true;
                    radioButton.Location = new Point(15, 26 + i * 30);
                    radioButton.Name = "rd" + reader["Id"].ToString();
                    radioButton.Size = new Size(117, 24);
                    radioButton.TabIndex = i;
                    radioButton.TabStop = true;
                    radioButton.Text = reader["Name"].ToString();
                    radioButton.UseVisualStyleBackColor = true;
                    gbLoaiPhong.Controls.Add(radioButton);
                    i++;*/
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
