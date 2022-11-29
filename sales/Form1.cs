using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection();
        private string id;

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["sales.Properties.Settings.Database1ConnectionString"].ToString();
        }
 
        private void refetchDb(string keyword = "")
        {
            try
            {
                if (connection.State.Equals(ConnectionState.Closed))
                {
                    connection.Open();
                }

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                if(keyword == "")
                {
                    cmd.CommandText = "SELECT * FROM sales ORDER BY sold_on DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM sales WHERE item_name LIKE '%" + keyword + "%' ORDER BY sold_on DESC";
                }

                SqlDataReader reader = cmd.ExecuteReader();

                data_box.Items.Clear();
                int amount = 0;
                amount_count.Text = "$" + amount.ToString();

                while (reader.Read())
                {
                    data_box.Items.Add("" + reader["item_name"].ToString());
                    amount += Convert.ToInt32(reader["total_price"]);
                    amount_count.Text = "$" + amount.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            refetchDb(searchText.Text);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "IF EXISTS (SELECT 1 FROM sales WHERE Id = @Id)\r\n    BEGIN\r\n       UPDATE sales SET type=@type,item_name=@item_name,quantity=@quantity,total_price=@total_price,sold_on=@sold_on WHERE id=@id   END\r\nELSE\r\n    BEGIN\r\n       insert into sales(id,type,item_name,quantity,total_price,sold_on)values(@Id,@type,@item_name,@quantity,@total_price,@sold_on)    END";

                cmd.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = id_value.Value;
                cmd.Parameters.AddWithValue("@type", SqlDbType.NVarChar).Value = type_value.Text;
                cmd.Parameters.AddWithValue("@item_name", SqlDbType.NVarChar).Value = item_name_value.Text;
                cmd.Parameters.AddWithValue("@quantity", SqlDbType.Int).Value = quantity_value.Value;
                cmd.Parameters.AddWithValue("@total_price", SqlDbType.Int).Value = total_price_value.Value;
                cmd.Parameters.AddWithValue("@sold_on", SqlDbType.Date).Value = sold_on_value.Value;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refetchDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_box.SelectedIndex != -1)
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "DELETE FROM sales WHERE id='" + id + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refetchDb();
                }
                else
                {
                    MessageBox.Show("No record selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void data_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (data_box.SelectedIndex != -1)
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM sales WHERE item_name='" + data_box.SelectedItem.ToString() + "'";

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        id_value.Text = reader["id"].ToString();
                        type_value.Text = reader["type"].ToString();
                        item_name_value.Text = reader["item_name"].ToString();
                        quantity_value.Value = Convert.ToDecimal(reader["quantity"]);
                        total_price_value.Value = Convert.ToDecimal(reader["total_price"]);
                        sold_on_value.Value = (DateTime)reader["sold_on"];

                        id = id_value.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refetchDb();
        }
    }
}
