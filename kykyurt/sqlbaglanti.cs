using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace kykyurt
{
   public class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
           
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-LH9FG425\SQLEXPRESS;Initial Catalog=kykyurt;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
