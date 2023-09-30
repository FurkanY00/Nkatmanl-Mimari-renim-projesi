using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace dataacceslayer
{
    
    public class baglantı
    {
        public static SqlConnection bgl =new SqlConnection(@"Data Source=DESKTOP-KPC6PV7\SQLEXPRESS;Initial Catalog=dbpersonel;Integrated Security=True");
    }
}
