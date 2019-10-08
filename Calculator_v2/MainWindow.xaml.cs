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

namespace Calculator_v2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           int contador = 1;

            for (int i = 1; i <= 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    Viewbox vb = new Viewbox();
                    Button button = new Button();
                    TextBlock tb = new TextBlock();

                    contenedor.Children.Add(button);
                    button.Content = vb;
                    vb.Child = tb;

                    button.Tag = contador;

                    tb.Text = contador.ToString();
                    button.Margin = new Thickness(10);
                    button.Click += Button_Click;

                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);

                    
                   contador++;
                }

            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Texto.Text = Texto.Text + ((Button)sender).Tag.ToString();
        }
    }
}
