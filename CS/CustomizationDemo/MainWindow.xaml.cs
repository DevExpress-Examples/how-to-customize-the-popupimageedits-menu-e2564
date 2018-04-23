using System.Windows;

namespace CustomizationDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void OnApplyEffectButtonClick(object sender, RoutedEventArgs e) {
            if(edit.ImageEffect == null)
                edit.ImageEffect = new GrayscaleEffect();
        }

        private void OnUndoEffectButtonClick(object sender, RoutedEventArgs e) {
            edit.ImageEffect = null;
        }
    }
}
