using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
 
using System.Data.SqlClient;

namespace Web.Repository
{
    public class ProductRepository
    {
        public DataTable RetriveTopProduct()
        {
            string query = "select *from Products p join ProductGroups pg on p.ProductGroupID=pg.ProductGroupId where pg.IsDefault=1";
            Cconnect connect = new Cconnect();

            SqlCommand command = new SqlCommand(query, connect.GetConnection());
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adt.Fill(tb);
            connect.CloseConnection();
            return tb;
        }

        public DataRow GetBrekCumForProduct(Int32 productGroupId)
        {
            string query = "select g.CategoryId, g.Name, g.ProductGroupId, c.CategoryName from ProductGroups g join Category c on  c.Id = g.CategoryId where g.ProductGroupId = " + productGroupId;
            Cconnect connect = new Cconnect();

            SqlCommand command = new SqlCommand(query, connect.GetConnection());
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adt.Fill(tb);
            connect.CloseConnection();
            if (tb.Rows.Count > 0)
            {
                return tb.Rows[0];
            }
            return null;
        }

        public DataRow GetBrekCumForProductGroup(Int32 categoryId)
        {
            string query = "select *from Category where Id= " + categoryId;
            Cconnect connect = new Cconnect();

            SqlCommand command = new SqlCommand(query, connect.GetConnection());
            SqlDataAdapter adt = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adt.Fill(tb);
            connect.CloseConnection();
            if (tb.Rows.Count > 0)
            {
                return tb.Rows[0];
            }
            return null;
        }
    }
}
