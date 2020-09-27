using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Prestamos.BLL;
using Prestamos.Entidades;

namespace Prestamos.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cPrestamos.xaml
    /// </summary>
    public partial class cPrestamos : Window
    {
        public cPrestamos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
          /*  Consultas.ItemsSource = null;
            var listado = new List<Prestamo>();


                listado = PrestamoBLL.GetList(c => true);
            Consultas.ItemsSource = listado;*/
        }
    }
}