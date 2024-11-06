using System.Text;
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

namespace ExpatConversionTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    using System.Windows.Threading; // Add this at the top with other using directives

    public partial class MainWindow : Window
    {
        private DispatcherTimer? timer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            DateTime utcNow = DateTime.UtcNow;

            // UK Time
            TimeZoneInfo ukTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime ukTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, ukTimeZone);
            UKTimeLabel.Content = ukTime.ToString("HH:mm:ss");

            // US Eastern Time
            TimeZoneInfo estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, estTimeZone);
            ESTTimeLabel.Content = estTime.ToString("HH:mm:ss");
        }

        private void ConvertTemperature(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TempInput.Text, out double input))
            {
                if (TempUnit.SelectedIndex == 0) // Celsius to Fahrenheit
                {
                    double result = (input * 9 / 5) + 32;
                    TempResult.Content = $"Result: {result:F2} °F";
                }
                else if (TempUnit.SelectedIndex == 1) // Fahrenheit to Celsius
                {
                    double result = (input - 32) * 5 / 9;
                    TempResult.Content = $"Result: {result:F2} °C";
                }
                else
                {
                    TempResult.Content = "Please select a conversion type.";
                }
            }
            else
            {
                TempResult.Content = "Invalid input.";
            }
        }

        private void ConvertMetric(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(MetricInput.Text, out double input))
            {
                switch (MetricUnit.SelectedIndex)
                {
                    case 0: // Kilometers to Miles
                        double miles = input * 0.621371;
                        MetricResult.Content = $"Result: {miles:F2} miles";
                        break;
                    case 1: // Kilograms to Pounds
                        double pounds = input * 2.20462;
                        MetricResult.Content = $"Result: {pounds:F2} lbs";
                        break;
                    default:
                        MetricResult.Content = "Please select a conversion type.";
                        break;
                }
            }
            else
            {
                MetricResult.Content = "Invalid input.";
            }
        }
    }
}