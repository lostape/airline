using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace airline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MySqlConnection con;

        public MainWindow()
        {
            InitializeComponent();
            this.Content = new mainmenu(this);
            setupSQLConnection();
        }

        private void setupSQLConnection()
        {
            con = new MySqlConnection("SERVER=localhost;DATABASE=airlinedb;UID=root;PASSWORD=root");
            con.Open();
            MySqlCommand c = new MySqlCommand("SELECT * FROM luggage", con);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            da.Fill(dt);
            dataGrid1.DataContext = dt;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=airlinedb;UID=root;PASSWORD=root");
            con.Open();
            
            MySqlCommand c = new MySqlCommand("SELECT * FROM luggage", con);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            da.Fill(dt);
            dataGrid1.DataContext = dt;
            con.Close();

        }

    }
}
