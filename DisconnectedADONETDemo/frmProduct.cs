using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace DisconnectedADONETDemo
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            Console.WriteLine($"Connection String: {strConnection}");
            return strConnection;
        }

        DataSet dsMyStore = new DataSet();

        private void frmProduct_Load(object sender, EventArgs e)
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();

            string sql = "Select ProductID, ProductName, CategoryID, Price from ProductList; Select * from Categories";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, GetConnectionString());
                adapter.Fill(dsMyStore);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Get data from Database");
            }
        }

        
        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];
        }
    }
} 
