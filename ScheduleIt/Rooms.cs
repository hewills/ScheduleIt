using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleIt
{
    public partial class Rooms : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;

        public Rooms()
        {
            InitializeComponent();
            
            conn = new SqlConnection
            {
                ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                    "Initial Catalog=db1master;" +
                    "Integrated Security=True;" +
                    "Connect Timeout=60;" +
                    "Encrypt=False;" +
                    "TrustServerCertificate=False;" +
                    "ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False;"
            };

            conn.Open();
            adapter = CreateSqlDataAdapter(conn);

        }

        public static SqlDataAdapter CreateSqlDataAdapter(SqlConnection connection)
        {
            SqlDataAdapter data = new SqlDataAdapter();

            // Create the commands.
            data.SelectCommand = new SqlCommand(
                "SELECT room_id,building,room_num,capacity FROM rooms", connection);
            data.InsertCommand = new SqlCommand(
                "INSERT INTO rooms (room_id,building,room_num,capacity) " +
                "VALUES (@room_id, @building, @room_num, @capacity)", connection);
            data.UpdateCommand = new SqlCommand(
                "UPDATE rooms SET room_id = @room_id, building = @building, room_num = @room_num, capacity = @capacity " +
                "WHERE room_id = @room_id", connection);
            data.DeleteCommand = new SqlCommand(
                "DELETE FROM rooms WHERE room_id = @room_id", connection);

            // Create the parameters.
            data.InsertCommand.Parameters.Add("@room_id",
                SqlDbType.Int, 4, "room_id");
            data.InsertCommand.Parameters.Add("@building",
                SqlDbType.VarChar, 100, "building");
            data.InsertCommand.Parameters.Add("@room_num",
                SqlDbType.VarChar, 10, "room_num");
            data.InsertCommand.Parameters.Add("@capacity",
                SqlDbType.VarChar, 10, "capacity");

//            data.UpdateCommand.Parameters.Add("@room_id", SqlDbType.Int, 4, "room_id").SourceColumn = data.

            data.UpdateCommand.Parameters.Add("@building",
                SqlDbType.VarChar, 100, "building");
            data.UpdateCommand.Parameters.Add("@room_num",
                SqlDbType.VarChar, 10, "room_num");
            data.UpdateCommand.Parameters.Add("@capacity",
                SqlDbType.VarChar, 10, "capacity");

            data.DeleteCommand.Parameters.Add("@room_id",
                SqlDbType.Int, 4, "room_id").SourceVersion =
                DataRowVersion.Original;

            return data;
        }

        //Save data button
        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db1DataSet);

            //Update Database source
            // adapter.Update(db1DataSet);
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db1DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.db1DataSet.rooms);

        }
    }
}
