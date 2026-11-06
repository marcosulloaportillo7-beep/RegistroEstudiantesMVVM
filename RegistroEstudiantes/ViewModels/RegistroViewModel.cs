using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RegistroEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RegistroEstudiantes.ViewModels
{
    public partial class RegistroViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
        private string nombre = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
        private string correo = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
        private string telefono = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
        private string carrera = string.Empty;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(GuardarCommand))]
        private DateTime fecha = DateTime.Today;

        public ObservableCollection<Estudiante> Estudiantes { get; } = new();

        public RegistroViewModel()
        {
        }

        private bool PuedeGuardar()
        {
            return !string.IsNullOrWhiteSpace(Nombre)
                && !string.IsNullOrWhiteSpace(Correo)
                && !string.IsNullOrWhiteSpace(Telefono)
                && !string.IsNullOrWhiteSpace(Carrera);
        }

        [RelayCommand(CanExecute = nameof(PuedeGuardar))]
        private void Guardar()

        {
            Estudiantes.Add(new Estudiante
            {
                Nombre = Nombre,
                Correo = Correo,
                Telefono = Telefono,
                Carrera = Carrera,
                Fecha = Fecha
            });

            Nombre = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Carrera = string.Empty;
            Fecha = DateTime.Today;
        }

        partial void OnNombreChanged(string value)
        {
            GuardarCommand.NotifyCanExecuteChanged();
        }

        partial void OnCorreoChanged(string value)
        {
            GuardarCommand.NotifyCanExecuteChanged();
        }

        partial void OnTelefonoChanged(string value)
        {
            GuardarCommand.NotifyCanExecuteChanged();
        }

        partial void OnCarreraChanged(string value)
        {
            GuardarCommand.NotifyCanExecuteChanged();
        }
    }
}
