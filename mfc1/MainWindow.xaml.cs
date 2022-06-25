using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;

namespace mfc1
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String ConnectionString;
        private SqlConnection connection;
        private SqlCommand cmd = new SqlCommand();
       
        private SqlDataReader reader;
       
        public MainWindow()
      
        {
            InitializeComponent();
        }

        string connectionString = "Server=.\\SQLEXPRESS;Database=mfc;Trusted_Connection=True;";
        private void poisk_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + log.Text + "' AND [prol] = '" + pr.Text + "'");
            if (dt_user.Rows.Count > 0) // если такая запись существует
            
           
            {
                MainWindow ds = new MainWindow();
                Window1 sd = new Window1();
                ds.Close();
                sd.Show();
            }
            else
            {
                MessageBox.Show("Такого логина или пароля не существует", "Ошибка авторизации");

            }
            
        }
        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase"); // создаём таблицу в приложении
                                                             // подключаемся к базе данных
            SqlConnection sqlConnection = null; //SqlConnection sqlConnection = new SqlConnection("server=PC\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=testlog;");
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open(); // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand(); // создаём команду
            sqlCommand.CommandText = selectSQL; // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable); // возращаем таблицу с результатом
            return dataTable;


        }

    }
}
    
