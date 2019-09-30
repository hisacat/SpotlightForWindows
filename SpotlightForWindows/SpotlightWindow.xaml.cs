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
using System.Windows.Shapes;

namespace SpotlightForWindows
{
    /// <summary>
    /// Spotlight.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SpotlightWindow : Window
    {
        public SpotlightWindow()
        {
            Init();

            InitializeComponent();
        }

        private void Init()
        {
            DelegateWindowEvents();
        }

        private void DelegateWindowEvents()
        {
            this.Deactivated += SpotlightWindow_Deactivated;
        }

        private void SpotlightWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
