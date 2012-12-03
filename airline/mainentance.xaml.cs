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
    /// Interaction logic for mainentance.xaml
    /// </summary>
    public partial class mainentance : UserControl
    {

        public MainWindow main;
        public mainentance(MainWindow m)
        {
            InitializeComponent();
            main = m;
            MySqlCommand p = new MySqlCommand("SELECT NAME FROM aircraft", main.con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(p);
            da.Fill(ds);
            this.aircraft.ItemsSource = ds.Tables[0].DefaultView;
            aircraft.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
            aircraft.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT a.name as 'Name',m.effort_hours as 'Effort in hours',p.name as 'Worked On',m.date_performed as 'Date',m.next_service_date as 'Next Service Date'  from aircraft as a, maintenance_session as m, part as p where p.id = m.part_worked_on and a.name ='" + aircraft.SelectedValue.ToString() + "' and a.aircraft_id = m.aircraft_id and m.date_performed >=str_to_date('" + datePicker2.SelectedDate.ToString() + "','%d/%m/%Y') and m.date_performed <=str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y')", main.con);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGrid1.DataContext = dt;
            dataGrid1.Visibility = (Visibility)0;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new mainmenu(main);
        }
    }
}
