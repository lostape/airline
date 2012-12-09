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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;

namespace airline
{
    /// <summary>
    /// Interaction logic for addflight.xaml
    /// </summary>
    public partial class addflight : Window
    {
        public MainWindow main;
        public addflight(MainWindow m)
        {
            InitializeComponent();
            main = m;
            MySqlCommand c = new MySqlCommand("select name from aircraft", main.con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            da.Fill(ds);
            this.aircraft.ItemsSource = ds.Tables[0].DefaultView;
            aircraft.DisplayMemberPath = ds.Tables[0].Columns["name"].ToString();
            aircraft.SelectedValuePath = ds.Tables[0].Columns["name"].ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand c = new MySqlCommand("insert into flight(flight_name,dep_airport_id,arr_airport_id,aircraft_id,departure_time,arrival_time)"+"select '"+flightname.Text.ToString()+"',aa.airport_id,aa2.airport_id,a.aircraft_id,str_to_date('"+datePicker1.SelectedDate.ToString().Split(' ').ElementAt(0)+" "+comboBox1.SelectedValue.ToString().Split(' ')[1]+"','%d/%m/%Y %H:%i'),str_to_date('"+datePicker2.SelectedDate.ToString().Split(' ').ElementAt(0)+" "+comboBox2.SelectedValue.ToString().Split(' ')[1]+"','%d/%m/%Y %H:%i') from aircraft as a, airport as aa,airport as aa2 where aa.city='"+departure.SelectedValue.ToString()+"' and aa2.city='"+arrival.SelectedValue.ToString()+"' and a.name='"+aircraft.SelectedValue.ToString()+"'",main.con);
            c.ExecuteNonQuery();
            this.Close();
        }

        private void aircraft_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MySqlCommand c = new MySqlCommand("select a.city from airport as a, aircraft as c, airport_serves_aircraft as asa where c.name ='" + aircraft.SelectedValue.ToString() + "' and c.aircraft_id = asa.aircraft and asa.airport = a.airport_id", main.con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            da.Fill(ds);
            this.departure.ItemsSource = ds.Tables[0].DefaultView;
            departure.DisplayMemberPath = ds.Tables[0].Columns["city"].ToString();
            departure.SelectedValuePath = ds.Tables[0].Columns["city"].ToString();

            this.arrival.ItemsSource = ds.Tables[0].DefaultView;
            arrival.DisplayMemberPath = ds.Tables[0].Columns["city"].ToString();
            arrival.SelectedValuePath = ds.Tables[0].Columns["city"].ToString();
        }
    }
}
