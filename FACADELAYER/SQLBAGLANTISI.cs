using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FACADELAYER
{
   public  class SQLBAGLANTISI
    {
        public static SqlConnection Baglanti = new SqlConnection(@"Data Source=DESKTOP-VBLQGME\SQLEXPRESS;Initial Catalog=DBTESTKATMAN;Integrated Security=True");
        
    }
}
//Data Source=DESKTOP-VBLQGME\SQLEXPRESS;Initial Catalog=DBTESTKATMAN;Integrated Security=True
