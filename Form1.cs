using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class txtHasil: Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=tomiskibidi\\TAMA;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        public txtHasil()
        {
            InitializeComponent();
        }
    }
}
