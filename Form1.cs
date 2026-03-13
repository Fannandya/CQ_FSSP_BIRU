using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class txtHasil: Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public txtHasil()
        {
            InitializeComponent();
        }
    }
}
