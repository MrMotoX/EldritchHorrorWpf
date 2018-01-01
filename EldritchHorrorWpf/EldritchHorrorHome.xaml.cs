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

namespace EldritchHorrorWpf
{
    /// <summary>
    /// Interaction logic for EldritchHorrorHome.xaml
    /// </summary>
    public partial class EldritchHorrorHome : Page
    {
        public static Asset Reserve;

        public EldritchHorrorHome()
        {
            InitializeComponent();
        }

        private void RestartGameButton_Click(object sender, RoutedEventArgs e)
        {
            GameSetup gameSetupPage = new GameSetup();
            this.NavigationService.Navigate(gameSetupPage);
        }

        private void LoadReserveButton_Click(object sender, RoutedEventArgs e)
        {
            //CardHandler.FillReserve();
            Reserve = CardHandler.RemoveFirstAssetFromDeckAndReturn();
            //CardName = Reserve.GetName();
        }
    }
}
