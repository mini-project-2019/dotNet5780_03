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

namespace dotNet5780_03_3248_0250
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<Host> hostsList = new List<Host>()
            {
                new Host()
                {
                    HostName = "גלעד יוסף",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "בית שניארסון",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "https://upload.wikimedia.org/wikipedia/commons/3/3b/Hebron101.JPG",
                                "https://upload.wikimedia.org/wikipedia/commons/d/d4/PikiWiki_Israel_43165_Shneorson_building_in_Hebron.JPG",
                            }

                        },

                        new HostingUnit()
                        {
                            UnitName = "בית הדסה",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "https://upload.wikimedia.org/wikipedia/commons/f/ff/Hebron105.JPG",
                                "https://upload.wikimedia.org/wikipedia/commons/a/a2/%D7%91%D7%99%D7%AA_%D7%94%D7%93%D7%A1%D7%94_-_%D7%9E%D7%A8%D7%A5_2019.jpg",
                            }

                        },
                    }
                },

                new Host()
                {
                    HostName = "נדב מרדכי",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "",
                                "",
                            }

                        },

                        new HostingUnit()
                        {
                            UnitName = "",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "",
                                "",
                            }

                        },
                    }
                },

                new Host()
                {
                    HostName = "",
                    Units = new List<HostingUnit>()
                    {
                        new HostingUnit()
                        {
                            UnitName = "",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "",
                                "",
                            }

                        },

                        new HostingUnit()
                        {
                            UnitName = "",
                            Rooms = 2,
                            IsSwimmimgPool = true,
                            AllOrders = new List<DateTime>(),
                            Uris = new List<string>()
                            {
                                "",
                                "",
                            }

                        },
                    }
                },

            };
            InitializeComponent();
            cbHostList.ItemsSource = hostsList;
            cbHostList.DisplayMemberPath = "HostName";
            cbHostList.SelectedIndex = 0;
        }
    }
}
