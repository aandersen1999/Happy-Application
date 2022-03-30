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
using System.Speech.Synthesis;

namespace Happy_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri iconUri = new Uri("pack://application:,,,/Resources/HappyFaceUpsideDown.ico");
        SpeechSynthesizer mainSynth = new SpeechSynthesizer();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Icon = BitmapFrame.Create(iconUri);
            mainSynth.Speak("Test");
        }
    }
}
