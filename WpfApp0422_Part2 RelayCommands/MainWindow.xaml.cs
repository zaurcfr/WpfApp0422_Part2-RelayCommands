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
using WpfApp0422_Part2_RelayCommands.Command;

namespace WpfApp0422_Part2_RelayCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RelayCommand MessageCommand { get; set; }
        public RelayCommand SendCommand { get; set; }
        public MainWindow()
        {
            this.DataContext = this;
            MessageCommand = new RelayCommand(Display);
            SendCommand = new RelayCommand(Send);

            InitializeComponent();
        }

        public void Display(object text = null)
        {
            MessageBox.Show("Display");
        }
        public void Send(object text = null)
        {
            MessageBox.Show("Send");
        }


    }
}
