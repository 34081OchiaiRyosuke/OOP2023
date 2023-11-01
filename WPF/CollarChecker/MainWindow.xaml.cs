using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            stockList.Items.Add("R: " + rValue.Text + " G: " + gValue.Text  + " B: " + bValue.Text);
            
        }

        private void rgbSilder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rSilder.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush iro = new SolidColorBrush(color);
            colorArea.Background = iro;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
            SolidColorBrush iro = new SolidColorBrush(color);
            colorArea.Background = iro;
            rSilder.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] vs = stockList.SelectedItem.ToString().Split(' ');
            rValue.Text = vs[1];
            gValue.Text = vs[3];
            bValue.Text = vs[5];

        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
