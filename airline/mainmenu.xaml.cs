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

namespace airline
{
    /// <summary>
    /// Interaction logic for mainmenu.xaml
    /// </summary>
    public partial class mainmenu : UserControl
    {
        public MainWindow main;

        public mainmenu(MainWindow m)
        {
            InitializeComponent();
            main = m;
            
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            int c = choice.SelectedIndex;

            switch (c)
            {
                case 0:
                    main.Content = new flights(main);
                    break;
                case 1:
                    main.Content = new mainentance(main);
                    break;
                case 2:
                    main.Content = new luggage(main);
                    break;
                case 3:
                    main.Content = new pilotassignments(main);
                    break;
                case 4:
                    main.Content = new availability(main);
                    break;
            }
        }

    }
}
