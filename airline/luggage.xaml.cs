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
using System.Data;
using MySql.Data.MySqlClient;

namespace airline
{
    /// <summary>
    /// Interaction logic for luggage.xaml
    /// </summary>
    public partial class luggage : UserControl
    {
        public MainWindow main;
        public luggage(MainWindow m)
        {
            InitializeComponent();
            main = m;
            MySqlCommand cmd = new MySqlCommand("SELECT flight_name FROM flight", main.con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            this.comboBox1.ItemsSource = ds.Tables[0].DefaultView;
            comboBox1.DisplayMemberPath = ds.Tables[0].Columns["flight_name"].ToString();
            comboBox1.SelectedValuePath = ds.Tables[0].Columns["flight_name"].ToString();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand c = new MySqlCommand("select l.luggage_id as 'Tag Number', l.owner_name as 'Owner', l.owner_address as 'Address' from luggage as l, flight as f where f.flight_name ='" + comboBox1.SelectedValue.ToString() + "' and f.flight_id = l.flight_id", main.con);
            DataTable t = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            da.Fill(t);
            dataGrid1.DataContext = t;
            dataGrid1.Visibility = (Visibility)0;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new mainmenu(main);
        }
    }
}
