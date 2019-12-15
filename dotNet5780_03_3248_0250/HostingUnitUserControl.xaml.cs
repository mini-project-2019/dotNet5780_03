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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class HostingUnitUserControl : UserControl
    {
        public HostingUnit CurrentHostingUnit; // test
        public HostingUnitUserControl(HostingUnit hostingUnit)
        {
            InitializeComponent();
            this.CurrentHostingUnit = hostingUnit;
            UserControlGrid.DataContext = hostingUnit;
        }
    }
}
