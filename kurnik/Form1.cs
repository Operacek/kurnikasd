using System.Data;
using System.Data.SqlClient;

namespace kurnik
{
    public partial class Form1 : Form
    {



        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\operak\source\repos\kurnik\kurnik\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void vejce1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVejce_Click(object sender, EventArgs e)
        {
            vejce1.Show();
            sklad1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vejce1.Hide();
            sklad1.Show();
        }
    }
}