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
    /// Interaction logic for pilotassignments.xaml
    /// </summary>
    public partial class pilotassignments : UserControl
    {
        private MainWindow main;

        public pilotassignments(MainWindow m)
        {
            InitializeComponent();
            main = m;
            
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MySqlCommand c = null;
            DataSet ds = null;
            MySqlDataAdapter da = null;
            int t = this.type.SelectedIndex;
            switch (t)
            {
                case 0:
                    c = new MySqlCommand("SELECT NAME FROM pilot", main.con);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(c);
                    da.Fill(ds);
                    this.name.ItemsSource = ds.Tables[0].DefaultView;
                    name.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
                    name.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();
                    break;
                case 1:
                    c = new MySqlCommand("SELECT NAME FROM flight_attendant", main.con);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(c);
                    da.Fill(ds);
                    this.name.ItemsSource = ds.Tables[0].DefaultView;
                    name.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
                    name.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();
                    break;
                case 2:
                    c = new MySqlCommand("SELECT NAME FROM maintenance_crew", main.con);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(c);
                    da.Fill(ds);
                    this.name.ItemsSource = ds.Tables[0].DefaultView;
                    name.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
                    name.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();
                    break;
                case 3:
                    c = new MySqlCommand("SELECT NAME FROM luggage_crew", main.con);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(c);
                    da.Fill(ds);
                    this.name.ItemsSource = ds.Tables[0].DefaultView;
                    name.DisplayMemberPath = ds.Tables[0].Columns["NAME"].ToString();
                    name.SelectedValuePath = ds.Tables[0].Columns["NAME"].ToString();
                    break;

            }
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new mainmenu(main);
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand c = null;
            MySqlDataAdapter da = null;
            DataTable dt = null;
            int t = this.type.SelectedIndex;
            switch (t)
            {
                case 0:
                    c = new MySqlCommand("select p.name as 'Name', f.flight_name as 'Flight', f.departure_time as 'Date' from assignment as a, pilot as p, flight as f where p.name ='" + name.SelectedValue.ToString() + "' and p.pid = a.pilot_id and a.flight_id = f.flight_id and f.departure_time >=str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') and f.departure_time <=str_to_date('" + datePicker2.SelectedDate.ToString() + "','%d/%m/%Y')", main.con);
                    da = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGrid1.DataContext = dt;
                    dataGrid1.Visibility = (Visibility)0;
                    break;
                case 1:
                    c = new MySqlCommand("select fa.name as 'Name', f.flight_name as 'Flight', f.departure_time as 'Date' from assignment as a, flight_attendant as fa, flight as f where fa.name ='" + name.SelectedValue.ToString() + "' and fa.fa_id = a.fa_id and a.flight_id = f.flight_id and f.departure_time >=str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') and f.departure_time <=str_to_date('" + datePicker2.SelectedDate.ToString() + "','%d/%m/%Y')", main.con);
                    da = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGrid1.DataContext = dt;
                    dataGrid1.Visibility = (Visibility)0;
                    break;
                case 2:
                    c = new MySqlCommand("select a.name as 'Name',m.effort_hours as 'Effort in hours',pa.name as 'Worked On',m.date_performed as 'Date',m.next_service_date as 'Next Service Date' from aircraft as a, maintenance_session as m, performs_maintenance as p, part as pa, maintenance_crew as mc where pa.id = m.part_worked_on and a.aircraft_id = m.aircraft_id and m.session_id = p.session_id and p.maint_id = mc.maint_crew_id and mc.name ='"+name.SelectedValue.ToString()+"' and m.date_performed >=str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') and m.date_performed <=str_to_date('" + datePicker2.SelectedDate.ToString() + "','%d/%m/%Y')", main.con);
                    da = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGrid1.DataContext = dt;
                    dataGrid1.Visibility = (Visibility)0;
                    break;
                case 3:
                    c = new MySqlCommand("select f.flight_name as 'Flight',l.luggage_id as 'Tag Number', l.owner_name as 'Owner', l.owner_address as 'Address' from luggage as l, luggage_crew as lc, flight as f where lc.name ='"+name.SelectedValue.ToString()+"' and lc.luggage_crew_id = l.luggage_crew_id and l.flight_id = f.flight_id and f.departure_time >=str_to_date('" + datePicker1.SelectedDate.ToString() + "','%d/%m/%Y') and f.departure_time <=str_to_date('" + datePicker2.SelectedDate.ToString() + "','%d/%m/%Y')", main.con);
                    da = new MySqlDataAdapter(c);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGrid1.DataContext = dt;
                    dataGrid1.Visibility = (Visibility)0;
                    break;
            }
        }
    
}}
