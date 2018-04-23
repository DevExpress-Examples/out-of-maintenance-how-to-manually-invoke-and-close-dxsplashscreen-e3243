// Developer Express Code Central Example:
// How to manually invoke and close DXSplashScreen
// 
// This example shows how to manually invoke and close DXSplashScreen. By default,
// DXSplashScreen contains a progress bar, indicating the progress of the
// application load. This example also shows how you can manually change the
// progress in code.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3243

using DevExpress.Xpf.Core;
using System.Windows;

namespace DXSplashScreenSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Loaded += OnLoaded;
            for(int i = 0; i < 100; i++) {
                DXSplashScreen.Progress(i);
                DXSplashScreen.SetState(string.Format("{0} %", (i + 1)));
                System.Threading.Thread.Sleep(40);
            }
        }

        void OnLoaded(object sender, RoutedEventArgs e) {
            DXSplashScreen.Close();
        }
    }
}
