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
    /// Interaction logic for availability.xaml
    /// </summary>
    public partial class availability : UserControl
    {
        public MainWindow main;
        public availability(MainWindow m)
        {
            InitializeComponent();
            main = m;         
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand c = new MySqlCommand("select p.name as 'Name', p.flight_hours as 'Flight Hours',p.number_of_flights as 'Flights Flown' from pilot as p where p.pid not in (select p2.pid from assignment as a, flight as f, pilot as p2 where p2.pid = a.pilot_id and a.flight_id = f.flight_id and (date(f.departure_time) =str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') or date(f.arrival_time) =str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y')))", main.con);
            MySqlDataAdapter da = new MySqlDataAdapter(c);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGrid1.DataContext = dt;
            dataGrid1.Visibility = (Visibility)0;

            c = new MySqlCommand("select fa.name as 'Name', fa.years_worked as 'Years Worked', fa.service_rating as 'Service Rating' from flight_attendant as fa where fa.fa_id not in (select fa2.fa_id from assignment as a, flight as f, flight_attendant as fa2 where fa2.fa_id = a.fa_id and a.flight_id = f.flight_id and (date(f.departure_time) =str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') or date(f.arrival_time) =str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y')))", main.con);
            da = new MySqlDataAdapter(c);
            dt = new DataTable();
            da.Fill(dt);
            dataGrid2.DataContext = dt;
            dataGrid2.Visibility = (Visibility)0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Assignment a = new Assignment(main, 0, (dataGrid1.SelectedItem as DataRowView).Row.ItemArray[0].ToString());
            a.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Assignment a = new Assignment(main, 1, (dataGrid2.SelectedItem as DataRowView).Row.ItemArray[0].ToString());
            a.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new mainmenu(main);
        }
    }
}
