using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TestSmartConverter
{
    public partial class MainWindow : Window
    {

        public Dictionary<string,string> Labels
    {
        get { return (Dictionary<string,string>)GetValue(LabelsProperty); }
        set { SetValue(LabelsProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Labels.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty LabelsProperty =
        DependencyProperty.Register("Labels", typeof(Dictionary<string,string>), typeof(MainWindow), new PropertyMetadata(null));


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Labels = new Dictionary<string, string>();
            Labels.Add("a","a*");
            Labels.Add("b", "b*");
        }
    }
}
