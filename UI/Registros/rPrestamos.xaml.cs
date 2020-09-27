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
using Prestamos.BLL;
using Prestamos.DAL;
using Prestamos.Entidades;


namespace Prestamos.UI.Registros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class rPrestamos : Window
    {
        Prestamo  Prestamo = new Prestamo();
        public rPrestamos()
        {
            InitializeComponent();
        }

        ///------------------LIMPIAR-------------------------------
        private void Limpiar()
        {
           this.Prestamo = new Prestamo();
           this.DataContext = Prestamo;
            
        }

//-----------------------BOTON NUEVO------------------------------
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

//-----------------------BOTON GUARDAR------------------------------
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            //Personas personas;
            bool Paso = false;

            if (!Validar())
               return;

            Paso = PrestamoBLL.Guardar(Prestamo);

            if (Paso)
            {
                Limpiar();
                MessageBox.Show("Se guardo correctamente!");
            }
            else
            {
                MessageBox.Show("Error al momento del guardado");
            }
        }
//-----------------------VALIDAR-----------------------------
        private bool Validar()
        {
            bool esValido = true;

            if (ConceptoTextBox.Text.Length == 0)
            {
                 esValido = false;
            MessageBox.Show("Transicion fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (MontoTextBox.Text.Length == 0)
            {
                 esValido = false;
            MessageBox.Show("Transicion fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (BalanceTextBox.Text.Length == 0)
            {
                 esValido = false;
            MessageBox.Show("Transicion fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           
            return esValido;
        }

        //-----------------------BOTON BUSCAR------------------------------
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var prestamo = PrestamoBLL.Buscar(Utilidades.ToInt(PrestamoIDTextBox.Text));

            if(prestamo!= null)
            {
               this.Prestamo = prestamo;
            }
            else
            {
              this.Prestamo = new Prestamo();
            }
            this.DataContext = this.Prestamo;
        }

//-----------------------BOTON ELIMINAR------------------------------
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (PersonasBLL.Eliminar(Utilidades.ToInt(PrestamoIDTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}