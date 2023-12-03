using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TaskManager_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent ();

            Process[] processes = Process.GetProcesses ()
                .OrderBy (process => process.ProcessName)
                .ToArray ();
            DataContext = processes;
        }

        private void ButtonKill_Click (object sender, RoutedEventArgs e) {
            // Process selected = (Process) list.SelectedItem;
            // selected.Kill ();
        }
    }
}
