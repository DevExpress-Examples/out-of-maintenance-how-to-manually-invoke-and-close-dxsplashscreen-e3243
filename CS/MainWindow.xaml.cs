using System.Threading;
using System.Windows;
using DevExpress.Xpf.Core;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Loaded += MainWindow_Loaded;
            for(int i = 0; i < 100; i++) {
                DXSplashScreen.Progress(i);
                Thread.Sleep(40);
            }
        }
        void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            DXSplashScreen.Close();
            this.Activate();
        }
    }
}
