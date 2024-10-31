using Examen_03.Models;
using Examen_03.Utilitarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen_03.ViewModels
{
    public class ViewModelListarProductos : ViewModelBase
    {
        #region Propiedades

            private string _Nombre;
            public string Nombre
            {
                get { return _Nombre; }
                set
                {
                    _Nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }

        private double _Precio;
        public double Precio
        {
            get { return _Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }

        #endregion

        public ObservableCollection<ProductoModel> Productos { get; }

        #region Comando
            public ICommand GuardarCommand { get; }
        #endregion

       
        public ViewModelListarProductos()
        {
            GuardarCommand = new RelayCommand(Guardar);
            Productos = new ObservableCollection<ProductoModel>();
        }
        private void Guardar()
        {
            Productos.Add(new ProductoModel
            {
                Nombre = this.Nombre,
                Precio= this.Precio,
                Descripcion = this.Descripcion
            });

        }

    }
}
