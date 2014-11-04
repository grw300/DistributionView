using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NI.Internal.Tools.InstallerAPI.Distributions;
using NI.Internal.Tools.InstallerAPI.Products;

namespace DistributionView
{
    public partial class DistroView : Window
    {
        public DistroView()
        {
            InitializeComponent();



            Distribution Distro = new Distribution(@"C:\Users\gwilliam\Desktop\TS2014");

            List<Product> items = new List<Product>();

            items = Distro.getProducts();

            DistroParts.ItemsSource = items;


        }
    }
}
