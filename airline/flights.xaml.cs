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
    /// Interaction logic for flights.xaml
    /// </summary>
    public partial class flights : UserControl
    {
        public MainWindow main;

        public flights(MainWindow m)
        {
            InitializeComponent();
            main = m;
            MySqlCommand cmd = new MySqlCommand("SELECT NAME FROM airport", main.con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);
            this.airport.ItemsSource  = ds.Tables[0].DefaultView;
            airport.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
            airport.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();

            departures.Visibility = (Visibility)1;
            arrivals.Visibility = (Visibility)1;

        }

        private void airport_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT flight.flight_name as 'Flight', a2.city as 'To',flight.departure_time as 'Departs at' FROM flight, airport, airport as a2 where flight.arr_airport_id = a2.airport_id and flight.dep_airport_id = airport.airport_id and airport.name ='"+airport.SelectedValue.ToString()+"'", main.con);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            departures.DataContext = dt;


            MySqlCommand cmd2 = new MySqlCommand("SELECT flight.flight_name as 'Flight',a2.city as 'From',flight.arrival_time as 'Arrives at' FROM flight, airport, airport as a2 where flight.dep_airport_id = a2.airport_id and flight.arr_airport_id = airport.airport_id and airport.name ='" + airport.SelectedValue.ToString() + "'", main.con);
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            arrivals.DataContext = dt2;

            departures.Visibility = (Visibility)0;
            arrivals.Visibility = (Visibility)0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new mainmenu(main);
        }
    }
}
