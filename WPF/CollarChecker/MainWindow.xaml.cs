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
                .Select(i => new MyColor((Color)i.GetValue(null),i.Name) { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if(cbColor.SelectedIndex == -1) {
                stockList.Items.Add("R: " + rValue.Text + " G: " + gValue.Text + " B: " + bValue.Text);
            }
            else {
                MyColor mycolor = new MyColor(Color.FromRgb((byte)rSilder.Value, (byte)gSlider.Value, (byte)bSlider.Value), cbColor.Text);
                stockList.Items.Add(mycolor);
                cbColor.SelectedIndex = -1;
            }
            
        }

        private void rgbSilder_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Color color = Color.FromRgb((byte)rSilder.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            SolidColorBrush iro = new SolidColorBrush(color);
            colorArea.Background = iro;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cbColor.SelectedIndex != -1) {
                var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
                var color = mycolor.Color;
                var name = mycolor.Name;
                SolidColorBrush iro = new SolidColorBrush(color);
                colorArea.Background = iro;
                rSilder.Value = color.R;
                gSlider.Value = color.G;
                bSlider.Value = color.B;
            }
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedItem.ToString().Contains(" ")) {
                string[] vs = stockList.SelectedItem.ToString().Split(' ');
                rValue.Text = vs[1];
                gValue.Text = vs[3];
                bValue.Text = vs[5];
            }
            else {
                MyColor mycolor = (MyColor)stockList.SelectedItem;
                rValue.Text = mycolor.Color.R.ToString();
                gValue.Text = mycolor.Color.G.ToString();
                bValue.Text = mycolor.Color.B.ToString();
            }
        }

        private void stockList_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            if (stockList.SelectedItem.ToString().Contains(" ")) {
                string[] vs = stockList.SelectedItem.ToString().Split(' ');
                rValue.Text = vs[1];
                gValue.Text = vs[3];
                bValue.Text = vs[5];
            }
            else {
                MyColor mycolor = (MyColor)stockList.SelectedItem;
                rValue.Text = mycolor.Color.R.ToString();
                gValue.Text = mycolor.Color.G.ToString();
                bValue.Text = mycolor.Color.B.ToString();
            }
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }

        public MyColor(Color Color, string Name) {
            this.Color = Color;
            this.Name = Name;
        }

        public override string ToString() {
            return Name;
        }
    }
}
