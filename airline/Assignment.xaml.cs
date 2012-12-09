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
    /// Interaction logic for Assignment.xaml
    /// </summary>
    public partial class Assignment : Window
    {
        public MainWindow main;
        public int type;
        public string name;
        public Assignment(MainWindow m, int t, string name, string date)
        {
            InitializeComponent();
            main = m;
            type = t;
            this.name = name;

            if (t == 1)
            {
                MySqlCommand f = new MySqlCommand("SELECT FLIGHT_NAME FROM flight as f where date(f.departure_time) = str_to_date('"+date+"','%d/%m/%Y')", main.con);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter da1 = new MySqlDataAdapter(f);
                da1.Fill(ds1);
                this.flights.ItemsSource = ds1.Tables[0].DefaultView;
                flights.DisplayMemberPath = ds1.Tables[0].Columns["FLIGHT_NAME"].ToString();
                flights.SelectedValuePath = ds1.Tables[0].Columns["FLIGHT_NAME"].ToString();
            }
            else
            {
                MySqlCommand f = new MySqlCommand("SELECT f.FLIGHT_NAME FROM pilot, can_fly, flight as f where pilot.NAME = '" + name + "' and pilot.PID = can_fly.PILOT_ID and can_fly.AIRCRAFT_ID = f.AIRCRAFT_ID and date(f.departure_time) = str_to_date('" + date + "','%d/%m/%Y')", main.con);
                DataSet ds1 = new DataSet();
                MySqlDataAdapter da1 = new MySqlDataAdapter(f);
                da1.Fill(ds1);
                this.flights.ItemsSource = ds1.Tables[0].DefaultView;
                flights.DisplayMemberPath = ds1.Tables[0].Columns["FLIGHT_NAME"].ToString();
                flights.SelectedValuePath = ds1.Tables[0].Columns["FLIGHT_NAME"].ToString();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            MySqlCommand c = new MySqlCommand("select FLIGHT_ID from flight where FLIGHT_NAME ='" + flights.SelectedValue.ToString() + "'", main.con);
            MySqlDataReader r = c.ExecuteReader();
            string flightid=null;
            if (r.Read())
            {
                flightid = r.GetString("FLIGHT_ID");
            }
            r.Close();

            string id=null;
            switch (type)
            {
                case 0:
                    c = new MySqlCommand("select PID from pilot where pilot.NAME ='" + name + "'", main.con);
                    r = c.ExecuteReader();
                    if (r.Read())
                    {
                        id = r.GetString("PID");
                    }
                    MySqlCommand ins = new MySqlCommand("insert into assignment (FLIGHT_ID, PILOT_ID) values ('" + flightid + "','" + id + "')", main.con);
                    r.Close();
                    ins.ExecuteNonQuery();
                    break;
                case 1:
                    c = new MySqlCommand("select FA_ID from flight_attendant where flight_attendant.NAME ='" + name + "'", main.con);
                    r = c.ExecuteReader();
                    if (r.Read())
                    {
                        id = r.GetString("FA_ID");
                    }
                    ins = new MySqlCommand("insert into assignment (FLIGHT_ID, FA_ID) values ('" + flightid + "','" + id + "')", main.con);
                    r.Close();
                    ins.ExecuteNonQuery();
                    break;
            }

            this.Close();
        }
    }
}
