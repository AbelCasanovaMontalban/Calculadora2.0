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

namespace Calculadora2._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            for (int i = 1; i <=3; i++)
            {
                int columna = 0;
                for (int j = 0; j <3; j++)
                {
                    int numero = (i - 1) * 3 + j + 1;
                    Button b = new Button();
                    Viewbox v = new Viewbox();
                    TextBlock t = new TextBlock();
                    t.Text = $"{numero}";
                    v.Child = t;
                    b.Content = v;
                    b.Name = $"Button_{numero}";
                    b.Tag = $"{numero}";
                    b.Margin = new System.Windows.Thickness(5);
                    b.Click += new RoutedEventHandler(Button_Click);
                    b.SetValue(Grid.RowProperty, i);
                    b.SetValue(Grid.ColumnProperty, j);
                    contenedorGrid.Children.Add(b);
                    columna++;
                }
            }
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Text = ResultadoTextBlock.Text + ((Button)sender).Tag;
        }

    }
}
