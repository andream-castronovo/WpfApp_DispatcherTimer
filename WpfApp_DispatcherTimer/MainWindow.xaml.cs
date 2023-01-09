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
using System.Windows.Threading;

namespace WpfApp_DispatcherTimer
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _dt;

        public MainWindow()
        {
            InitializeComponent();
            SetupTimer();
        }

        void SetupTimer()
        {
            _dt = new DispatcherTimer();
            _dt.Interval = TimeSpan.FromMilliseconds(50);
            _dt.Tick += new EventHandler(DispatcherTimer_Tick);
            _dt.Start();
        }


        int _i = 0;    
        void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            _i++;
            txtContatore.Text = _i + "";
        }
    }
}
