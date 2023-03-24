using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Wpfburbuja
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int [,] mat1;
        private int [,] mat2;
        private int [] arreglo;
    
        private void btncargar_Click(object sender, RoutedEventArgs e)
        {
            Random num = new Random();
            mat1 = new int[5, 5];
            arreglo = new int[25];
            grid3.Children.Clear();
            grid4.Children.Clear();
            for (int r =0; r < 5; r++)
            {
                for(int c=0; c < 5; c++)
                {
                    mat1[r, c] = num.Next(1,100);
                    Label lbl = new Label();
                    lbl.Content = mat1[r, c];
                    Grid.SetColumn(lbl, c);
                    Grid.SetRow(lbl, r);
                    grid3.Children.Add(lbl);
                }
            }
        }
        int contador = 0;
        private void burbuja()
        {
            

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    arreglo[contador] = mat1[r, c];
                    contador++;

                }
            }
        }
        private void ordenamientoporseleccion()
        {
            int n = arreglo.Length;
            for(int i = 0; i < n - 1; i++)
            {
                int jenni = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (arreglo [j] < arreglo[jenni])
                    {
                        jenni = j;
                    }
                }
                if(jenni !=¡)
                     {

                    }
                int temp = arreglo[i];
                arreglo[i] = arreglo[jenni];
                arreglo[jenni] = temp;
            }
        }
        private void ordenamientoporinsercion()
        {

        }
        private void ordenamientoporshell()
        {

        }
        private void ordenamientopormezcla()
        {

        }
        private void ordenamientoporrapido()
        {

        }
        private void visualizamatrizordenada()
        {
            mat2 = new int[5, 5];

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
            int contador2 = 0;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat2[r, c] = arreglo[contador2];
                    Label lbl = new Label();
                    lbl.Content = mat2[r, c];
                    Grid.SetColumn(lbl, c);
                    Grid.SetRow(lbl, r);
                    grid4.Children.Add(lbl);
                    contador2++;
                }
            }

        }
        private void btnburbuja_Click(object sender, RoutedEventArgs e)
        {
            burbuja();
            visualizamatrizordenada();
        }

        private void btnseleccion(object sender, RoutedEventArgs e)
        {
            ordenamientoporseleccion();
            visualizamatrizordenada();
        }

        private void btninsercion_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporinsercion();
            visualizamatrizordenada();
        }

        private void btnshell_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporshell();
            visualizamatrizordenada();
        }

        private void btnmezcla_Click(object sender, RoutedEventArgs e)
        {
            ordenamientopormezcla();
            visualizamatrizordenada();
        }

        private void btnrapido_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporrapido();
            visualizamatrizordenada();
        }
    }
}
